
namespace WindowsFormsApp1.Views
{
    partial class gsHethongDC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGiamSatDC1 = new WindowsFormsApp1.Views.ucGiamSatDC();
            this.ucGiamSatDC2 = new WindowsFormsApp1.Views.ucGiamSatDC();
            this.ucGiamSatDC3 = new WindowsFormsApp1.Views.ucGiamSatDC();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.pictureBox9);
            this.pnlHeader.Controls.Add(this.pictureBox8);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1088, 40);
            this.pnlHeader.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1086, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG ĐỘNG CƠ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucGiamSatDC1
            // 
            this.ucGiamSatDC1.Location = new System.Drawing.Point(4, 45);
            this.ucGiamSatDC1.Name = "ucGiamSatDC1";
            this.ucGiamSatDC1.Size = new System.Drawing.Size(528, 277);
            this.ucGiamSatDC1.TabIndex = 79;
            // 
            // ucGiamSatDC2
            // 
            this.ucGiamSatDC2.Location = new System.Drawing.Point(555, 45);
            this.ucGiamSatDC2.Name = "ucGiamSatDC2";
            this.ucGiamSatDC2.Size = new System.Drawing.Size(528, 277);
            this.ucGiamSatDC2.TabIndex = 79;
            // 
            // ucGiamSatDC3
            // 
            this.ucGiamSatDC3.Location = new System.Drawing.Point(555, 328);
            this.ucGiamSatDC3.Name = "ucGiamSatDC3";
            this.ucGiamSatDC3.Size = new System.Drawing.Size(528, 277);
            this.ucGiamSatDC3.TabIndex = 79;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Coral;
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.back;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Coral;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.home1;
            this.pictureBox8.Location = new System.Drawing.Point(1046, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // gsHethongDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucGiamSatDC3);
            this.Controls.Add(this.ucGiamSatDC2);
            this.Controls.Add(this.ucGiamSatDC1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "gsHethongDC";
            this.Size = new System.Drawing.Size(1088, 618);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private ucGiamSatDC ucGiamSatDC1;
        private ucGiamSatDC ucGiamSatDC2;
        private ucGiamSatDC ucGiamSatDC3;
    }
}
