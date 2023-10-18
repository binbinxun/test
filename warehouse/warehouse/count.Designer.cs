namespace warehouse
{
    partial class count
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
            this.btnplane = new System.Windows.Forms.Button();
            this.btninput = new System.Windows.Forms.Button();
            this.pwarehouse = new System.Windows.Forms.Panel();
            this.btnappoint = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lprogress = new System.Windows.Forms.Label();
            this.lorder = new System.Windows.Forms.Label();
            this.lappoint = new System.Windows.Forms.Label();
            this.lall = new System.Windows.Forms.Label();
            this.lnumber = new System.Windows.Forms.Label();
            this.panel_change.SuspendLayout();
            this.pwarehouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_change
            // 
            this.panel_change.BackColor = System.Drawing.Color.Silver;
            this.panel_change.Controls.Add(this.btnplane);
            this.panel_change.Controls.Add(this.btninput);
            this.panel_change.Location = new System.Drawing.Point(11, 11);
            this.panel_change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_change.Name = "panel_change";
            this.panel_change.Size = new System.Drawing.Size(200, 833);
            this.panel_change.TabIndex = 1;
            // 
            // btnplane
            // 
            this.btnplane.BackColor = System.Drawing.Color.White;
            this.btnplane.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnplane.Location = new System.Drawing.Point(17, 181);
            this.btnplane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnplane.Name = "btnplane";
            this.btnplane.Size = new System.Drawing.Size(162, 54);
            this.btnplane.TabIndex = 0;
            this.btnplane.Text = "仓库平面";
            this.btnplane.UseVisualStyleBackColor = false;
            this.btnplane.Click += new System.EventHandler(this.btnplane_Click);
            // 
            // btninput
            // 
            this.btninput.BackColor = System.Drawing.Color.White;
            this.btninput.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninput.Location = new System.Drawing.Point(17, 88);
            this.btninput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(162, 54);
            this.btninput.TabIndex = 0;
            this.btninput.Text = "参数输入";
            this.btninput.UseVisualStyleBackColor = false;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // pwarehouse
            // 
            this.pwarehouse.BackColor = System.Drawing.Color.Gainsboro;
            this.pwarehouse.Controls.Add(this.btnappoint);
            this.pwarehouse.Controls.Add(this.btnAll);
            this.pwarehouse.Controls.Add(this.txtnumber);
            this.pwarehouse.Controls.Add(this.lprogress);
            this.pwarehouse.Controls.Add(this.lorder);
            this.pwarehouse.Controls.Add(this.lappoint);
            this.pwarehouse.Controls.Add(this.lall);
            this.pwarehouse.Controls.Add(this.lnumber);
            this.pwarehouse.Location = new System.Drawing.Point(230, 11);
            this.pwarehouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwarehouse.Name = "pwarehouse";
            this.pwarehouse.Size = new System.Drawing.Size(1312, 833);
            this.pwarehouse.TabIndex = 4;
            // 
            // btnappoint
            // 
            this.btnappoint.BackColor = System.Drawing.Color.White;
            this.btnappoint.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnappoint.Location = new System.Drawing.Point(343, 295);
            this.btnappoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnappoint.Name = "btnappoint";
            this.btnappoint.Size = new System.Drawing.Size(550, 58);
            this.btnappoint.TabIndex = 3;
            this.btnappoint.Text = "计算指定货物出库";
            this.btnappoint.UseVisualStyleBackColor = false;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAll.Location = new System.Drawing.Point(343, 84);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(550, 58);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "计算全部货物出库";
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(518, 212);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(174, 28);
            this.txtnumber.TabIndex = 2;
            // 
            // lprogress
            // 
            this.lprogress.AutoSize = true;
            this.lprogress.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lprogress.Location = new System.Drawing.Point(80, 490);
            this.lprogress.Name = "lprogress";
            this.lprogress.Size = new System.Drawing.Size(195, 36);
            this.lprogress.TabIndex = 1;
            this.lprogress.Text = "出库进度：";
            // 
            // lorder
            // 
            this.lorder.AutoSize = true;
            this.lorder.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lorder.Location = new System.Drawing.Point(80, 408);
            this.lorder.Name = "lorder";
            this.lorder.Size = new System.Drawing.Size(195, 36);
            this.lorder.TabIndex = 1;
            this.lorder.Text = "货物次序：";
            // 
            // lappoint
            // 
            this.lappoint.AutoSize = true;
            this.lappoint.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lappoint.Location = new System.Drawing.Point(80, 199);
            this.lappoint.Name = "lappoint";
            this.lappoint.Size = new System.Drawing.Size(195, 36);
            this.lappoint.TabIndex = 1;
            this.lappoint.Text = "指定货物：";
            // 
            // lall
            // 
            this.lall.AutoSize = true;
            this.lall.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lall.Location = new System.Drawing.Point(80, 96);
            this.lall.Name = "lall";
            this.lall.Size = new System.Drawing.Size(195, 36);
            this.lall.TabIndex = 1;
            this.lall.Text = "全部货物：";
            // 
            // lnumber
            // 
            this.lnumber.AutoSize = true;
            this.lnumber.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnumber.Location = new System.Drawing.Point(339, 212);
            this.lnumber.Name = "lnumber";
            this.lnumber.Size = new System.Drawing.Size(164, 22);
            this.lnumber.TabIndex = 1;
            this.lnumber.Text = "指定货物数量：";
            // 
            // count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 858);
            this.Controls.Add(this.pwarehouse);
            this.Controls.Add(this.panel_change);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "count";
            this.Text = "计算";
            this.panel_change.ResumeLayout(false);
            this.pwarehouse.ResumeLayout(false);
            this.pwarehouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_change;
        private System.Windows.Forms.Button btnplane;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Panel pwarehouse;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lall;
        private System.Windows.Forms.Label lnumber;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lappoint;
        private System.Windows.Forms.Button btnappoint;
        private System.Windows.Forms.Label lprogress;
        private System.Windows.Forms.Label lorder;
    }
}