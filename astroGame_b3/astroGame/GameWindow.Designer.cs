namespace astroGame
{
    partial class GameWindow
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
            this.printTimer = new System.Windows.Forms.Timer(this.components);
            this.laserTimer = new System.Windows.Forms.Timer(this.components);
            this.meteorsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // printTimer
            // 
            this.printTimer.Interval = 16;
            this.printTimer.Tick += new System.EventHandler(this.printTimer_Tick);
            // 
            // laserTimer
            // 
            this.laserTimer.Interval = 3000;
            this.laserTimer.Tick += new System.EventHandler(this.laserTimer_Tick);
            // 
            // meteorsTimer
            // 
            this.meteorsTimer.Interval = 3000;
            this.meteorsTimer.Tick += new System.EventHandler(this.meteorsTimer_Tick);
            // 
            // GameWindow
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1373, 712);
            this.DoubleBuffered = true;
            this.Name = "GameWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Game);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer printTimer;
        private System.Windows.Forms.Timer laserTimer;
        private System.Windows.Forms.Timer meteorsTimer;
    }
}