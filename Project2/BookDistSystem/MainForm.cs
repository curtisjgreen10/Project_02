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
        List<TextBox> sender_IDs = new List<TextBox>();
        List<TextBox> sender_Status = new List<TextBox>();
        List<TextBox> rcvr_IDs = new List<TextBox>();
        List<TextBox> rcvr_Status = new List<TextBox>();
        delegate void SenderIdDelegate(int ID, int num);
        delegate void ReceiverIdDelegate(int ID, int num);
        delegate void SenderStatusDelegate(string status, int num);
        delegate void ReceiverStatusDelegate(int status, int num);
        delegate void PriceDelegate(double price);
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
        Thread bufferThread;
        
        public MainForm()
        {
            InitializeComponent();
            //create buffer, publishers, and bookstores on start up
            buff = new MultiCellBuffer(3);
            bufferThread = new Thread(() => buff.RunBuffer());
            bufferThread.Start();
            //start all publisher and bookstore threads
            publishThread1 = new Thread(() => publisher1.RunPublisher());
            publishThread1.Start();
            publishThread2 = new Thread(() => publisher2.RunPublisher());
            publishThread2.Start();
            txt_senderId1_status.Text = "Runninng";
            txt_senderId2_status.Text = "Runninng";
            txt_recvrId1_status.Text = "Idle";
            txt_recvrId2_status.Text = "Idle";
            txt_recvrId3_status.Text = "Idle";
            txt_recvrId4_status.Text = "Idle";
            txt_recvrId5_status.Text = "Idle";
            rcvr_IDs.Add(txt_recvrId1);
            rcvr_IDs.Add(txt_recvrId2);
            rcvr_IDs.Add(txt_recvrId3);
            rcvr_IDs.Add(txt_recvrId4);
            rcvr_IDs.Add(txt_recvrId5);
            rcvr_Status.Add(txt_recvrId1_status);
            rcvr_Status.Add(txt_recvrId2_status);
            rcvr_Status.Add(txt_recvrId3_status);
            rcvr_Status.Add(txt_recvrId4_status);
            rcvr_Status.Add(txt_recvrId5_status);
            sender_IDs.Add(txt_senderId1);
            sender_IDs.Add(txt_senderId2);
            sender_Status.Add(txt_senderId1_status);
            sender_Status.Add(txt_senderId2_status);
            Publisher.priceCut += new priceCutEvent(BookStore.Publisher_priceCut);
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            MultiCellBuffer.Order.setAmount(Convert.ToInt32(txt_amountBks.Text));
            MultiCellBuffer.Order.setCardNo(Convert.ToInt32(txt_cardNo.Text));
            MultiCellBuffer.OrderRecieved = true;
        }

        public void setRcvrIDtxt(int ID, int num)
        {
            if (rcvr_IDs[num].InvokeRequired)
            {
                SenderIdDelegate d = new SenderIdDelegate(setRcvrIDtxt);
                Invoke(d, new object[] { ID, num });
            }
            else
            {
                rcvr_IDs[num].Text = ID.ToString();
            }
        }

        public void setSendIDtxt(int ID, int num)
        {
            if (sender_IDs[num].InvokeRequired)
            {
                SenderIdDelegate d = new SenderIdDelegate(setSendIDtxt);
                Invoke(d, new object[] { ID, num });
            }
            else
            {
                sender_IDs[num].Text = ID.ToString();
            }
        }

        public void setRcvrStatustxt(string status, int num)
        {
            if (rcvr_Status[num].InvokeRequired)
            {
                SenderStatusDelegate d = new SenderStatusDelegate(setRcvrStatustxt);
                Invoke(d, new object[] { status , num});
            }
            else
            {
                rcvr_Status[num].Text = status;
            }
        }

        public void setSendStatustxt(string status, int num)
        {
            if (sender_Status[num].InvokeRequired)
            {
                SenderStatusDelegate d = new SenderStatusDelegate(setSendStatustxt);
                Invoke(d, new object[] { status, num });
            }
            else
            {
                sender_Status[num].Text = status;
            }
        }

        public void setPrice(double price)
        {
            if (txt_senderId1.InvokeRequired)
            {
                PriceDelegate d = new PriceDelegate(setPrice);
                Invoke(d, new object[] { price });
            }
            else
            {
                txt_bookPrice.Text = price.ToString();
            }
        }
    }
}
