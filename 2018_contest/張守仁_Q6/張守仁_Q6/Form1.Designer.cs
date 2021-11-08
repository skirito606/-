
namespace 張守仁_Q6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.huffman_text1 = new System.Windows.Forms.TextBox();
            this.huffman_text2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.decoding = new System.Windows.Forms.Button();
            this.rd2 = new System.Windows.Forms.Button();
            this.rd1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.confirm2 = new System.Windows.Forms.Label();
            this.confirm1 = new System.Windows.Forms.Label();
            this.decode_text1 = new System.Windows.Forms.Label();
            this.decode_text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "簡易霍夫曼解碼資料解壓縮系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(198, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "解碼文字";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(243, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "10";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(243, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(293, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "01";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(293, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "B";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(393, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "D";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(393, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "001";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(343, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "C";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(343, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "11";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(443, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "E";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(443, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "000";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(55, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = "霍夫曼碼1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(55, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 22);
            this.label12.TabIndex = 13;
            this.label12.Text = "合理驗證1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(55, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "霍夫曼碼2";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(55, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 22);
            this.label16.TabIndex = 15;
            this.label16.Text = "合理驗證2";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // huffman_text1
            // 
            this.huffman_text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huffman_text1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.huffman_text1.Location = new System.Drawing.Point(147, 118);
            this.huffman_text1.Name = "huffman_text1";
            this.huffman_text1.Size = new System.Drawing.Size(404, 27);
            this.huffman_text1.TabIndex = 16;
            // 
            // huffman_text2
            // 
            this.huffman_text2.BackColor = System.Drawing.SystemColors.Window;
            this.huffman_text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.huffman_text2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.huffman_text2.Location = new System.Drawing.Point(147, 195);
            this.huffman_text2.Name = "huffman_text2";
            this.huffman_text2.Size = new System.Drawing.Size(404, 27);
            this.huffman_text2.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(250, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 22);
            this.label17.TabIndex = 19;
            this.label17.Text = "霍夫曼解碼1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(250, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 22);
            this.label18.TabIndex = 21;
            this.label18.Text = "霍夫曼解碼2";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decoding
            // 
            this.decoding.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.decoding.Location = new System.Drawing.Point(253, 279);
            this.decoding.Name = "decoding";
            this.decoding.Size = new System.Drawing.Size(102, 33);
            this.decoding.TabIndex = 24;
            this.decoding.Text = "Decoding";
            this.decoding.UseVisualStyleBackColor = true;
            this.decoding.Click += new System.EventHandler(this.decoding_Click);
            // 
            // rd2
            // 
            this.rd2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rd2.Location = new System.Drawing.Point(557, 195);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(120, 27);
            this.rd2.TabIndex = 25;
            this.rd2.Text = "Random Set2";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.Click += new System.EventHandler(this.rd2_Click);
            // 
            // rd1
            // 
            this.rd1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rd1.Location = new System.Drawing.Point(557, 118);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(120, 27);
            this.rd1.TabIndex = 26;
            this.rd1.Text = "Random Set1";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.Click += new System.EventHandler(this.rd1_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(557, 279);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 33);
            this.exit.TabIndex = 27;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // confirm2
            // 
            this.confirm2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirm2.Location = new System.Drawing.Point(147, 239);
            this.confirm2.Name = "confirm2";
            this.confirm2.Size = new System.Drawing.Size(97, 22);
            this.confirm2.TabIndex = 28;
            this.confirm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm1
            // 
            this.confirm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirm1.Location = new System.Drawing.Point(147, 161);
            this.confirm1.Name = "confirm1";
            this.confirm1.Size = new System.Drawing.Size(97, 22);
            this.confirm1.TabIndex = 29;
            this.confirm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decode_text1
            // 
            this.decode_text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decode_text1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.decode_text1.Location = new System.Drawing.Point(361, 161);
            this.decode_text1.Name = "decode_text1";
            this.decode_text1.Size = new System.Drawing.Size(245, 22);
            this.decode_text1.TabIndex = 30;
            this.decode_text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decode_text2
            // 
            this.decode_text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decode_text2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.decode_text2.Location = new System.Drawing.Point(361, 239);
            this.decode_text2.Name = "decode_text2";
            this.decode_text2.Size = new System.Drawing.Size(245, 22);
            this.decode_text2.TabIndex = 31;
            this.decode_text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(738, 367);
            this.Controls.Add(this.decode_text2);
            this.Controls.Add(this.decode_text1);
            this.Controls.Add(this.confirm1);
            this.Controls.Add(this.confirm2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.decoding);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.huffman_text2);
            this.Controls.Add(this.huffman_text1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox huffman_text1;
        private System.Windows.Forms.TextBox huffman_text2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button decoding;
        private System.Windows.Forms.Button rd2;
        private System.Windows.Forms.Button rd1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label confirm2;
        private System.Windows.Forms.Label confirm1;
        private System.Windows.Forms.Label decode_text1;
        private System.Windows.Forms.Label decode_text2;
    }
}

