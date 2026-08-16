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
            this.navBar = new Wisej.Web.ToolBar();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromName("@tabText");
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1643, 32);
            this.navBar.TabIndex = 0;
            this.navBar.TabStop = false;
            // 
            // LayoutDesktop
            // 
            this.AutoHideTaskbar = true;
            this.Controls.Add(this.navBar);
            this.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.Name = "LayoutDesktop";
            this.Size = new System.Drawing.Size(1643, 727);
            this.Wallpaper = "blank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.ToolBar navBar;
    }
}
