using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortAlgo.Sortings;


namespace Visualization
{
    public partial class Form1 : Form
    {
        BaseAlgorithm<int> algorithm = new BubbleSort<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                algorithm.Items.Add(rnd.Next(0,100));
            }

            foreach (var item in algorithm.Items)
            {
                label1.Text += " " + item;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            algorithm.Sort();
            sw.Stop();
            foreach (var item in algorithm.Items)
            {
                label2.Text += " " + item;
            }

            label3.Text = "";
            label3.Text +=  "Время выполнения кода: "+ Convert.ToString(sw.ElapsedMilliseconds) + " мс.";
        }
    }
}
