using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BookDistSystem
{
    public partial class MainForm : Form
    {
        //buffer needs to be static, will hold the shared thread data 
        static MultiCellBuffer buff;
        //not sure if the publishers need to be static
        static Publisher publisher1 = new Publisher();
        static Publisher publisher2 = new Publisher();
        Thread publishThread1;
        Thread publishThread2;

        public MainForm()
        {
            InitializeComponent();
            //create buffer, publishers, and bookstores on start up
            buff = new MultiCellBuffer(3);
            publishThread1 = new Thread(() => publisher1.Start());
            publishThread1.Start();
            publishThread2 = new Thread(() => publisher2.Start());
            publishThread2.Start();
            //add five instances of bookstore here, I think?
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            MultiCellBuffer.OrderAmount = Convert.ToInt32(txt_amountBks.Text);
        }
    }
}
