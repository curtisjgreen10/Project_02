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
        static BookStore BookStore1 = new BookStore();
        static BookStore BookStore2 = new BookStore();
        static BookStore BookStore3 = new BookStore();
        static BookStore BookStore4 = new BookStore();
        static BookStore BookStore5 = new BookStore();
        Thread publishThread1;
        Thread publishThread2;
        Thread bookStoreThread1;
        Thread bookStoreThread2;
        Thread bookStoreThread3;
        Thread bookStoreThread4;
        Thread bookStoreThread5;

        public MainForm()
        {
            InitializeComponent();
            //create buffer, publishers, and bookstores on start up
            buff = new MultiCellBuffer(3);
            //start all publisher and bookstore threads
            publishThread1 = new Thread(() => publisher1.RunPublisher());
            publishThread1.Start();
            publishThread2 = new Thread(() => publisher2.RunPublisher());
            publishThread2.Start();
            bookStoreThread1 = new Thread(() => BookStore1.RunStore());
            bookStoreThread1.Start();
            bookStoreThread2 = new Thread(() => BookStore2.RunStore());
            bookStoreThread2.Start();
            bookStoreThread3 = new Thread(() => BookStore3.RunStore());
            bookStoreThread3.Start();
            bookStoreThread4 = new Thread(() => BookStore4.RunStore());
            bookStoreThread4.Start();
            bookStoreThread5 = new Thread(() => BookStore5.RunStore());
            bookStoreThread5.Start();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            MultiCellBuffer.Order.setAmount(Convert.ToInt32(txt_amountBks.Text));
            MultiCellBuffer.Order.setCardNo(Convert.ToInt32(txt_cardNo.Text));
            /*Cross threaded exceptions here, need to resolve
            Task.Factory.StartNew(() => 
            {
                while (!MultiCellBuffer.NewSender) ;
                txt_senderId.Text = MultiCellBuffer.Order.getSenderId().ToString();
            });
            */
            
            MultiCellBuffer.OrderRecieved = true;
        }

        public void setSendIDtxt(int ID)
        {
            txt_senderId.Text = Convert.ToInt32(ID).ToString();
        }

        public void setRcvrIDtxt(int ID)
        {
            txt_recvrId.Text = Convert.ToInt32(ID).ToString();
        }
    }
}
