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
            this.txt_senderId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Location = new System.Drawing.Point(270, 168);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.Size = new System.Drawing.Size(138, 20);
            this.txt_cardNo.TabIndex = 1;
            // 
            // txt_amountBks
            // 
            this.txt_amountBks.Location = new System.Drawing.Point(270, 206);
            this.txt_amountBks.Name = "txt_amountBks";
            this.txt_amountBks.Size = new System.Drawing.Size(138, 20);
            this.txt_amountBks.TabIndex = 3;
            // 
            // txt_bookPrice
            // 
            this.txt_bookPrice.Location = new System.Drawing.Point(270, 254);
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.Size = new System.Drawing.Size(138, 20);
            this.txt_bookPrice.TabIndex = 4;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(302, 312);
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
            this.label2.Location = new System.Drawing.Point(189, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recvr ID ( thread number of bookstore )";
            // 
            // txt_recvrId
            // 
            this.txt_recvrId.Location = new System.Drawing.Point(270, 104);
            this.txt_recvrId.Name = "txt_recvrId";
            this.txt_recvrId.Size = new System.Drawing.Size(138, 20);
            this.txt_recvrId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sender ID ( thread number of publisher)";
            // 
            // txt_senderId
            // 
            this.txt_senderId.Location = new System.Drawing.Point(270, 78);
            this.txt_senderId.Name = "txt_senderId";
            this.txt_senderId.Size = new System.Drawing.Size(138, 20);
            this.txt_senderId.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.txt_senderId);
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
        private System.Windows.Forms.TextBox txt_senderId;
    }
}

