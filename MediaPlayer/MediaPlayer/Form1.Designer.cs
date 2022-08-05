
namespace MediaPlayer
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWaltz = new System.Windows.Forms.Button();
            this.btnIstanbul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEvgenyGrinko = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(392, 125);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(507, 182);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnWaltz
            // 
            this.btnWaltz.BackColor = System.Drawing.Color.Salmon;
            this.btnWaltz.Location = new System.Drawing.Point(12, 125);
            this.btnWaltz.Name = "btnWaltz";
            this.btnWaltz.Size = new System.Drawing.Size(366, 41);
            this.btnWaltz.TabIndex = 2;
            this.btnWaltz.Text = "Waltz No.2 - Dimitri Shostakovich";
            this.btnWaltz.UseVisualStyleBackColor = false;
            this.btnWaltz.Click += new System.EventHandler(this.btnOynat_Click);
            // 
            // btnIstanbul
            // 
            this.btnIstanbul.BackColor = System.Drawing.Color.Salmon;
            this.btnIstanbul.Location = new System.Drawing.Point(12, 172);
            this.btnIstanbul.Name = "btnIstanbul";
            this.btnIstanbul.Size = new System.Drawing.Size(366, 41);
            this.btnIstanbul.TabIndex = 4;
            this.btnIstanbul.Text = "Omar Faruk Tekbilek - I Love You (Istanbul)";
            this.btnIstanbul.UseVisualStyleBackColor = false;
            this.btnIstanbul.Click += new System.EventHandler(this.btnIstanbul_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(12, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Johannes Brahms - Hungarian Dance No. 5";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEvgenyGrinko
            // 
            this.btnEvgenyGrinko.BackColor = System.Drawing.Color.Salmon;
            this.btnEvgenyGrinko.Location = new System.Drawing.Point(12, 219);
            this.btnEvgenyGrinko.Name = "btnEvgenyGrinko";
            this.btnEvgenyGrinko.Size = new System.Drawing.Size(366, 41);
            this.btnEvgenyGrinko.TabIndex = 5;
            this.btnEvgenyGrinko.Text = "Evgeny Grinko - Once Upon A Time\r\n";
            this.btnEvgenyGrinko.UseVisualStyleBackColor = false;
            this.btnEvgenyGrinko.Click += new System.EventHandler(this.btnEvgenyGrinko_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(910, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvgenyGrinko);
            this.Controls.Add(this.btnIstanbul);
            this.Controls.Add(this.btnWaltz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MediaPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWaltz;
        private System.Windows.Forms.Button btnIstanbul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEvgenyGrinko;
    }
}

