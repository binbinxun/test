namespace warehouse
{
    partial class plane
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
            this.panel_change = new System.Windows.Forms.Panel();
            this.btncount = new System.Windows.Forms.Button();
            this.btninput = new System.Windows.Forms.Button();
            this.pwarehouse = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lbpl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_change.SuspendLayout();
            this.pwarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_change
            // 
            this.panel_change.BackColor = System.Drawing.Color.Silver;
            this.panel_change.Controls.Add(this.btncount);
            this.panel_change.Controls.Add(this.btninput);
            this.panel_change.Location = new System.Drawing.Point(12, 12);
            this.panel_change.Name = "panel_change";
            this.panel_change.Size = new System.Drawing.Size(178, 755);
            this.panel_change.TabIndex = 2;
            // 
            // btncount
            // 
            this.btncount.BackColor = System.Drawing.Color.White;
            this.btncount.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncount.Location = new System.Drawing.Point(15, 151);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(144, 45);
            this.btncount.TabIndex = 0;
            this.btncount.Text = "计算";
            this.btncount.UseVisualStyleBackColor = false;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btninput
            // 
            this.btninput.BackColor = System.Drawing.Color.White;
            this.btninput.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninput.Location = new System.Drawing.Point(15, 73);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(144, 45);
            this.btninput.TabIndex = 0;
            this.btninput.Text = "参数修改";
            this.btninput.UseVisualStyleBackColor = false;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // pwarehouse
            // 
            this.pwarehouse.BackColor = System.Drawing.Color.Gainsboro;
            this.pwarehouse.Controls.Add(this.pictureBox1);
            this.pwarehouse.Controls.Add(this.label3);
            this.pwarehouse.Controls.Add(this.label2);
            this.pwarehouse.Controls.Add(this.label1);
            this.pwarehouse.Controls.Add(this.button9);
            this.pwarehouse.Controls.Add(this.button8);
            this.pwarehouse.Controls.Add(this.button7);
            this.pwarehouse.Controls.Add(this.button6);
            this.pwarehouse.Controls.Add(this.lbpl);
            this.pwarehouse.Controls.Add(this.button5);
            this.pwarehouse.Controls.Add(this.button4);
            this.pwarehouse.Controls.Add(this.button3);
            this.pwarehouse.Controls.Add(this.button2);
            this.pwarehouse.Controls.Add(this.button1);
            this.pwarehouse.Location = new System.Drawing.Point(197, 12);
            this.pwarehouse.Name = "pwarehouse";
            this.pwarehouse.Size = new System.Drawing.Size(1220, 755);
            this.pwarehouse.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(34, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1165, 538);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "暂时呈现结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(388, 719);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "指定XX个货物出库时间XX分钟";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(388, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "XX个货物出库时间XX分钟";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(840, 702);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(241, 41);
            this.button9.TabIndex = 8;
            this.button9.Text = "点击查看货物次序\r\n";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(840, 636);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(241, 43);
            this.button8.TabIndex = 7;
            this.button8.Text = "点击查看货物次序";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(85, 702);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "指定货物出库";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(85, 636);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "全部货物出库";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // lbpl
            // 
            this.lbpl.AutoSize = true;
            this.lbpl.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbpl.Location = new System.Drawing.Point(412, 11);
            this.lbpl.Name = "lbpl";
            this.lbpl.Size = new System.Drawing.Size(334, 24);
            this.lbpl.TabIndex = 4;
            this.lbpl.Text = "仓库出库计算小程序-输出界面";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(855, 586);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 45);
            this.button5.TabIndex = 0;
            this.button5.Text = "运输车辆数量";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(623, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 45);
            this.button4.TabIndex = 0;
            this.button4.Text = "运输路线数量";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(414, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "货物尺寸";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(236, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "货物数量";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(70, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "仓库面积";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 774);
            this.Controls.Add(this.pwarehouse);
            this.Controls.Add(this.panel_change);
            this.Name = "plane";
            this.Text = "仓库平面图";
            this.Load += new System.EventHandler(this.plane_Load);
            this.panel_change.ResumeLayout(false);
            this.pwarehouse.ResumeLayout(false);
            this.pwarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_change;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Panel pwarehouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbpl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}