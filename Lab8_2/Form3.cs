using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    public partial class Form3 : Form
    {
        List<Flight> A = new List<Flight>();
        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(openFileDialog1.FileName);
            using (StreamReader s = new StreamReader("flight.txt"))
            {
                string str;
                string[] a;
                while (s.EndOfStream == false)
                {
                    str = s.ReadLine();
                    if (str != "" && str != " ")
                            {
                        a = str.Split();
                        A.Add(new Flight(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                    }
                }
            }
            string line;
            for ( int i = 1; i < richTextBox1.Lines.Length; i++)
            {
                line = richTextBox1.Lines[i].ToString();
                sw.WriteLine(line);
            }

            for (int i = 0; i < richTextBox1.Lines.Length; i += 5)
            {
                A.Add(new Flight() { From = richTextBox1.Lines[i].ToString(), Incity = richTextBox1.Lines[i + 1].ToString(), Airport = richTextBox1.Lines[i + 2].ToString(), Price = int.Parse(richTextBox1.Lines[i + 3]), Number = int.Parse(richTextBox1.Lines[i + 4]) });
                Flight.FileInformationRewrite("flight.txt", A);
            }
            sw.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
