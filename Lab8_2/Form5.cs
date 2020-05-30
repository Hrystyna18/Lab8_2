using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    public partial class Form5 : Form
    {
        List<Flight> A = new List<Flight>();
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            int n = Convert.ToInt32(textBox6.Text);
            Flight A1 = new Flight();
            string from = textBox1.Text;
            A1.From = from;
            string incity = textBox2.Text;
            A1.Incity = incity;
            string airport = textBox3.Text;
            A1.Airport = airport;
            int price = Convert.ToInt32(textBox4.Text);
            A1.Price = price;
            int number = Convert.ToInt32(textBox5.Text);
            A1.Number = number;
            A.RemoveAt(n - 1);
            A.Insert(n - 1, A1);
            Flight.FileInformationRewrite("flight.txt", A);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
