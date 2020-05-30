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
    public partial class Form1 : Form
    {
        Form2 a;
        Form3 b;
        Form4 c;
        Form5 d;
        List<Flight> A = new List<Flight>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            b = new Form3();
            b.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            c = new Form4();
            c.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            d = new Form5();
            d.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
        }
    }

    class Flight
    {
        public string From;
        public string Incity;
        public string Airport;
        public int Price;
        public int Number;

        public Flight() { }
        public Flight(string from, string incity, string airport, int price, int number)
        {
            From = from;
            Incity = incity;
            Airport = airport;
            Price = price;
            Number = number;
        }

        public override string ToString()
        {
            return this.From + " " + this.Incity + " " + this.Airport + " " + this.Price + " " + this.Number;
        }
        static public void FileInformationRewrite(string path, List<Flight> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter s = new StreamWriter(path))
            {
                foreach (Flight informationUnit in users)
                {
                    s.WriteLine(informationUnit.ToString());
                }
            }
        }

    }
}
