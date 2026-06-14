namespace PacmanGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pacman = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pacman).BeginInit();
            SuspendLayout();
            // 
            // pacman
            // 
            pacman.Image = (Image)resources.GetObject("pacman.Image");
            pacman.Location = new Point(150, 134);
            pacman.Name = "pacman";
            pacman.Size = new Size(50, 50);
            pacman.SizeMode = PictureBoxSizeMode.StretchImage;
            pacman.TabIndex = 0;
            pacman.TabStop = false;
            pacman.WaitOnLoad = true;
            pacman.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 561);
            Controls.Add(pacman);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pacman).EndInit();
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pacman;
    }
}
