namespace moving_picture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbDeath = new System.Windows.Forms.PictureBox();
            this.back_ground = new System.Windows.Forms.Panel();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.Enemy4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(394, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (2).png");
            this.imageList1.Images.SetKeyName(1, "86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (4).png");
            this.imageList1.Images.SetKeyName(2, "86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (6).png");
            this.imageList1.Images.SetKeyName(3, "86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (5).png");
            // 
            // pbDeath
            // 
            this.pbDeath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDeath.Image = global::moving_picture.Properties.Resources.kisspng_explosion_encapsulated_postscript_starburst_5ac086a5450535_3383501515225668212827;
            this.pbDeath.Location = new System.Drawing.Point(730, 50);
            this.pbDeath.Name = "pbDeath";
            this.pbDeath.Size = new System.Drawing.Size(67, 66);
            this.pbDeath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeath.TabIndex = 2;
            this.pbDeath.TabStop = false;
            this.pbDeath.Visible = false;
            // 
            // back_ground
            // 
            this.back_ground.BackColor = System.Drawing.Color.DarkGreen;
            this.back_ground.Location = new System.Drawing.Point(768, 23);
            this.back_ground.Name = "back_ground";
            this.back_ground.Padding = new System.Windows.Forms.Padding(1);
            this.back_ground.Size = new System.Drawing.Size(20, 21);
            this.back_ground.TabIndex = 3;
            this.back_ground.Paint += new System.Windows.Forms.PaintEventHandler(this.back_ground_Paint);
            // 
            // Enemy1
            // 
            this.Enemy1.Location = new System.Drawing.Point(12, 39);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(81, 77);
            this.Enemy1.TabIndex = 4;
            this.Enemy1.TabStop = false;
            this.Enemy1.Tag = "object";
            this.Enemy1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy1_MouseMove);
            // 
            // Enemy2
            // 
            this.Enemy2.Location = new System.Drawing.Point(12, 122);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(81, 77);
            this.Enemy2.TabIndex = 5;
            this.Enemy2.TabStop = false;
            this.Enemy2.Tag = "object";
            this.Enemy2.Click += new System.EventHandler(this.Enemy2_Click);
            this.Enemy2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy2_MouseMove_1);
            // 
            // Enemy3
            // 
            this.Enemy3.Location = new System.Drawing.Point(12, 216);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(81, 77);
            this.Enemy3.TabIndex = 6;
            this.Enemy3.TabStop = false;
            this.Enemy3.Tag = "object";
            this.Enemy3.Click += new System.EventHandler(this.Enemy3_Click);
            this.Enemy3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy3_MouseMove_1);
            // 
            // Enemy4
            // 
            this.Enemy4.Location = new System.Drawing.Point(10, 299);
            this.Enemy4.Name = "Enemy4";
            this.Enemy4.Size = new System.Drawing.Size(81, 77);
            this.Enemy4.TabIndex = 7;
            this.Enemy4.TabStop = false;
            this.Enemy4.Tag = "object";
            this.Enemy4.Click += new System.EventHandler(this.Enemy4_Click);
            this.Enemy4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy4_MouseMove_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enemy4);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.pbDeath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pbDeath;
        public System.Windows.Forms.Panel back_ground;
        public System.Windows.Forms.PictureBox Enemy1;
        public System.Windows.Forms.PictureBox Enemy2;
        public System.Windows.Forms.PictureBox Enemy3;
        public System.Windows.Forms.PictureBox Enemy4;
    }
}

