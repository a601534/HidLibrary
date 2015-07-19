namespace TweenyWindowsForm
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.refreshButton = new System.Windows.Forms.Button();
         this.sendButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.valueTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // outputTextBox
         // 
         this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.outputTextBox.Location = new System.Drawing.Point(0, 73);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size(581, 361);
         this.outputTextBox.TabIndex = 0;
         // 
         // refreshButton
         // 
         this.refreshButton.Location = new System.Drawing.Point(109, 44);
         this.refreshButton.Name = "refreshButton";
         this.refreshButton.Size = new System.Drawing.Size(100, 23);
         this.refreshButton.TabIndex = 1;
         this.refreshButton.Text = "Scan for device";
         this.refreshButton.UseVisualStyleBackColor = true;
         this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
         // 
         // sendButton
         // 
         this.sendButton.Location = new System.Drawing.Point(15, 44);
         this.sendButton.Name = "sendButton";
         this.sendButton.Size = new System.Drawing.Size(75, 23);
         this.sendButton.TabIndex = 2;
         this.sendButton.Text = "Send value";
         this.sendButton.UseVisualStyleBackColor = true;
         this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(75, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Value to send:";
         // 
         // valueTextBox
         // 
         this.valueTextBox.Location = new System.Drawing.Point(109, 9);
         this.valueTextBox.Name = "valueTextBox";
         this.valueTextBox.Size = new System.Drawing.Size(100, 20);
         this.valueTextBox.TabIndex = 4;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(582, 433);
         this.Controls.Add(this.valueTextBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.sendButton);
         this.Controls.Add(this.refreshButton);
         this.Controls.Add(this.outputTextBox);
         this.Name = "Form1";
         this.Text = "Raw HID Sample";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.Button refreshButton;
      private System.Windows.Forms.Button sendButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox valueTextBox;
   }
}

