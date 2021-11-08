
namespace 張守仁_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_t = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.threeA = new System.Windows.Forms.Label();
            this.bigA = new System.Windows.Forms.Label();
            this.bt_cl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_t
            // 
            this.bt_t.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_t.Location = new System.Drawing.Point(41, 163);
            this.bt_t.Name = "bt_t";
            this.bt_t.Size = new System.Drawing.Size(88, 39);
            this.bt_t.TabIndex = 0;
            this.bt_t.Text = "轉換";
            this.bt_t.UseVisualStyleBackColor = true;
            this.bt_t.Click += new System.EventHandler(this.bt_t_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入數目：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number.Location = new System.Drawing.Point(100, 22);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(172, 28);
            this.number.TabIndex = 3;
            // 
            // threeA
            // 
            this.threeA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeA.Location = new System.Drawing.Point(12, 64);
            this.threeA.Name = "threeA";
            this.threeA.Size = new System.Drawing.Size(260, 23);
            this.threeA.TabIndex = 4;
            this.threeA.Text = "三位分隔數：";
            this.threeA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bigA
            // 
            this.bigA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bigA.Location = new System.Drawing.Point(12, 106);
            this.bigA.Name = "bigA";
            this.bigA.Size = new System.Drawing.Size(483, 23);
            this.bigA.TabIndex = 5;
            this.bigA.Text = "輸出大寫：";
            this.bigA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_cl
            // 
            this.bt_cl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cl.Location = new System.Drawing.Point(155, 163);
            this.bt_cl.Name = "bt_cl";
            this.bt_cl.Size = new System.Drawing.Size(88, 39);
            this.bt_cl.TabIndex = 6;
            this.bt_cl.Text = "清除";
            this.bt_cl.UseVisualStyleBackColor = true;
            this.bt_cl.Click += new System.EventHandler(this.bt_cl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 214);
            this.Controls.Add(this.bt_cl);
            this.Controls.Add(this.bigA);
            this.Controls.Add(this.threeA);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label threeA;
        private System.Windows.Forms.Label bigA;
        private System.Windows.Forms.Button bt_cl;
    }
}

