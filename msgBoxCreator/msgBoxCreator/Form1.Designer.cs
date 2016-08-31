namespace msgBoxCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Asterisk = new System.Windows.Forms.RadioButton();
            this.Warning = new System.Windows.Forms.RadioButton();
            this.Stop = new System.Windows.Forms.RadioButton();
            this.Hand = new System.Windows.Forms.RadioButton();
            this.Exc = new System.Windows.Forms.RadioButton();
            this.Info = new System.Windows.Forms.RadioButton();
            this.Question = new System.Windows.Forms.RadioButton();
            this.Error = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AbortRI = new System.Windows.Forms.RadioButton();
            this.YesNC = new System.Windows.Forms.RadioButton();
            this.YesNo = new System.Windows.Forms.RadioButton();
            this.RetryCancel = new System.Windows.Forms.RadioButton();
            this.OKCancel = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 40);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Asterisk);
            this.groupBox1.Controls.Add(this.Warning);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.Hand);
            this.groupBox1.Controls.Add(this.Exc);
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.Question);
            this.groupBox1.Controls.Add(this.Error);
            this.groupBox1.Location = new System.Drawing.Point(10, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon:";
            // 
            // Asterisk
            // 
            this.Asterisk.AutoSize = true;
            this.Asterisk.Location = new System.Drawing.Point(223, 45);
            this.Asterisk.Name = "Asterisk";
            this.Asterisk.Size = new System.Drawing.Size(62, 17);
            this.Asterisk.TabIndex = 7;
            this.Asterisk.Text = "Asterisk";
            this.Asterisk.UseVisualStyleBackColor = true;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(223, 20);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(65, 17);
            this.Warning.TabIndex = 6;
            this.Warning.Text = "Warning";
            this.Warning.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(165, 44);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(47, 17);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Hand
            // 
            this.Hand.AutoSize = true;
            this.Hand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Hand.Location = new System.Drawing.Point(165, 20);
            this.Hand.Name = "Hand";
            this.Hand.Size = new System.Drawing.Size(51, 17);
            this.Hand.TabIndex = 4;
            this.Hand.Text = "Hand";
            this.Hand.UseVisualStyleBackColor = true;
            // 
            // Exc
            // 
            this.Exc.AutoSize = true;
            this.Exc.Location = new System.Drawing.Point(81, 45);
            this.Exc.Name = "Exc";
            this.Exc.Size = new System.Drawing.Size(82, 17);
            this.Exc.TabIndex = 3;
            this.Exc.Text = "Exclamation";
            this.Exc.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(81, 20);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(77, 17);
            this.Info.TabIndex = 2;
            this.Info.Text = "Information";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(7, 44);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(67, 17);
            this.Question.TabIndex = 1;
            this.Question.Text = "Question";
            this.Question.UseVisualStyleBackColor = true;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(7, 20);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(47, 17);
            this.Error.TabIndex = 0;
            this.Error.Text = "Error";
            this.Error.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AbortRI);
            this.groupBox2.Controls.Add(this.YesNC);
            this.groupBox2.Controls.Add(this.YesNo);
            this.groupBox2.Controls.Add(this.RetryCancel);
            this.groupBox2.Controls.Add(this.OKCancel);
            this.groupBox2.Controls.Add(this.OK);
            this.groupBox2.Location = new System.Drawing.Point(10, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons:";
            // 
            // AbortRI
            // 
            this.AbortRI.AutoSize = true;
            this.AbortRI.Location = new System.Drawing.Point(184, 44);
            this.AbortRI.Name = "AbortRI";
            this.AbortRI.Size = new System.Drawing.Size(105, 17);
            this.AbortRI.TabIndex = 5;
            this.AbortRI.Text = "AbortRetryIgnore";
            this.AbortRI.UseVisualStyleBackColor = true;
            // 
            // YesNC
            // 
            this.YesNC.AutoSize = true;
            this.YesNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YesNC.Location = new System.Drawing.Point(184, 21);
            this.YesNC.Name = "YesNC";
            this.YesNC.Size = new System.Drawing.Size(90, 17);
            this.YesNC.TabIndex = 4;
            this.YesNC.Text = "YesNoCancel";
            this.YesNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YesNC.UseVisualStyleBackColor = true;
            // 
            // YesNo
            // 
            this.YesNo.AutoSize = true;
            this.YesNo.Location = new System.Drawing.Point(101, 44);
            this.YesNo.Name = "YesNo";
            this.YesNo.Size = new System.Drawing.Size(57, 17);
            this.YesNo.TabIndex = 3;
            this.YesNo.Text = "YesNo";
            this.YesNo.UseVisualStyleBackColor = true;
            // 
            // RetryCancel
            // 
            this.RetryCancel.AutoSize = true;
            this.RetryCancel.Location = new System.Drawing.Point(101, 21);
            this.RetryCancel.Name = "RetryCancel";
            this.RetryCancel.Size = new System.Drawing.Size(83, 17);
            this.RetryCancel.TabIndex = 2;
            this.RetryCancel.Text = "RetryCancel";
            this.RetryCancel.UseVisualStyleBackColor = true;
            // 
            // OKCancel
            // 
            this.OKCancel.AutoSize = true;
            this.OKCancel.Location = new System.Drawing.Point(7, 44);
            this.OKCancel.Name = "OKCancel";
            this.OKCancel.Size = new System.Drawing.Size(73, 17);
            this.OKCancel.TabIndex = 1;
            this.OKCancel.Text = "OKCancel";
            this.OKCancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Location = new System.Drawing.Point(7, 20);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(40, 17);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Build!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CloseDelay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "MiliSeconds 1000 = 1sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Creator - By MrMutt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Exc;
        private System.Windows.Forms.RadioButton Info;
        private System.Windows.Forms.RadioButton Question;
        private System.Windows.Forms.RadioButton Error;
        private System.Windows.Forms.RadioButton Hand;
        private System.Windows.Forms.RadioButton Stop;
        private System.Windows.Forms.RadioButton Asterisk;
        private System.Windows.Forms.RadioButton Warning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AbortRI;
        private System.Windows.Forms.RadioButton YesNC;
        private System.Windows.Forms.RadioButton YesNo;
        private System.Windows.Forms.RadioButton RetryCancel;
        private System.Windows.Forms.RadioButton OKCancel;
        private System.Windows.Forms.RadioButton OK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

