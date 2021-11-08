
namespace 張守仁_Q1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cola = new System.Windows.Forms.PictureBox();
            this.Diet_Cola = new System.Windows.Forms.PictureBox();
            this.Pepsi = new System.Windows.Forms.PictureBox();
            this.Diet_Pepsi = new System.Windows.Forms.PictureBox();
            this.refund = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.five = new System.Windows.Forms.RadioButton();
            this.ten = new System.Windows.Forms.RadioButton();
            this.fifty = new System.Windows.Forms.RadioButton();
            this.deposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diet_Cola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diet_Pepsi)).BeginInit();
            this.SuspendLayout();
            // 
            // cola
            // 
            this.cola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cola.Image = ((System.Drawing.Image)(resources.GetObject("cola.Image")));
            this.cola.Location = new System.Drawing.Point(24, 12);
            this.cola.Name = "cola";
            this.cola.Size = new System.Drawing.Size(100, 49);
            this.cola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cola.TabIndex = 0;
            this.cola.TabStop = false;
            this.cola.Click += new System.EventHandler(this.cola_Click);
            // 
            // Diet_Cola
            // 
            this.Diet_Cola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Diet_Cola.Image = ((System.Drawing.Image)(resources.GetObject("Diet_Cola.Image")));
            this.Diet_Cola.Location = new System.Drawing.Point(24, 79);
            this.Diet_Cola.Name = "Diet_Cola";
            this.Diet_Cola.Size = new System.Drawing.Size(100, 49);
            this.Diet_Cola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diet_Cola.TabIndex = 1;
            this.Diet_Cola.TabStop = false;
            this.Diet_Cola.Click += new System.EventHandler(this.Diet_Cola_Click);
            // 
            // Pepsi
            // 
            this.Pepsi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pepsi.Image = ((System.Drawing.Image)(resources.GetObject("Pepsi.Image")));
            this.Pepsi.Location = new System.Drawing.Point(24, 152);
            this.Pepsi.Name = "Pepsi";
            this.Pepsi.Size = new System.Drawing.Size(100, 49);
            this.Pepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pepsi.TabIndex = 2;
            this.Pepsi.TabStop = false;
            this.Pepsi.Click += new System.EventHandler(this.Pepsi_Click);
            // 
            // Diet_Pepsi
            // 
            this.Diet_Pepsi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Diet_Pepsi.Image = ((System.Drawing.Image)(resources.GetObject("Diet_Pepsi.Image")));
            this.Diet_Pepsi.Location = new System.Drawing.Point(24, 227);
            this.Diet_Pepsi.Name = "Diet_Pepsi";
            this.Diet_Pepsi.Size = new System.Drawing.Size(100, 49);
            this.Diet_Pepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diet_Pepsi.TabIndex = 3;
            this.Diet_Pepsi.TabStop = false;
            this.Diet_Pepsi.Click += new System.EventHandler(this.Diet_Pepsi_Click);
            // 
            // refund
            // 
            this.refund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refund.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.refund.Location = new System.Drawing.Point(24, 282);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(146, 36);
            this.refund.TabIndex = 4;
            this.refund.Text = "退款(refund)";
            this.refund.UseVisualStyleBackColor = true;
            this.refund.Click += new System.EventHandler(this.refund_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(130, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "35元";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(130, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "30元";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(130, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "30元";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(130, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "25元";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // image
            // 
            this.image.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.image.Location = new System.Drawing.Point(21, 321);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(329, 36);
            this.image.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(232, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "存款(balance$)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.Color.White;
            this.balance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.balance.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.balance.Location = new System.Drawing.Point(235, 37);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(75, 24);
            this.balance.TabIndex = 11;
            this.balance.Text = "0.0";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.five.Location = new System.Drawing.Point(235, 94);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 25);
            this.five.TabIndex = 12;
            this.five.Text = "5元";
            this.five.UseVisualStyleBackColor = true;
            // 
            // ten
            // 
            this.ten.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ten.Location = new System.Drawing.Point(235, 135);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(75, 25);
            this.ten.TabIndex = 13;
            this.ten.Text = "10元";
            this.ten.UseVisualStyleBackColor = true;
            // 
            // fifty
            // 
            this.fifty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fifty.Location = new System.Drawing.Point(235, 176);
            this.fifty.Name = "fifty";
            this.fifty.Size = new System.Drawing.Size(75, 25);
            this.fifty.TabIndex = 14;
            this.fifty.Text = "50元";
            this.fifty.UseVisualStyleBackColor = true;
            // 
            // deposit
            // 
            this.deposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deposit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deposit.Location = new System.Drawing.Point(235, 226);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(84, 49);
            this.deposit.TabIndex = 15;
            this.deposit.Text = "投幣(deposit)";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 366);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.fifty);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.five);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refund);
            this.Controls.Add(this.Diet_Pepsi);
            this.Controls.Add(this.Pepsi);
            this.Controls.Add(this.Diet_Cola);
            this.Controls.Add(this.cola);
            this.Name = "Form1";
            this.Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.cola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diet_Cola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diet_Pepsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cola;
        private System.Windows.Forms.PictureBox Diet_Cola;
        private System.Windows.Forms.PictureBox Pepsi;
        private System.Windows.Forms.PictureBox Diet_Pepsi;
        private System.Windows.Forms.Button refund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.RadioButton five;
        private System.Windows.Forms.RadioButton ten;
        private System.Windows.Forms.RadioButton fifty;
        private System.Windows.Forms.Button deposit;
    }
}

