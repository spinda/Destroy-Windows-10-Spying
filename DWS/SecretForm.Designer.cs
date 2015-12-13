namespace DWS_Lite
{
    partial class SecretForm
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
            this.components = new System.ComponentModel.Container();
            this.GraphicsTimer = new System.Windows.Forms.Timer(this.components);
            this.Titres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GraphicsTimer
            // 
            this.GraphicsTimer.Enabled = true;
            this.GraphicsTimer.Tick += new System.EventHandler(this.GraphicsTimer_Tick);
            // 
            // Titres
            // 
            this.Titres.BackColor = System.Drawing.Color.Transparent;
            this.Titres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Titres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titres.Location = new System.Drawing.Point(0, 0);
            this.Titres.Name = "Titres";
            this.Titres.Size = new System.Drawing.Size(816, 493);
            this.Titres.TabIndex = 0;
            this.Titres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownExit);
            // 
            // SecretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DWS_Lite.Properties.Resources.BGProgImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.ControlBox = false;
            this.Controls.Add(this.Titres);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "SecretForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret :D";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownExit);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GraphicsTimer;
        private System.Windows.Forms.Label Titres;
    }
}