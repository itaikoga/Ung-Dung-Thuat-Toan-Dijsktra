namespace DijkstraTest2
{
    partial class Form1
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvListProvinces = new System.Windows.Forms.ListView();
            this.clPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.BanDoPhiaNam = new System.Windows.Forms.PictureBox();
            this.cbDiemdi = new System.Windows.Forms.ComboBox();
            this.cbDiemden = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTuyenDuongDi = new System.Windows.Forms.TextBox();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.tbLit = new System.Windows.Forms.TextBox();
            this.tbTongCongChiPhi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanDoPhiaNam)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lbInfo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Honeydew;
            this.lbInfo.Location = new System.Drawing.Point(1, 9);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(878, 37);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "ỨNG DỤNG THUẬT TOÁN DIJKSTRA TỐI ƯU HÓA CHI PHÍ VẬN TẢI";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa điểm hành trình";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightYellow;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(4, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm xuất phát";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightYellow;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(5, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm đến";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Provinces/Cities in South Vietnam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvListProvinces
            // 
            this.lvListProvinces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPoint,
            this.clName});
            this.lvListProvinces.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvListProvinces.GridLines = true;
            this.lvListProvinces.HideSelection = false;
            this.lvListProvinces.Location = new System.Drawing.Point(4, 63);
            this.lvListProvinces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvListProvinces.Name = "lvListProvinces";
            this.lvListProvinces.Size = new System.Drawing.Size(960, 656);
            this.lvListProvinces.TabIndex = 3;
            this.lvListProvinces.UseCompatibleStateImageBehavior = false;
            this.lvListProvinces.View = System.Windows.Forms.View.Details;
            // 
            // clPoint
            // 
            this.clPoint.Text = "Point";
            this.clPoint.Width = 235;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 400;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Ivory;
            this.flowLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.BanDoPhiaNam);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(549, 51);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(867, 562);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(861, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bản đồ các tỉnh phía nam Việt Nam";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BanDoPhiaNam
            // 
            this.BanDoPhiaNam.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BanDoPhiaNam.BackgroundImage = global::DijkstraTest2.Properties.Resources._1324532_removebg;
            this.BanDoPhiaNam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BanDoPhiaNam.Image = global::DijkstraTest2.Properties.Resources._04142915_ban_do_cac_tinh_mien_nam_removebg__1_;
            this.BanDoPhiaNam.Location = new System.Drawing.Point(3, 48);
            this.BanDoPhiaNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BanDoPhiaNam.Name = "BanDoPhiaNam";
            this.BanDoPhiaNam.Size = new System.Drawing.Size(643, 423);
            this.BanDoPhiaNam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BanDoPhiaNam.TabIndex = 3;
            this.BanDoPhiaNam.TabStop = false;
            this.BanDoPhiaNam.Click += new System.EventHandler(this.BanDoPhiaNam_Click);
            this.BanDoPhiaNam.Paint += new System.Windows.Forms.PaintEventHandler(this.southMap_Paint);
            // 
            // cbDiemdi
            // 
            this.cbDiemdi.BackColor = System.Drawing.Color.MintCream;
            this.cbDiemdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemdi.FormattingEnabled = true;
            this.cbDiemdi.Location = new System.Drawing.Point(225, 53);
            this.cbDiemdi.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiemdi.Name = "cbDiemdi";
            this.cbDiemdi.Size = new System.Drawing.Size(206, 40);
            this.cbDiemdi.TabIndex = 1;
            this.cbDiemdi.SelectedIndexChanged += new System.EventHandler(this.cbSource_SelectedIndexChanged);
            // 
            // cbDiemden
            // 
            this.cbDiemden.BackColor = System.Drawing.Color.MintCream;
            this.cbDiemden.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemden.FormattingEnabled = true;
            this.cbDiemden.Location = new System.Drawing.Point(225, 126);
            this.cbDiemden.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiemden.Name = "cbDiemden";
            this.cbDiemden.Size = new System.Drawing.Size(206, 40);
            this.cbDiemden.TabIndex = 7;
            this.cbDiemden.SelectedIndexChanged += new System.EventHandler(this.cbDestination_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.BackgroundImage = global::DijkstraTest2.Properties.Resources._364aa27f751d0ed4114ac93baa76eeb11;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbDiemdi);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbDiemden);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbTuyenDuongDi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbKM);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lable12);
            this.panel3.Controls.Add(this.tbLit);
            this.panel3.Controls.Add(this.tbTongCongChiPhi);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(7, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 564);
            this.panel3.TabIndex = 10;
            // 
            // tbTuyenDuongDi
            // 
            this.tbTuyenDuongDi.BackColor = System.Drawing.Color.MintCream;
            this.tbTuyenDuongDi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuyenDuongDi.Location = new System.Drawing.Point(4, 488);
            this.tbTuyenDuongDi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTuyenDuongDi.Name = "tbTuyenDuongDi";
            this.tbTuyenDuongDi.Size = new System.Drawing.Size(494, 34);
            this.tbTuyenDuongDi.TabIndex = 8;
            // 
            // tbKM
            // 
            this.tbKM.BackColor = System.Drawing.Color.MintCream;
            this.tbKM.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKM.Location = new System.Drawing.Point(225, 283);
            this.tbKM.Margin = new System.Windows.Forms.Padding(4);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(206, 38);
            this.tbKM.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightYellow;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(5, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 45);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng cộng chi phí";
            // 
            // lable12
            // 
            this.lable12.BackColor = System.Drawing.Color.LightYellow;
            this.lable12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.ForeColor = System.Drawing.Color.DarkGreen;
            this.lable12.Location = new System.Drawing.Point(4, 283);
            this.lable12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(212, 38);
            this.lable12.TabIndex = 10;
            this.lable12.Text = "Tổng số kilomet";
            // 
            // tbLit
            // 
            this.tbLit.BackColor = System.Drawing.Color.MintCream;
            this.tbLit.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLit.Location = new System.Drawing.Point(225, 202);
            this.tbLit.Margin = new System.Windows.Forms.Padding(4);
            this.tbLit.Name = "tbLit";
            this.tbLit.Size = new System.Drawing.Size(206, 38);
            this.tbLit.TabIndex = 9;
            // 
            // tbTongCongChiPhi
            // 
            this.tbTongCongChiPhi.BackColor = System.Drawing.Color.MintCream;
            this.tbTongCongChiPhi.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongCongChiPhi.Location = new System.Drawing.Point(225, 348);
            this.tbTongCongChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTongCongChiPhi.Name = "tbTongCongChiPhi";
            this.tbTongCongChiPhi.Size = new System.Drawing.Size(206, 38);
            this.tbTongCongChiPhi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightYellow;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(5, 417);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tuyến đường đi";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(4, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 62);
            this.label9.TabIndex = 9;
            this.label9.Text = "Lượng xăng tiêu \r\nthụ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = global::DijkstraTest2.Properties.Resources.Screenshot_2024_04_09_145503;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 696);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanDoPhiaNam)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDiemdi;
        private System.Windows.Forms.ComboBox cbDiemden;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTuyenDuongDi;
        private System.Windows.Forms.TextBox tbTongCongChiPhi;
        private System.Windows.Forms.ListView lvListProvinces;
        public System.Windows.Forms.ColumnHeader clPoint;
        public System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.PictureBox BanDoPhiaNam;
        private System.Windows.Forms.TextBox tbLit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.Label lable12;
    }
}
