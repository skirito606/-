
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選取資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.統計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.求F統計值及自由度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.input_text = new System.Windows.Forms.TextBox();
            this.output_text = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.統計ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選取資料ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 選取資料ToolStripMenuItem
            // 
            this.選取資料ToolStripMenuItem.Name = "選取資料ToolStripMenuItem";
            this.選取資料ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.選取資料ToolStripMenuItem.Text = "選取資料";
            this.選取資料ToolStripMenuItem.Click += new System.EventHandler(this.選取資料ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 統計ToolStripMenuItem
            // 
            this.統計ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.求F統計值及自由度ToolStripMenuItem});
            this.統計ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.統計ToolStripMenuItem.Name = "統計ToolStripMenuItem";
            this.統計ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.統計ToolStripMenuItem.Text = "統計";
            // 
            // 求F統計值及自由度ToolStripMenuItem
            // 
            this.求F統計值及自由度ToolStripMenuItem.Name = "求F統計值及自由度ToolStripMenuItem";
            this.求F統計值及自由度ToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.求F統計值及自由度ToolStripMenuItem.Text = "求F統計值及自由度df";
            this.求F統計值及自由度ToolStripMenuItem.Click += new System.EventHandler(this.求F統計值及自由度ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_text);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入資料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.output_text);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(535, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "F統計值及自由度df";
            // 
            // input_text
            // 
            this.input_text.BackColor = System.Drawing.SystemColors.Window;
            this.input_text.Location = new System.Drawing.Point(6, 26);
            this.input_text.Multiline = true;
            this.input_text.Name = "input_text";
            this.input_text.ReadOnly = true;
            this.input_text.Size = new System.Drawing.Size(505, 336);
            this.input_text.TabIndex = 0;
            // 
            // output_text
            // 
            this.output_text.BackColor = System.Drawing.SystemColors.Window;
            this.output_text.Location = new System.Drawing.Point(6, 26);
            this.output_text.Multiline = true;
            this.output_text.Name = "output_text";
            this.output_text.ReadOnly = true;
            this.output_text.Size = new System.Drawing.Size(225, 336);
            this.output_text.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "全國高級中等學校107學年度工業類科學生技藝競賽";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選取資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 統計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 求F統計值及自由度ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

