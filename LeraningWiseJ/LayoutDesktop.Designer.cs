namespace LeraningWiseJ
{
    partial class LayoutDesktop
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

        #region Wisej.NET Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.gdvFin = new Wisej.Web.DataGridView();
            this.label2 = new Wisej.Web.Label();
            this.lblTotal = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromName("@tabText");
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "FakeTrello!";
            // 
            // gdvFin
            // 
            this.gdvFin.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gdvFin.Location = new System.Drawing.Point(0, 50);
            this.gdvFin.Name = "gdvFin";
            this.gdvFin.Size = new System.Drawing.Size(1643, 233);
            this.gdvFin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.label2.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(20, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(73, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label3";
            // 
            // LayoutDesktop
            // 
            this.AutoHideTaskbar = true;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gdvFin);
            this.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.Name = "LayoutDesktop";
            this.Size = new System.Drawing.Size(1643, 766);
            this.Wallpaper = "blank";
            this.Load += new System.EventHandler(this.LayoutDesktop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label label1;
        private Wisej.Web.DataGridView gdvFin;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label lblTotal;
    }
}
