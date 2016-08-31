using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace msgBoxCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stub = Properties.Resources.stub;
            stub = stub.Replace("[msgtext]", textBox2.Text);
            stub = stub.Replace("[msgtitle]", textBox1.Text);
            if (Error.Checked)
                stub = stub.Replace("[msgicon]", "Error");
            if (Info.Checked)
                stub = stub.Replace("[msgicon]", "Information");
            if (Hand.Checked)
                stub = stub.Replace("[msgicon]", "Hand");
            if (Warning.Checked)
                stub = stub.Replace("[msgicon]", "Warning");
            if (Question.Checked)
                stub = stub.Replace("[msgicon]", "Question");
            if (Exc.Checked)
                stub = stub.Replace("[msgicon]", "Exclamation");
            if (Stop.Checked)
                stub = stub.Replace("[msgicon]", "Stop");
            if (Asterisk.Checked)
                stub = stub.Replace("[msgicon]", "Asterisk");
            if (OK.Checked)
                stub = stub.Replace("[msgbutton]", "OK");
            if (OKCancel.Checked)
                stub = stub.Replace("[msgbutton]", "OKCancel");
            if (RetryCancel.Checked)
                stub = stub.Replace("[msgbutton]", "RetryCancel");
            if (YesNC.Checked)
                stub = stub.Replace("[msgbutton]", "YesNoCancel");
            if (YesNo.Checked)
                stub = stub.Replace("[msgbutton]", "YesNo");
            if (AbortRI.Checked)
                stub = stub.Replace("[msgbutton]", "AbortRetryIgnore");
            stub = stub.Replace("[delay-replace]", textBox3.Text);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Executables|*.exe";
            if(save.ShowDialog() == DialogResult.OK)
            {
                bool done;
                done = Compilier.CompileFromSource(stub,save.FileName,null,null);
                if (done)
                    MessageBox.Show("WORKED!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}