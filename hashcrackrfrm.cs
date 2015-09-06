using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hashcrackr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string dictp = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.ShowDialog();
                dictp = opf.FileName;
                textBox2.Text = dictp;

            }
            catch (Exception)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.AppendText("Checking dictionary...\n")
                    ;
                textBox3.AppendText("Opening dictionary...\n");
                textBox3.AppendText("Cracking...\n");
                bool p = false;
                foreach (var sf in System.IO.File.ReadAllLines(dictp))
                {
                    string s = sf.Replace('\n', '\r');
                    
                    if (s.GetHashCode() == Convert.ToInt64(textBox1.Text))
                    {
                        textBox3.AppendText(s + " is the password for " + textBox1.Text + "\n");
                        p = true;
                    }
                    else
                    {
                        
                    }

                }
                if (!p)
                {
                    textBox3.AppendText("No match. Try another dictionary!\n");
                }
                
            }
            catch (Exception)
            {
                
            }
        }
    }
}
