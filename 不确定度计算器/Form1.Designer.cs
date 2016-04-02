namespace 不确定度计算器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cDataCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cP = new System.Windows.Forms.ComboBox();
            this.bCalc = new System.Windows.Forms.Button();
            this.tOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tDeltaYi = new System.Windows.Forms.TextBox();
            this.tDeltaGu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cDataCount
            // 
            this.cDataCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDataCount.FormattingEnabled = true;
            this.cDataCount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cDataCount.Location = new System.Drawing.Point(98, 12);
            this.cDataCount.Name = "cDataCount";
            this.cDataCount.Size = new System.Drawing.Size(76, 20);
            this.cDataCount.TabIndex = 0;
            this.cDataCount.SelectedIndexChanged += new System.EventHandler(this.cDataCount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据组数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "P=";
            // 
            // cP
            // 
            this.cP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cP.FormattingEnabled = true;
            this.cP.Items.AddRange(new object[] {
            "0.68",
            "0.90",
            "0.95",
            "0.99"});
            this.cP.Location = new System.Drawing.Point(219, 12);
            this.cP.Name = "cP";
            this.cP.Size = new System.Drawing.Size(76, 20);
            this.cP.TabIndex = 3;
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(436, 11);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(98, 47);
            this.bCalc.TabIndex = 4;
            this.bCalc.Text = "计算";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // tOutput
            // 
            this.tOutput.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tOutput.Location = new System.Drawing.Point(150, 66);
            this.tOutput.Multiline = true;
            this.tOutput.Name = "tOutput";
            this.tOutput.ReadOnly = true;
            this.tOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tOutput.Size = new System.Drawing.Size(384, 291);
            this.tOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "误差分布：";
            // 
            // cC
            // 
            this.cC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cC.FormattingEnabled = true;
            this.cC.Items.AddRange(new object[] {
            "均匀(游标卡尺)",
            "正态(米尺,千分尺,天平,秒表)"});
            this.cC.Location = new System.Drawing.Point(219, 38);
            this.cC.Name = "cC";
            this.cC.Size = new System.Drawing.Size(76, 20);
            this.cC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Δ仪：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Δ估：";
            // 
            // tDeltaYi
            // 
            this.tDeltaYi.Location = new System.Drawing.Point(354, 12);
            this.tDeltaYi.Name = "tDeltaYi";
            this.tDeltaYi.Size = new System.Drawing.Size(76, 21);
            this.tDeltaYi.TabIndex = 10;
            this.tDeltaYi.Text = "0";
            // 
            // tDeltaGu
            // 
            this.tDeltaGu.Location = new System.Drawing.Point(354, 39);
            this.tDeltaGu.Name = "tDeltaGu";
            this.tDeltaGu.Size = new System.Drawing.Size(76, 21);
            this.tDeltaGu.TabIndex = 11;
            this.tDeltaGu.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "清空数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "粘贴自Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tDeltaGu);
            this.Controls.Add(this.tDeltaYi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tOutput);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.cP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cDataCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "不确定度计算器(测试版) by 负一的平方根";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cDataCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cP;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.TextBox tOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tDeltaYi;
        private System.Windows.Forms.TextBox tDeltaGu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

