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
        BaseAlgorithm<int> algorithmBubble = new BubbleSort<int>();
        BaseAlgorithm<int> algorithmCoctail = new CoctailSort<int>();
        public int ItemsCount { get; set; } = 10000;

        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            
            var tempCollection = new List<int>();

            for (int i = 0; i < ItemsCount; i++)
            {
                tempCollection.Add(rnd.Next(0,100));
            }
            algorithmBubble.Items.AddRange(tempCollection);
            algorithmCoctail.Items.AddRange(tempCollection);
            if (ItemsCount < 50)
            {
                foreach (var item in algorithmBubble.Items)
                {
                    label1.Text += " " + item;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            algorithmBubble.Sort();
            sw.Stop();
            if (ItemsCount < 50)
            {
                foreach (var item in algorithmBubble.Items)
                {
                    label2.Text += " " + item;
                }
            }

            label3.Text += "Время выполнения кода сортировки пузырьком: " + Convert.ToString(sw.ElapsedMilliseconds) + " мс.";
            sw.Reset();
            sw.Start();
            algorithmCoctail.Sort();
            sw.Stop();
            label4.Text += "Время выполнения кода сортфировки шейкерной: " + Convert.ToString(sw.ElapsedMilliseconds) +
                           " мс.";
            sw.Reset();
        }
    }
}
