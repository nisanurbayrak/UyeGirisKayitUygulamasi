
namespace uyeGirisUyg
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
            this.girisbtn = new System.Windows.Forms.Button();
            this.sfrelbl = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.nicklbl = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // girisbtn
            // 
            this.girisbtn.BackColor = System.Drawing.Color.Orange;
            this.girisbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.girisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girisbtn.Location = new System.Drawing.Point(129, 253);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(100, 33);
            this.girisbtn.TabIndex = 2;
            this.girisbtn.Text = "giriş yap";
            this.girisbtn.UseVisualStyleBackColor = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // sfrelbl
            // 
            this.sfrelbl.AutoSize = true;
            this.sfrelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrelbl.Location = new System.Drawing.Point(25, 199);
            this.sfrelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sfrelbl.Name = "sfrelbl";
            this.sfrelbl.Size = new System.Drawing.Size(41, 21);
            this.sfrelbl.TabIndex = 1;
            this.sfrelbl.Text = "şifre";
            this.sfrelbl.Click += new System.EventHandler(this.sfrelbl_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxSifre.Location = new System.Drawing.Point(29, 223);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(199, 27);
            this.textBoxSifre.TabIndex = 1;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            this.textBoxSifre.Enter += new System.EventHandler(this.textBoxNick_Enter);
            this.textBoxSifre.Leave += new System.EventHandler(this.textBoxNick_Leave);
            // 
            // nicklbl
            // 
            this.nicklbl.AutoSize = true;
            this.nicklbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicklbl.Location = new System.Drawing.Point(25, 148);
            this.nicklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nicklbl.Name = "nicklbl";
            this.nicklbl.Size = new System.Drawing.Size(106, 21);
            this.nicklbl.TabIndex = 1;
            this.nicklbl.Text = "kullanıcı adı";
            this.nicklbl.Click += new System.EventHandler(this.nicklbl_Click);
            // 
            // textBoxNick
            // 
            this.textBoxNick.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxNick.Location = new System.Drawing.Point(29, 172);
            this.textBoxNick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(199, 27);
            this.textBoxNick.TabIndex = 0;
            this.textBoxNick.TextChanged += new System.EventHandler(this.textBoxNick_TextChanged);
            this.textBoxNick.Enter += new System.EventHandler(this.textBoxNick_Enter);
            this.textBoxNick.Leave += new System.EventHandler(this.textBoxNick_Leave);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(25, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "hesabın yok mu? üye ol.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uyeGirisUyg.Properties.Resources._613927;
            this.pictureBox1.Location = new System.Drawing.Point(15, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(257, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.nicklbl);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.sfrelbl);
            this.Controls.Add(this.girisbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label sfrelbl;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nicklbl;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Button button1;
    }
}

