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
         this.SuspendLayout();
         // 
         // outputTextBox
         // 
         this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.outputTextBox.Location = new System.Drawing.Point(0, 145);
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size(581, 259);
         this.outputTextBox.TabIndex = 0;
         // 
         // refreshButton
         // 
         this.refreshButton.Location = new System.Drawing.Point(12, 30);
         this.refreshButton.Name = "refreshButton";
         this.refreshButton.Size = new System.Drawing.Size(75, 23);
         this.refreshButton.TabIndex = 1;
         this.refreshButton.Text = "Refresh";
         this.refreshButton.UseVisualStyleBackColor = true;
         this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(582, 433);
         this.Controls.Add(this.refreshButton);
         this.Controls.Add(this.outputTextBox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox outputTextBox;
      private System.Windows.Forms.Button refreshButton;
   }
}

