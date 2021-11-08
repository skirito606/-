
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.ON = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.Control;
            this.pb.Location = new System.Drawing.Point(21, 21);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(440, 330);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // ON
            // 
            this.ON.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ON.Location = new System.Drawing.Point(480, 21);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(82, 40);
            this.ON.TabIndex = 1;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.change.Location = new System.Drawing.Point(480, 84);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(82, 40);
            this.change.TabIndex = 2;
            this.change.Text = "轉換鍵";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // OFF
            // 
            this.OFF.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OFF.Location = new System.Drawing.Point(480, 150);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(82, 40);
            this.OFF.TabIndex = 3;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.change);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "Traffic light";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button OFF;
    }
}

