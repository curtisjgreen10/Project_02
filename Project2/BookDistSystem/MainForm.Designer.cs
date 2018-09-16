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
            this.txt_amountBks = new System.Windows.Forms.TextBox();
            this.txt_bookPrice = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_recvrId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_senderId1 = new System.Windows.Forms.TextBox();
            this.txt_senderId2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txt_senderId2_status = new System.Windows.Forms.TextBox();
            this.txt_senderId1_status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Location = new System.Drawing.Point(104, 319);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.Size = new System.Drawing.Size(138, 20);
            this.txt_cardNo.TabIndex = 1;
            // 
            // txt_amountBks
            // 
            this.txt_amountBks.Location = new System.Drawing.Point(104, 357);
            this.txt_amountBks.Name = "txt_amountBks";
            this.txt_amountBks.Size = new System.Drawing.Size(138, 20);
            this.txt_amountBks.TabIndex = 3;
            // 
            // txt_bookPrice
            // 
            this.txt_bookPrice.Location = new System.Drawing.Point(612, 386);
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.Size = new System.Drawing.Size(138, 20);
            this.txt_bookPrice.TabIndex = 4;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(126, 402);
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
            this.label2.Location = new System.Drawing.Point(23, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recvr ID ( thread number of bookstore )";
            // 
            // txt_recvrId
            // 
            this.txt_recvrId.Location = new System.Drawing.Point(292, 156);
            this.txt_recvrId.Name = "txt_recvrId";
            this.txt_recvrId.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sender ID ( thread number of publisher)";
            // 
            // txt_senderId1
            // 
            this.txt_senderId1.Location = new System.Drawing.Point(292, 42);
            this.txt_senderId1.Name = "txt_senderId1";
            this.txt_senderId1.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId1.TabIndex = 0;
            // 
            // txt_senderId2
            // 
            this.txt_senderId2.Location = new System.Drawing.Point(292, 82);
            this.txt_senderId2.Name = "txt_senderId2";
            this.txt_senderId2.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 304);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(469, 304);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(138, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(469, 268);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(138, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(469, 230);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(138, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(469, 193);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(138, 20);
            this.textBox9.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(469, 156);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(138, 20);
            this.textBox10.TabIndex = 16;
            // 
            // txt_senderId2_status
            // 
            this.txt_senderId2_status.Location = new System.Drawing.Point(469, 82);
            this.txt_senderId2_status.Name = "txt_senderId2_status";
            this.txt_senderId2_status.ReadOnly = true;
            this.txt_senderId2_status.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId2_status.TabIndex = 22;
            // 
            // txt_senderId1_status
            // 
            this.txt_senderId1_status.Location = new System.Drawing.Point(469, 42);
            this.txt_senderId1_status.Name = "txt_senderId1_status";
            this.txt_senderId1_status.ReadOnly = true;
            this.txt_senderId1_status.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId1_status.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_senderId2_status);
            this.Controls.Add(this.txt_senderId1_status);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_senderId2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.txt_bookPrice);
            this.Controls.Add(this.txt_amountBks);
            this.Controls.Add(this.txt_recvrId);
            this.Controls.Add(this.txt_cardNo);
            this.Controls.Add(this.txt_senderId1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cardNo;
        private System.Windows.Forms.TextBox txt_amountBks;
        private System.Windows.Forms.TextBox txt_bookPrice;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_recvrId;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senderId1;
        private System.Windows.Forms.TextBox txt_senderId2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txt_senderId2_status;
        private System.Windows.Forms.TextBox txt_senderId1_status;
    }
}

