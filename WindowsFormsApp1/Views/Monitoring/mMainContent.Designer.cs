
namespace WindowsFormsApp1.Views.Monitoring
{
    partial class mMainContent
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBodyData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gauge3 = new MfgControl.AdvancedHMI.Controls.Gauge();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gauge2 = new MfgControl.AdvancedHMI.Controls.Gauge();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gauge1 = new MfgControl.AdvancedHMI.Controls.Gauge();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60938F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.39063F));
            this.tableLayoutPanel2.Controls.Add(this.pnlBodyData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1280, 620);
            this.tableLayoutPanel2.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gauge3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 413);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 206);
            this.panel4.TabIndex = 2;
            // 
            // gauge3
            // 
            this.gauge3.AllowDragging = false;
            this.gauge3.BackColor = System.Drawing.Color.Transparent;
            this.gauge3.Location = new System.Drawing.Point(9, 30);
            this.gauge3.Margin = new System.Windows.Forms.Padding(0);
            this.gauge3.Maximum = 2100;
            this.gauge3.Minimum = 0;
            this.gauge3.Name = "gauge3";
            this.gauge3.Size = new System.Drawing.Size(159, 159);
            this.gauge3.TabIndex = 0;
            this.gauge3.Value = 0D;
            this.gauge3.ValueScaleFactor = new decimal(new int[] {
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gauge2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 207);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 204);
            this.panel3.TabIndex = 1;
            // 
            // gauge2
            // 
            this.gauge2.AllowDragging = false;
            this.gauge2.BackColor = System.Drawing.Color.Transparent;
            this.gauge2.Location = new System.Drawing.Point(9, 30);
            this.gauge2.Margin = new System.Windows.Forms.Padding(0);
            this.gauge2.Maximum = 2100;
            this.gauge2.Minimum = 0;
            this.gauge2.Name = "gauge2";
            this.gauge2.Size = new System.Drawing.Size(159, 159);
            this.gauge2.TabIndex = 0;
            this.gauge2.Value = 0D;
            this.gauge2.ValueScaleFactor = new decimal(new int[] {
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
            // gauge1
            // 
            this.gauge1.AllowDragging = false;
            this.gauge1.BackColor = System.Drawing.Color.Transparent;
            this.gauge1.Location = new System.Drawing.Point(9, 30);
            this.gauge1.Margin = new System.Windows.Forms.Padding(0);
            this.gauge1.Maximum = 2100;
            this.gauge1.Minimum = 0;
            this.gauge1.Name = "gauge1";
            this.gauge1.Size = new System.Drawing.Size(159, 159);
            this.gauge1.TabIndex = 0;
            this.gauge1.Value = 1000D;
            this.gauge1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // mMainContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "mMainContent";
            this.Size = new System.Drawing.Size(1280, 620);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlBodyData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private MfgControl.AdvancedHMI.Controls.Gauge gauge3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private MfgControl.AdvancedHMI.Controls.Gauge gauge2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private MfgControl.AdvancedHMI.Controls.Gauge gauge1;
        private System.Windows.Forms.Label label2;
    }
}
