namespace astroGame
{
    partial class menuWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.recordsButtons = new System.Windows.Forms.Button();
            this.garageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameGamer = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(551, 61);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(328, 153);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "ИГРАТЬ";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoButton.Location = new System.Drawing.Point(551, 271);
            this.infoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(328, 157);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "ИНФОРМАЦИЯ";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // recordsButtons
            // 
            this.recordsButtons.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recordsButtons.Location = new System.Drawing.Point(553, 481);
            this.recordsButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recordsButtons.Name = "recordsButtons";
            this.recordsButtons.Size = new System.Drawing.Size(326, 151);
            this.recordsButtons.TabIndex = 2;
            this.recordsButtons.Text = "РЕКОРДЫ";
            this.recordsButtons.UseVisualStyleBackColor = true;
            this.recordsButtons.Click += new System.EventHandler(this.recordsButtons_Click);
            // 
            // garageButton
            // 
            this.garageButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.garageButton.Location = new System.Drawing.Point(71, 297);
            this.garageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.garageButton.Name = "garageButton";
            this.garageButton.Size = new System.Drawing.Size(314, 105);
            this.garageButton.TabIndex = 3;
            this.garageButton.Text = "КОРАБЛЬ";
            this.garageButton.UseVisualStyleBackColor = true;
            this.garageButton.Click += new System.EventHandler(this.garageButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1160, 759);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(241, 84);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "ВЫХОД";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameGamer
            // 
            this.nameGamer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameGamer.Location = new System.Drawing.Point(1097, 271);
            this.nameGamer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameGamer.Mask = "AAAAAAAAAAAAAAA";
            this.nameGamer.Name = "nameGamer";
            this.nameGamer.Size = new System.Drawing.Size(243, 52);
            this.nameGamer.TabIndex = 5;
            this.nameGamer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameGamer.TextChanged += new System.EventHandler(this.nameGamer_TextChanged);
            // 
            // menuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.nameGamer);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.garageButton);
            this.Controls.Add(this.recordsButtons);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "menuWindow";
            this.Text = "SPACE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuWindow_FormClosed);
            this.Load += new System.EventHandler(this.menuWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button playButton;
        private Button infoButton;
        private Button recordsButtons;
        private Button garageButton;
        private Button exitButton;
        private MaskedTextBox nameGamer;
    }
}