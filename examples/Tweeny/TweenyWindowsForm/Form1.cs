using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidLibrary;

namespace TweenyWindowsForm
{
   public partial class Form1 : Form
   {
      private const int WM_DEVICECHANGE = 0x0219;
      private const int DBT_DEVNODES_CHANGED = 0x0007; //device changed
      private const int VendorId = 0x16C0;
      private const int ProductId = 0x0486;

      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
      protected override void WndProc(ref Message m)
      {
         if (m.Msg == WM_DEVICECHANGE && m.WParam.ToInt32() == DBT_DEVNODES_CHANGED)
         {
            Debug.WriteLine("usb change");
         } 
         base.WndProc(ref m);
      } 

      private HidDevice _device; 
      private bool _isAttached = false;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         Connect();
      }

      private bool Connect()
      {
         _device = HidDevices.Enumerate(VendorId, ProductId, 0xFFAB, 0x0200).FirstOrDefault();
         if (_device != null)
         {
            _device.OpenDevice();
            _device.Inserted += DeviceAttachedHandler;
            _device.Removed += DeviceRemovedHandler;

            _device.MonitorDeviceEvents = true;
            _isAttached = true;
            PrintOutputLine("rawhid device found");
         }
         else
         {
            PrintOutputLine("no rawhid found");
            _isAttached = false;
         }
         return _isAttached;
      }

      private void DeviceAttachedHandler()
      {
         PrintOutputLine("Teeny attached");
         _isAttached = true;
         _device.ReadReport(OnReport);
      }

      private void DeviceRemovedHandler()
      {
         PrintOutputLine("Teensy detached");
         _isAttached = false;
      }

      private void refreshButton_Click(object sender, EventArgs e)
      {
         if (_device != null)
         {
            _device.Dispose();
            _device = null;
            _isAttached = false;
         }
         Connect();
      }

      private void OnReport(HidReport report)
      {
         if (!_isAttached)
         {
            return;
         }

         var data = report.Data;
         PrintOutputLine(string.Format("recv {0} bytes:", data.Length));

         string outputString = string.Empty;
         for (int i = 0; i < data.Length; i++)
         {
            outputString += string.Format("{0:X2} ", data[i]);
            if (i % 16 == 15 && i < data.Length)
            {
               PrintOutputLine(outputString);
               outputString = string.Empty;
            }
         }
         PrintOutputLine("\n");

         _device.ReadReport(OnReport);
      }

      private void PrintOutputLine(string message)
      {
         if (string.IsNullOrWhiteSpace(message))
         {
            return;
         }
         if (outputTextBox.InvokeRequired)
         {
            outputTextBox.Invoke(new Action(() => PrintOutputLine(message)));
            return;
         }
         outputTextBox.AppendText(message + Environment.NewLine);
#if DEBUG
         Debug.WriteLine(message);
#endif
      }

      private void sendButton_Click(object sender, EventArgs e)
      {
         const int size = 64;
         var data = new byte[size];
         byte result;
         if (byte.TryParse(valueTextBox.Text, out result))
         {
            data[1] = result;
         }
         else
         {
            PrintOutputLine("Invalid value, expecting byte value");
            return;
         }

         var report = new HidReport(64, new HidDeviceData(data, HidDeviceData.ReadStatus.Success));
         var status = _device.WriteReport(report);
         return;
      }
   }
}
