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
            this.btnCreateFin = new Wisej.Web.Button();
            this.txtName = new Wisej.Web.TextBox();
            this.finName = new Wisej.Web.Label();
            this.finDescription = new Wisej.Web.Label();
            this.txtDescription = new Wisej.Web.TextBox();
            this.finAmount = new Wisej.Web.Label();
            this.txtAmount = new Wisej.Web.TextBox();
            this.btnSave = new Wisej.Web.Button();
            this.gdvFinPaid = new Wisej.Web.DataGridView();
            this.dgvNotPaid = new Wisej.Web.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFinPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaid)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(17, 506);
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
            // btnCreateFin
            // 
            this.btnCreateFin.Location = new System.Drawing.Point(3, 533);
            this.btnCreateFin.Name = "btnCreateFin";
            this.btnCreateFin.Size = new System.Drawing.Size(100, 22);
            this.btnCreateFin.TabIndex = 5;
            this.btnCreateFin.Text = "Create Fin";
            this.btnCreateFin.Click += new System.EventHandler(this.btnCreateFin_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 561);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 30);
            this.txtName.TabIndex = 6;
            // 
            // finName
            // 
            this.finName.AutoSize = true;
            this.finName.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.finName.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.finName.Location = new System.Drawing.Point(3, 561);
            this.finName.Name = "finName";
            this.finName.Size = new System.Drawing.Size(53, 22);
            this.finName.TabIndex = 7;
            this.finName.Text = "Name:";
            // 
            // finDescription
            // 
            this.finDescription.AutoSize = true;
            this.finDescription.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.finDescription.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.finDescription.Location = new System.Drawing.Point(3, 599);
            this.finDescription.Name = "finDescription";
            this.finDescription.Size = new System.Drawing.Size(95, 22);
            this.finDescription.TabIndex = 9;
            this.finDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 597);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(116, 30);
            this.txtDescription.TabIndex = 8;
            // 
            // finAmount
            // 
            this.finAmount.AutoSize = true;
            this.finAmount.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.finAmount.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.finAmount.Location = new System.Drawing.Point(3, 639);
            this.finAmount.Name = "finAmount";
            this.finAmount.Size = new System.Drawing.Size(70, 22);
            this.finAmount.TabIndex = 11;
            this.finAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(104, 637);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(116, 30);
            this.txtAmount.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 685);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gdvFinPaid
            // 
            this.gdvFinPaid.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.gdvFinPaid.Location = new System.Drawing.Point(3, 288);
            this.gdvFinPaid.Name = "gdvFinPaid";
            this.gdvFinPaid.Size = new System.Drawing.Size(511, 212);
            this.gdvFinPaid.TabIndex = 3;
            // 
            // dgvNotPaid
            // 
            this.dgvNotPaid.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.dgvNotPaid.Location = new System.Drawing.Point(536, 288);
            this.dgvNotPaid.Name = "dgvNotPaid";
            this.dgvNotPaid.Size = new System.Drawing.Size(511, 212);
            this.dgvNotPaid.TabIndex = 4;
            // 
            // LayoutDesktop
            // 
            this.AutoHideTaskbar = true;
            this.Controls.Add(this.dgvNotPaid);
            this.Controls.Add(this.gdvFinPaid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.finAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.finDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.finName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreateFin);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gdvFin);
            this.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.Name = "LayoutDesktop";
            this.Size = new System.Drawing.Size(1643, 733);
            this.Wallpaper = "blank";
            this.Load += new System.EventHandler(this.LayoutDesktop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFinPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label label1;
        private Wisej.Web.DataGridView gdvFin;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label lblTotal;
        private Wisej.Web.Button btnCreateFin;
        private Wisej.Web.TextBox txtName;
        private Wisej.Web.Label finName;
        private Wisej.Web.Label finDescription;
        private Wisej.Web.TextBox txtDescription;
        private Wisej.Web.Label finAmount;
        private Wisej.Web.TextBox txtAmount;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.DataGridView gdvFinPaid;
        private Wisej.Web.DataGridView dgvNotPaid;
    }
}
