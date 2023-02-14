namespace SerialLibrary
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ReceiveBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.RateBox = new System.Windows.Forms.ComboBox();
            this.DatabitBox = new System.Windows.Forms.ComboBox();
            this.ParitybitBox = new System.Windows.Forms.ComboBox();
            this.StopbitBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "연결";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "해제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(364, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(364, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(364, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bit";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(364, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parity Bit";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(364, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bit";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 181);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 247);
            this.textBox2.TabIndex = 5;
            // 
            // ReceiveBox
            // 
            this.ReceiveBox.Location = new System.Drawing.Point(274, 181);
            this.ReceiveBox.Multiline = true;
            this.ReceiveBox.Name = "ReceiveBox";
            this.ReceiveBox.Size = new System.Drawing.Size(234, 247);
            this.ReceiveBox.TabIndex = 5;
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(441, 31);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(67, 20);
            this.PortBox.TabIndex = 6;
            // 
            // RateBox
            // 
            this.RateBox.FormattingEnabled = true;
            this.RateBox.Location = new System.Drawing.Point(441, 55);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(67, 20);
            this.RateBox.TabIndex = 6;
            // 
            // DatabitBox
            // 
            this.DatabitBox.FormattingEnabled = true;
            this.DatabitBox.Location = new System.Drawing.Point(441, 78);
            this.DatabitBox.Name = "DatabitBox";
            this.DatabitBox.Size = new System.Drawing.Size(67, 20);
            this.DatabitBox.TabIndex = 6;
            // 
            // ParitybitBox
            // 
            this.ParitybitBox.FormattingEnabled = true;
            this.ParitybitBox.Location = new System.Drawing.Point(441, 101);
            this.ParitybitBox.Name = "ParitybitBox";
            this.ParitybitBox.Size = new System.Drawing.Size(67, 20);
            this.ParitybitBox.TabIndex = 6;
            // 
            // StopbitBox
            // 
            this.StopbitBox.FormattingEnabled = true;
            this.StopbitBox.Location = new System.Drawing.Point(441, 124);
            this.StopbitBox.Name = "StopbitBox";
            this.StopbitBox.Size = new System.Drawing.Size(67, 20);
            this.StopbitBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.StopbitBox);
            this.Controls.Add(this.ParitybitBox);
            this.Controls.Add(this.DatabitBox);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.ReceiveBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.ComboBox RateBox;
        private System.Windows.Forms.ComboBox DatabitBox;
        private System.Windows.Forms.ComboBox ParitybitBox;
        private System.Windows.Forms.ComboBox StopbitBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox ReceiveBox;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}