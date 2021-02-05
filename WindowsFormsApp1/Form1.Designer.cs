
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBodyData = new System.Windows.Forms.Panel();
            this.gauge1 = new MfgControl.AdvancedHMI.Controls.Gauge();
            this.bannerMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.glassButton2 = new EnhancedGlassButton.GlassButton();
            this.glassButton3 = new EnhancedGlassButton.GlassButton();
            this.glassButton4 = new EnhancedGlassButton.GlassButton();
            this.btnMiniApp = new EnhancedGlassButton.GlassButton();
            this.btnCloseApp = new EnhancedGlassButton.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gauge4 = new MfgControl.AdvancedHMI.Controls.Gauge();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gauge5 = new MfgControl.AdvancedHMI.Controls.Gauge();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.bannerMain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bannerMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.6875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.6875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.59896F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60938F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.39063F));
            this.tableLayoutPanel2.Controls.Add(this.pnlBodyData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1280, 620);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlBodyData
            // 
            this.pnlBodyData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyData.Location = new System.Drawing.Point(187, 1);
            this.pnlBodyData.Margin = new System.Windows.Forms.Padding(0, 1, 5, 1);
            this.pnlBodyData.Name = "pnlBodyData";
            this.pnlBodyData.Size = new System.Drawing.Size(1088, 618);
            this.pnlBodyData.TabIndex = 1;
            // 
            // gauge1
            // 
            this.gauge1.AllowDragging = false;
            this.gauge1.BackColor = System.Drawing.Color.Transparent;
            this.gauge1.Location = new System.Drawing.Point(9, 30);
            this.gauge1.Margin = new System.Windows.Forms.Padding(0);
            this.gauge1.Maximum = 1200;
            this.gauge1.Minimum = 0;
            this.gauge1.Name = "gauge1";
            this.gauge1.Size = new System.Drawing.Size(159, 159);
            this.gauge1.TabIndex = 0;
            this.gauge1.Value = 0D;
            this.gauge1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bannerMain
            // 
            this.bannerMain.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logo;
            this.bannerMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerMain.Controls.Add(this.btnMiniApp);
            this.bannerMain.Controls.Add(this.btnCloseApp);
            this.bannerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bannerMain.Location = new System.Drawing.Point(0, 0);
            this.bannerMain.Margin = new System.Windows.Forms.Padding(0);
            this.bannerMain.Name = "bannerMain";
            this.bannerMain.Size = new System.Drawing.Size(1280, 78);
            this.bannerMain.TabIndex = 1;
            this.bannerMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bannerMain_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG GIÁM SÁT VÀ ĐƯA  TÍN HIỆU GIẢ LẬP CHO HỆ THỐNG MÔ PHỎNG ĐIỀU KHIỂN MTU T" +
    "RÊN TT200";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.glassButton4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.glassButton3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.glassButton2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.glassButton1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1280, 35);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.glassButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glassButton1.ForeColor = System.Drawing.Color.Black;
            this.glassButton1.GlowColor = System.Drawing.Color.Lime;
            this.glassButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.glassButton1.Location = new System.Drawing.Point(5, 2);
            this.glassButton1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.glassButton1.Size = new System.Drawing.Size(310, 31);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "GIÁM SÁT HỆ THỐNG";
            // 
            // glassButton2
            // 
            this.glassButton2.BackColor = System.Drawing.Color.OrangeRed;
            this.glassButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glassButton2.ForeColor = System.Drawing.Color.Black;
            this.glassButton2.GlowColor = System.Drawing.Color.Lime;
            this.glassButton2.InnerBorderColor = System.Drawing.Color.Transparent;
            this.glassButton2.Location = new System.Drawing.Point(325, 2);
            this.glassButton2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.glassButton2.Size = new System.Drawing.Size(310, 31);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "CÀI ĐẶT THÔNG SỐ";
            // 
            // glassButton3
            // 
            this.glassButton3.BackColor = System.Drawing.Color.OrangeRed;
            this.glassButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glassButton3.ForeColor = System.Drawing.Color.Black;
            this.glassButton3.GlowColor = System.Drawing.Color.Lime;
            this.glassButton3.InnerBorderColor = System.Drawing.Color.Transparent;
            this.glassButton3.Location = new System.Drawing.Point(645, 2);
            this.glassButton3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.glassButton3.Size = new System.Drawing.Size(310, 31);
            this.glassButton3.TabIndex = 2;
            this.glassButton3.Text = "ĐƯA TÍN HIỆU GIẢ LẬP";
            // 
            // glassButton4
            // 
            this.glassButton4.BackColor = System.Drawing.Color.OrangeRed;
            this.glassButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glassButton4.ForeColor = System.Drawing.Color.Black;
            this.glassButton4.GlowColor = System.Drawing.Color.Lime;
            this.glassButton4.InnerBorderColor = System.Drawing.Color.Transparent;
            this.glassButton4.Location = new System.Drawing.Point(965, 2);
            this.glassButton4.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.glassButton4.Name = "glassButton4";
            this.glassButton4.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.glassButton4.Size = new System.Drawing.Size(310, 31);
            this.glassButton4.TabIndex = 3;
            this.glassButton4.Text = "TÀI LIỆU THAM KHẢO";
            // 
            // btnMiniApp
            // 
            this.btnMiniApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniApp.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMiniApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniApp.ForeColor = System.Drawing.Color.Yellow;
            this.btnMiniApp.GlowColor = System.Drawing.Color.Lime;
            this.btnMiniApp.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnMiniApp.Location = new System.Drawing.Point(1190, 3);
            this.btnMiniApp.Name = "btnMiniApp";
            this.btnMiniApp.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnMiniApp.ShowFocusBorder = true;
            this.btnMiniApp.Size = new System.Drawing.Size(41, 34);
            this.btnMiniApp.TabIndex = 1;
            this.btnMiniApp.Text = "-";
            this.btnMiniApp.Click += new System.EventHandler(this.btnMiniApp_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.Red;
            this.btnCloseApp.GlowColor = System.Drawing.Color.Lime;
            this.btnCloseApp.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.Location = new System.Drawing.Point(1237, 3);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.ShowFocusBorder = true;
            this.btnCloseApp.Size = new System.Drawing.Size(41, 34);
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐỘNG CƠ 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(187, 620);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gauge1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 204);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gauge4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 207);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 204);
            this.panel3.TabIndex = 1;
            // 
            // gauge4
            // 
            this.gauge4.AllowDragging = false;
            this.gauge4.BackColor = System.Drawing.Color.Transparent;
            this.gauge4.Location = new System.Drawing.Point(9, 30);
            this.gauge4.Margin = new System.Windows.Forms.Padding(0);
            this.gauge4.Maximum = 1200;
            this.gauge4.Minimum = 0;
            this.gauge4.Name = "gauge4";
            this.gauge4.Size = new System.Drawing.Size(159, 159);
            this.gauge4.TabIndex = 0;
            this.gauge4.Value = 0D;
            this.gauge4.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ĐỘNG CƠ 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gauge5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 413);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 206);
            this.panel4.TabIndex = 2;
            // 
            // gauge5
            // 
            this.gauge5.AllowDragging = false;
            this.gauge5.BackColor = System.Drawing.Color.Transparent;
            this.gauge5.Location = new System.Drawing.Point(9, 30);
            this.gauge5.Margin = new System.Windows.Forms.Padding(0);
            this.gauge5.Maximum = 1200;
            this.gauge5.Minimum = 0;
            this.gauge5.Name = "gauge5";
            this.gauge5.Size = new System.Drawing.Size(159, 159);
            this.gauge5.TabIndex = 0;
            this.gauge5.Value = 0D;
            this.gauge5.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "ĐỘNG CƠ 3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM GIÁM SÁT ĐỘNG CƠ MTU";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.bannerMain.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MfgControl.AdvancedHMI.Controls.Gauge gauge1;
        private System.Windows.Forms.Panel pnlBodyData;
        private System.Windows.Forms.Panel bannerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private EnhancedGlassButton.GlassButton glassButton1;
        private EnhancedGlassButton.GlassButton btnMiniApp;
        private EnhancedGlassButton.GlassButton btnCloseApp;
        private EnhancedGlassButton.GlassButton glassButton4;
        private EnhancedGlassButton.GlassButton glassButton3;
        private EnhancedGlassButton.GlassButton glassButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private MfgControl.AdvancedHMI.Controls.Gauge gauge5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private MfgControl.AdvancedHMI.Controls.Gauge gauge4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

