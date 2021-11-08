
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
            this.RB = new System.Windows.Forms.Label();
            this.CR = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.graph_RB = new System.Windows.Forms.PictureBox();
            this.graph_CR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph_RB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_CR)).BeginInit();
            this.SuspendLayout();
            // 
            // RB
            // 
            this.RB.AutoSize = true;
            this.RB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RB.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB.Location = new System.Drawing.Point(12, 36);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(169, 26);
            this.RB.TabIndex = 0;
            this.RB.Text = "Random Blocks";
            this.RB.Click += new System.EventHandler(this.RB_Click);
            // 
            // CR
            // 
            this.CR.AutoSize = true;
            this.CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CR.Location = new System.Drawing.Point(205, 36);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(203, 26);
            this.CR.TabIndex = 1;
            this.CR.Text = "Convex Rectilinear";
            this.CR.Click += new System.EventHandler(this.CR_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exit.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Exit.Location = new System.Drawing.Point(587, 36);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 26);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "凸形直線環繞系統";
            // 
            // graph_RB
            // 
            this.graph_RB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_RB.Location = new System.Drawing.Point(12, 73);
            this.graph_RB.Name = "graph_RB";
            this.graph_RB.Size = new System.Drawing.Size(300, 300);
            this.graph_RB.TabIndex = 4;
            this.graph_RB.TabStop = false;
            // 
            // graph_CR
            // 
            this.graph_CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_CR.Location = new System.Drawing.Point(340, 73);
            this.graph_CR.Name = "graph_CR";
            this.graph_CR.Size = new System.Drawing.Size(300, 300);
            this.graph_CR.TabIndex = 5;
            this.graph_CR.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 385);
            this.Controls.Add(this.graph_CR);
            this.Controls.Add(this.graph_RB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CR);
            this.Controls.Add(this.RB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph_RB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_CR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RB;
        private System.Windows.Forms.Label CR;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox graph_RB;
        private System.Windows.Forms.PictureBox graph_CR;
    }
}

