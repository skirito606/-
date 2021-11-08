
namespace 張守仁_Q4
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
            this.path = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.Initalization = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.path)).BeginInit();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(12, 49);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(450, 350);
            this.path.TabIndex = 0;
            this.path.TabStop = false;
            // 
            // exit
            // 
            this.exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(484, 349);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 25);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Initalization
            // 
            this.Initalization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Initalization.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Initalization.Location = new System.Drawing.Point(468, 298);
            this.Initalization.Name = "Initalization";
            this.Initalization.Size = new System.Drawing.Size(130, 25);
            this.Initalization.TabIndex = 2;
            this.Initalization.Text = "Initalization";
            this.Initalization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Initalization.Click += new System.EventHandler(this.Initalization_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(468, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "動態路線規劃系統";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Initalization);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.path)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox path;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label Initalization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

