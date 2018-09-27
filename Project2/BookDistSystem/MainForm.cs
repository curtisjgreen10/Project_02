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
        List<TextBox> order_process = new List<TextBox>();
        List<TextBox> encode = new List<TextBox>();
        //delegates used to update the GUI controls
        delegate void SenderIdDelegate(int ID, int num);
        delegate void ReceiverIdDelegate(int ID, int num);
        delegate void SenderStatusDelegate(string status, int num);
        delegate void ReceiverStatusDelegate(int status, int num);
        delegate void PriceDelegate(double price);
        delegate void PriceCutDelegate(int price);
        delegate void NumOrdersDelegate(int orders);
        delegate void OrderProcessingDelegate(string status, int num);
        delegate void EncodeOrderDelegate(string status, int num);
        static MultiCellBuffer buff;
        Thread bufferThread;
        
        public MainForm()
        {
            InitializeComponent();
            //create buffer, publishers, and bookstores on start up
            buff = new MultiCellBuffer(3);
            bufferThread = new Thread(() => buff.RunBuffer());
            bufferThread.IsBackground = true;
            bufferThread.Start();
            //everything is idle to start
            txt_price_cuts.Text = "0";
            txt_orders_processed.Text = "0";
            txt_senderId1_status.Text = "Idle";
            txt_senderId2_status.Text = "Idle";
            txt_recvrId1_status.Text = "Idle";
            txt_recvrId2_status.Text = "Idle";
            txt_recvrId3_status.Text = "Idle";
            txt_recvrId4_status.Text = "Idle";
            txt_recvrId5_status.Text = "Idle";
            //create arrays of text boxes on GUI for easier access
            order_process.Add(txt_orderProcessing1);
            order_process.Add(txt_orderProcessing2);
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
            encode.Add(txt_encoding1);
            encode.Add(txt_encoding2);
            encode.Add(txt_encoding3);
            encode.Add(txt_encoding4);
            encode.Add(txt_encoding5);
            //subsrcibe to events
            Publisher.priceCut += new priceCutEvent(BookStore.Publisher_priceCut);
            OrderProcessing.orderProcessed += new orderProcessedEvent(BookStore.Process_orderProcessed);
        }

        /// <summary>
        /// Button event handler to start publisher threads 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_order_Click(object sender, EventArgs e)
        {
            if(MultiCellBuffer.publisherThreadCnt < 2)
            {
                //start a publisher thread
                Thread publishThread = new Thread(() => Publisher.RunPublisher());
                publishThread.IsBackground = true;
                publishThread.Start();
            }
            MultiCellBuffer.Order.setAmount(Convert.ToInt32(txt_amountBks.Text));
            MultiCellBuffer.Order.setCardNo(Convert.ToInt32(txt_cardNo.Text));
            MultiCellBuffer.OrderRecieved = true;
        }

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="num"></param>
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

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="num"></param>
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

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="status"></param>
        /// <param name="num"></param>
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

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="status"></param>
        /// <param name="num"></param>
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

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="price"></param>
        public void setPrice(double price)
        {
            if (txt_bookPrice.InvokeRequired)
            {
                PriceDelegate d = new PriceDelegate(setPrice);
                Invoke(d, new object[] { price });
            }
            else
            {
                txt_bookPrice.Text = price.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        public void setNumOrders(int orders)
        {
            if (txt_orders_processed.InvokeRequired)
            {
                NumOrdersDelegate d = new NumOrdersDelegate(setNumOrders);
                Invoke(d, new object[] { orders });
            }
            else
            {
                txt_orders_processed.Text = orders.ToString();
            }
        }

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="priceCuts"></param>
        public void setPriceCuts(int priceCuts)
        {
            if ( txt_price_cuts.InvokeRequired)
            {
                PriceCutDelegate d = new PriceCutDelegate(setPriceCuts);
                Invoke(d, new object[] { priceCuts });
            }
            else
            {
                txt_price_cuts.Text = priceCuts.ToString();
            }
        }

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="status"></param>
        /// <param name="num"></param>
        public void setOrderProcessing(string status, int publisherNum)
        {
            if (order_process[publisherNum].InvokeRequired)
            {
                OrderProcessingDelegate d = new OrderProcessingDelegate(setOrderProcessing);
                Invoke(d, new object[] { status, publisherNum });
            }
            else
            {
                order_process[publisherNum].Text = status;
            }
        }

        /// <summary>
        /// Thread safe method to set controls on GUI thread from other threads
        /// </summary>
        /// <param name="status"></param>
        /// <param name="num"></param>
        public void encodeOrder(string status, int num)
        {
            if (encode[num].InvokeRequired)
            {
                EncodeOrderDelegate d = new EncodeOrderDelegate(encodeOrder);
                Invoke(d, new object[] { status, num });
            }
            else
            {
                encode[num].Text = status;
            }
        }

        /// <summary>
        /// form close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //all threads will die upon closing because they all set as background threads
            Environment.Exit(Environment.ExitCode);
        }
    }
}
