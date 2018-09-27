namespace BookDistSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_cardNo = new System.Windows.Forms.TextBox();
            this.txt_bookPrice = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_recvrId1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_senderId1 = new System.Windows.Forms.TextBox();
            this.txt_senderId2 = new System.Windows.Forms.TextBox();
            this.txt_recvrId2 = new System.Windows.Forms.TextBox();
            this.txt_recvrId3 = new System.Windows.Forms.TextBox();
            this.txt_recvrId4 = new System.Windows.Forms.TextBox();
            this.txt_recvrId5 = new System.Windows.Forms.TextBox();
            this.txt_recvrId5_status = new System.Windows.Forms.TextBox();
            this.txt_recvrId4_status = new System.Windows.Forms.TextBox();
            this.txt_recvrId3_status = new System.Windows.Forms.TextBox();
            this.txt_recvrId2_status = new System.Windows.Forms.TextBox();
            this.txt_recvrId1_status = new System.Windows.Forms.TextBox();
            this.txt_senderId2_status = new System.Windows.Forms.TextBox();
            this.txt_senderId1_status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_amountBks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price_cuts = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_orders_processed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_orderProcessing1 = new System.Windows.Forms.TextBox();
            this.txt_orderProcessing2 = new System.Windows.Forms.TextBox();
            this.txt_encoding1 = new System.Windows.Forms.TextBox();
            this.txt_encoding2 = new System.Windows.Forms.TextBox();
            this.txt_encoding3 = new System.Windows.Forms.TextBox();
            this.txt_encoding4 = new System.Windows.Forms.TextBox();
            this.txt_encoding5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Location = new System.Drawing.Point(82, 446);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.Size = new System.Drawing.Size(138, 20);
            this.txt_cardNo.TabIndex = 1;
            // 
            // txt_bookPrice
            // 
            this.txt_bookPrice.Location = new System.Drawing.Point(523, 437);
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.ReadOnly = true;
            this.txt_bookPrice.Size = new System.Drawing.Size(138, 20);
            this.txt_bookPrice.TabIndex = 4;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(256, 443);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 5;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recvr ID ( thread number of bookstore )";
            // 
            // txt_recvrId1
            // 
            this.txt_recvrId1.Location = new System.Drawing.Point(443, 218);
            this.txt_recvrId1.Name = "txt_recvrId1";
            this.txt_recvrId1.ReadOnly = true;
            this.txt_recvrId1.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sender ID ( thread number of publisher)";
            // 
            // txt_senderId1
            // 
            this.txt_senderId1.Location = new System.Drawing.Point(443, 104);
            this.txt_senderId1.Name = "txt_senderId1";
            this.txt_senderId1.ReadOnly = true;
            this.txt_senderId1.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId1.TabIndex = 0;
            // 
            // txt_senderId2
            // 
            this.txt_senderId2.Location = new System.Drawing.Point(443, 144);
            this.txt_senderId2.Name = "txt_senderId2";
            this.txt_senderId2.ReadOnly = true;
            this.txt_senderId2.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId2.TabIndex = 11;
            // 
            // txt_recvrId2
            // 
            this.txt_recvrId2.Location = new System.Drawing.Point(443, 255);
            this.txt_recvrId2.Name = "txt_recvrId2";
            this.txt_recvrId2.ReadOnly = true;
            this.txt_recvrId2.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId2.TabIndex = 12;
            // 
            // txt_recvrId3
            // 
            this.txt_recvrId3.Location = new System.Drawing.Point(443, 292);
            this.txt_recvrId3.Name = "txt_recvrId3";
            this.txt_recvrId3.ReadOnly = true;
            this.txt_recvrId3.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId3.TabIndex = 13;
            // 
            // txt_recvrId4
            // 
            this.txt_recvrId4.Location = new System.Drawing.Point(443, 330);
            this.txt_recvrId4.Name = "txt_recvrId4";
            this.txt_recvrId4.ReadOnly = true;
            this.txt_recvrId4.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId4.TabIndex = 14;
            // 
            // txt_recvrId5
            // 
            this.txt_recvrId5.Location = new System.Drawing.Point(443, 366);
            this.txt_recvrId5.Name = "txt_recvrId5";
            this.txt_recvrId5.ReadOnly = true;
            this.txt_recvrId5.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId5.TabIndex = 15;
            // 
            // txt_recvrId5_status
            // 
            this.txt_recvrId5_status.Location = new System.Drawing.Point(620, 366);
            this.txt_recvrId5_status.Name = "txt_recvrId5_status";
            this.txt_recvrId5_status.ReadOnly = true;
            this.txt_recvrId5_status.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId5_status.TabIndex = 20;
            // 
            // txt_recvrId4_status
            // 
            this.txt_recvrId4_status.Location = new System.Drawing.Point(620, 330);
            this.txt_recvrId4_status.Name = "txt_recvrId4_status";
            this.txt_recvrId4_status.ReadOnly = true;
            this.txt_recvrId4_status.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId4_status.TabIndex = 19;
            // 
            // txt_recvrId3_status
            // 
            this.txt_recvrId3_status.Location = new System.Drawing.Point(620, 292);
            this.txt_recvrId3_status.Name = "txt_recvrId3_status";
            this.txt_recvrId3_status.ReadOnly = true;
            this.txt_recvrId3_status.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId3_status.TabIndex = 18;
            // 
            // txt_recvrId2_status
            // 
            this.txt_recvrId2_status.Location = new System.Drawing.Point(620, 255);
            this.txt_recvrId2_status.Name = "txt_recvrId2_status";
            this.txt_recvrId2_status.ReadOnly = true;
            this.txt_recvrId2_status.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId2_status.TabIndex = 17;
            // 
            // txt_recvrId1_status
            // 
            this.txt_recvrId1_status.Location = new System.Drawing.Point(620, 218);
            this.txt_recvrId1_status.Name = "txt_recvrId1_status";
            this.txt_recvrId1_status.ReadOnly = true;
            this.txt_recvrId1_status.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId1_status.TabIndex = 16;
            // 
            // txt_senderId2_status
            // 
            this.txt_senderId2_status.Location = new System.Drawing.Point(620, 144);
            this.txt_senderId2_status.Name = "txt_senderId2_status";
            this.txt_senderId2_status.ReadOnly = true;
            this.txt_senderId2_status.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId2_status.TabIndex = 22;
            // 
            // txt_senderId1_status
            // 
            this.txt_senderId1_status.Location = new System.Drawing.Point(620, 104);
            this.txt_senderId1_status.Name = "txt_senderId1_status";
            this.txt_senderId1_status.ReadOnly = true;
            this.txt_senderId1_status.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId1_status.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Publisher 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Publisher 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Bookstore 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bookstore 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bookstore 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Bookstore 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Bookstore 5";
            // 
            // txt_amountBks
            // 
            this.txt_amountBks.Location = new System.Drawing.Point(82, 407);
            this.txt_amountBks.Name = "txt_amountBks";
            this.txt_amountBks.Size = new System.Drawing.Size(138, 20);
            this.txt_amountBks.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Amount";
            // 
            // txt_price_cuts
            // 
            this.txt_price_cuts.Location = new System.Drawing.Point(443, 12);
            this.txt_price_cuts.Name = "txt_price_cuts";
            this.txt_price_cuts.ReadOnly = true;
            this.txt_price_cuts.Size = new System.Drawing.Size(138, 20);
            this.txt_price_cuts.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Price Cuts";
            // 
            // txt_orders_processed
            // 
            this.txt_orders_processed.Location = new System.Drawing.Point(443, 38);
            this.txt_orders_processed.Name = "txt_orders_processed";
            this.txt_orders_processed.ReadOnly = true;
            this.txt_orders_processed.Size = new System.Drawing.Size(138, 20);
            this.txt_orders_processed.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Total Orders Procesed";
            // 
            // txt_orderProcessing1
            // 
            this.txt_orderProcessing1.Location = new System.Drawing.Point(193, 103);
            this.txt_orderProcessing1.Name = "txt_orderProcessing1";
            this.txt_orderProcessing1.ReadOnly = true;
            this.txt_orderProcessing1.Size = new System.Drawing.Size(138, 20);
            this.txt_orderProcessing1.TabIndex = 36;
            // 
            // txt_orderProcessing2
            // 
            this.txt_orderProcessing2.Location = new System.Drawing.Point(193, 144);
            this.txt_orderProcessing2.Name = "txt_orderProcessing2";
            this.txt_orderProcessing2.ReadOnly = true;
            this.txt_orderProcessing2.Size = new System.Drawing.Size(138, 20);
            this.txt_orderProcessing2.TabIndex = 37;
            // 
            // txt_encoding1
            // 
            this.txt_encoding1.Location = new System.Drawing.Point(193, 218);
            this.txt_encoding1.Name = "txt_encoding1";
            this.txt_encoding1.ReadOnly = true;
            this.txt_encoding1.Size = new System.Drawing.Size(138, 20);
            this.txt_encoding1.TabIndex = 38;
            // 
            // txt_encoding2
            // 
            this.txt_encoding2.Location = new System.Drawing.Point(193, 255);
            this.txt_encoding2.Name = "txt_encoding2";
            this.txt_encoding2.ReadOnly = true;
            this.txt_encoding2.Size = new System.Drawing.Size(138, 20);
            this.txt_encoding2.TabIndex = 39;
            // 
            // txt_encoding3
            // 
            this.txt_encoding3.Location = new System.Drawing.Point(193, 292);
            this.txt_encoding3.Name = "txt_encoding3";
            this.txt_encoding3.ReadOnly = true;
            this.txt_encoding3.Size = new System.Drawing.Size(138, 20);
            this.txt_encoding3.TabIndex = 40;
            // 
            // txt_encoding4
            // 
            this.txt_encoding4.Location = new System.Drawing.Point(193, 330);
            this.txt_encoding4.Name = "txt_encoding4";
            this.txt_encoding4.ReadOnly = true;
            this.txt_encoding4.Size = new System.Drawing.Size(138, 20);
            this.txt_encoding4.TabIndex = 41;
            // 
            // txt_encoding5
            // 
            this.txt_encoding5.Location = new System.Drawing.Point(193, 366);
            this.txt_encoding5.Name = "txt_encoding5";
            this.txt_encoding5.ReadOnly = true;
            this.txt_encoding5.Size = new System.Drawing.Size(138, 20);
            this.txt_encoding5.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(102, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Order processing Thread spawned by publisher";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Bookstore that got the order";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_encoding5);
            this.Controls.Add(this.txt_encoding4);
            this.Controls.Add(this.txt_encoding3);
            this.Controls.Add(this.txt_encoding2);
            this.Controls.Add(this.txt_encoding1);
            this.Controls.Add(this.txt_orderProcessing2);
            this.Controls.Add(this.txt_orderProcessing1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_orders_processed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_price_cuts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_amountBks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_senderId2_status);
            this.Controls.Add(this.txt_senderId1_status);
            this.Controls.Add(this.txt_recvrId5_status);
            this.Controls.Add(this.txt_recvrId4_status);
            this.Controls.Add(this.txt_recvrId3_status);
            this.Controls.Add(this.txt_recvrId2_status);
            this.Controls.Add(this.txt_recvrId1_status);
            this.Controls.Add(this.txt_recvrId5);
            this.Controls.Add(this.txt_recvrId4);
            this.Controls.Add(this.txt_recvrId3);
            this.Controls.Add(this.txt_recvrId2);
            this.Controls.Add(this.txt_senderId2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.txt_bookPrice);
            this.Controls.Add(this.txt_recvrId1);
            this.Controls.Add(this.txt_cardNo);
            this.Controls.Add(this.txt_senderId1);
            this.Name = "MainForm";
            this.Text = "Book Distribution System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cardNo;
        private System.Windows.Forms.TextBox txt_bookPrice;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_recvrId1;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senderId1;
        private System.Windows.Forms.TextBox txt_senderId2;
        private System.Windows.Forms.TextBox txt_recvrId2;
        private System.Windows.Forms.TextBox txt_recvrId3;
        private System.Windows.Forms.TextBox txt_recvrId4;
        private System.Windows.Forms.TextBox txt_recvrId5;
        private System.Windows.Forms.TextBox txt_recvrId5_status;
        private System.Windows.Forms.TextBox txt_recvrId4_status;
        private System.Windows.Forms.TextBox txt_recvrId3_status;
        private System.Windows.Forms.TextBox txt_recvrId2_status;
        private System.Windows.Forms.TextBox txt_recvrId1_status;
        private System.Windows.Forms.TextBox txt_senderId2_status;
        private System.Windows.Forms.TextBox txt_senderId1_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_amountBks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_price_cuts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_orders_processed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_orderProcessing1;
        private System.Windows.Forms.TextBox txt_orderProcessing2;
        private System.Windows.Forms.TextBox txt_encoding1;
        private System.Windows.Forms.TextBox txt_encoding2;
        private System.Windows.Forms.TextBox txt_encoding3;
        private System.Windows.Forms.TextBox txt_encoding4;
        private System.Windows.Forms.TextBox txt_encoding5;
        protected internal System.Windows.Forms.Label label15;
        protected internal System.Windows.Forms.Label label16;
    }
}

