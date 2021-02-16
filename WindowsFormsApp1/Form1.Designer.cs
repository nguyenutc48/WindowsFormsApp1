
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
            this.tbp_mainContent = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_mainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnTaiLieu = new EnhancedGlassButton.GlassButton();
            this.btnGiaLap = new EnhancedGlassButton.GlassButton();
            this.btnCaiDat = new EnhancedGlassButton.GlassButton();
            this.btnGiamSat = new EnhancedGlassButton.GlassButton();
            this.pnl_mainContent = new System.Windows.Forms.Panel();
            this.bannerMain = new System.Windows.Forms.Panel();
            this.btnMiniApp = new EnhancedGlassButton.GlassButton();
            this.btnCloseApp = new EnhancedGlassButton.GlassButton();
            this.tbp_mainContent.SuspendLayout();
            this.tbp_mainMenu.SuspendLayout();
            this.bannerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbp_mainContent
            // 
            this.tbp_mainContent.ColumnCount = 1;
            this.tbp_mainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbp_mainContent.Controls.Add(this.bannerMain, 0, 0);
            this.tbp_mainContent.Controls.Add(this.label1, 0, 1);
            this.tbp_mainContent.Controls.Add(this.tbp_mainMenu, 0, 2);
            this.tbp_mainContent.Controls.Add(this.pnl_mainContent, 0, 3);
            this.tbp_mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbp_mainContent.Location = new System.Drawing.Point(0, 0);
            this.tbp_mainContent.Margin = new System.Windows.Forms.Padding(0);
            this.tbp_mainContent.Name = "tbp_mainContent";
            this.tbp_mainContent.RowCount = 4;
            this.tbp_mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28646F));
            this.tbp_mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.6875F));
            this.tbp_mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.6875F));
            this.tbp_mainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.59896F));
            this.tbp_mainContent.Size = new System.Drawing.Size(1280, 768);
            this.tbp_mainContent.TabIndex = 0;
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
            // tbp_mainMenu
            // 
            this.tbp_mainMenu.ColumnCount = 4;
            this.tbp_mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbp_mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbp_mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbp_mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbp_mainMenu.Controls.Add(this.btnTaiLieu, 3, 0);
            this.tbp_mainMenu.Controls.Add(this.btnGiaLap, 2, 0);
            this.tbp_mainMenu.Controls.Add(this.btnCaiDat, 1, 0);
            this.tbp_mainMenu.Controls.Add(this.btnGiamSat, 0, 0);
            this.tbp_mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbp_mainMenu.Location = new System.Drawing.Point(0, 113);
            this.tbp_mainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tbp_mainMenu.Name = "tbp_mainMenu";
            this.tbp_mainMenu.RowCount = 1;
            this.tbp_mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbp_mainMenu.Size = new System.Drawing.Size(1280, 35);
            this.tbp_mainMenu.TabIndex = 3;
            // 
            // btnTaiLieu
            // 
            this.btnTaiLieu.BackColor = System.Drawing.Color.White;
            this.btnTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaiLieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLieu.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLieu.GlowColor = System.Drawing.Color.Lime;
            this.btnTaiLieu.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnTaiLieu.Location = new System.Drawing.Point(965, 2);
            this.btnTaiLieu.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnTaiLieu.Name = "btnTaiLieu";
            this.btnTaiLieu.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.btnTaiLieu.Size = new System.Drawing.Size(310, 31);
            this.btnTaiLieu.TabIndex = 3;
            this.btnTaiLieu.Text = "TÀI LIỆU THAM KHẢO";
            this.btnTaiLieu.Click += new System.EventHandler(this.btnClick_Menu);
            // 
            // btnGiaLap
            // 
            this.btnGiaLap.BackColor = System.Drawing.Color.White;
            this.btnGiaLap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiaLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaLap.ForeColor = System.Drawing.Color.Black;
            this.btnGiaLap.GlowColor = System.Drawing.Color.Lime;
            this.btnGiaLap.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnGiaLap.Location = new System.Drawing.Point(645, 2);
            this.btnGiaLap.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnGiaLap.Name = "btnGiaLap";
            this.btnGiaLap.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.btnGiaLap.Size = new System.Drawing.Size(310, 31);
            this.btnGiaLap.TabIndex = 2;
            this.btnGiaLap.Text = "ĐƯA TÍN HIỆU GIẢ LẬP";
            this.btnGiaLap.Click += new System.EventHandler(this.btnClick_Menu);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.White;
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaiDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.Black;
            this.btnCaiDat.GlowColor = System.Drawing.Color.Lime;
            this.btnCaiDat.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.Location = new System.Drawing.Point(325, 2);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.btnCaiDat.Size = new System.Drawing.Size(310, 31);
            this.btnCaiDat.TabIndex = 1;
            this.btnCaiDat.Text = "CÀI ĐẶT THÔNG SỐ";
            this.btnCaiDat.Click += new System.EventHandler(this.btnClick_Menu);
            // 
            // btnGiamSat
            // 
            this.btnGiamSat.BackColor = System.Drawing.Color.Yellow;
            this.btnGiamSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiamSat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamSat.ForeColor = System.Drawing.Color.Black;
            this.btnGiamSat.GlowColor = System.Drawing.Color.Lime;
            this.btnGiamSat.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnGiamSat.Location = new System.Drawing.Point(5, 2);
            this.btnGiamSat.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnGiamSat.Name = "btnGiamSat";
            this.btnGiamSat.OuterBorderColor = System.Drawing.Color.DarkGreen;
            this.btnGiamSat.Size = new System.Drawing.Size(310, 31);
            this.btnGiamSat.TabIndex = 0;
            this.btnGiamSat.Text = "GIÁM SÁT HỆ THỐNG";
            this.btnGiamSat.Click += new System.EventHandler(this.btnClick_Menu);
            // 
            // pnl_mainContent
            // 
            this.pnl_mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_mainContent.Location = new System.Drawing.Point(0, 148);
            this.pnl_mainContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_mainContent.Name = "pnl_mainContent";
            this.pnl_mainContent.Size = new System.Drawing.Size(1280, 620);
            this.pnl_mainContent.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.tbp_mainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM GIÁM SÁT ĐỘNG CƠ MTU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbp_mainContent.ResumeLayout(false);
            this.tbp_mainMenu.ResumeLayout(false);
            this.bannerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbp_mainContent;
        private System.Windows.Forms.Panel bannerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbp_mainMenu;
        private EnhancedGlassButton.GlassButton btnGiamSat;
        private EnhancedGlassButton.GlassButton btnMiniApp;
        private EnhancedGlassButton.GlassButton btnCloseApp;
        private EnhancedGlassButton.GlassButton btnTaiLieu;
        private EnhancedGlassButton.GlassButton btnGiaLap;
        private EnhancedGlassButton.GlassButton btnCaiDat;
        private System.Windows.Forms.Panel pnl_mainContent;
    }
}

