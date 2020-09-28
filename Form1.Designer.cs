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
            this.Jet1 = new System.Windows.Forms.PictureBox();
            this.Jet2 = new System.Windows.Forms.PictureBox();
            this.Jet3 = new System.Windows.Forms.PictureBox();
            this.GBXFriendly = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy4 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.PGBFuel = new System.Windows.Forms.ProgressBar();
            this.GBXStatus = new System.Windows.Forms.GroupBox();
            this.lblSpeedDis = new System.Windows.Forms.Label();
            this.lblVelocityDis = new System.Windows.Forms.Label();
            this.LblAltDisplay = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PBXArmory = new System.Windows.Forms.PictureBox();
            this.PBCOfficersQuaters = new System.Windows.Forms.PictureBox();
            this.PBXMessHall = new System.Windows.Forms.PictureBox();
            this.PBXTankDepo = new System.Windows.Forms.PictureBox();
            this.PBXBarracks = new System.Windows.Forms.PictureBox();
            this.PBXHospital = new System.Windows.Forms.PictureBox();
            this.PBXStorage = new System.Windows.Forms.PictureBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.PBXPlaneIA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet3)).BeginInit();
            this.GBXFriendly.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            this.GBXStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXArmory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCOfficersQuaters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXMessHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXTankDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXBarracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPlaneIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(1099, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 45);
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
            this.pbDeath.Location = new System.Drawing.Point(1050, 39);
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
            this.back_ground.Location = new System.Drawing.Point(1094, 12);
            this.back_ground.Name = "back_ground";
            this.back_ground.Padding = new System.Windows.Forms.Padding(1);
            this.back_ground.Size = new System.Drawing.Size(20, 21);
            this.back_ground.TabIndex = 3;
            this.back_ground.Paint += new System.Windows.Forms.PaintEventHandler(this.back_ground_Paint);
            // 
            // Jet1
            // 
            this.Jet1.Location = new System.Drawing.Point(16, 27);
            this.Jet1.Name = "Jet1";
            this.Jet1.Size = new System.Drawing.Size(81, 77);
            this.Jet1.TabIndex = 4;
            this.Jet1.TabStop = false;
            this.Jet1.Tag = "object";
            this.Jet1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy1_MouseMove);
            // 
            // Jet2
            // 
            this.Jet2.Location = new System.Drawing.Point(16, 110);
            this.Jet2.Name = "Jet2";
            this.Jet2.Size = new System.Drawing.Size(81, 77);
            this.Jet2.TabIndex = 5;
            this.Jet2.TabStop = false;
            this.Jet2.Tag = "object";
            this.Jet2.Click += new System.EventHandler(this.Enemy2_Click);
            this.Jet2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy2_MouseMove_1);
            // 
            // Jet3
            // 
            this.Jet3.Location = new System.Drawing.Point(16, 193);
            this.Jet3.Name = "Jet3";
            this.Jet3.Size = new System.Drawing.Size(81, 77);
            this.Jet3.TabIndex = 6;
            this.Jet3.TabStop = false;
            this.Jet3.Tag = "object";
            this.Jet3.Click += new System.EventHandler(this.Enemy3_Click);
            this.Jet3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Enemy3_MouseMove_1);
            // 
            // GBXFriendly
            // 
            this.GBXFriendly.Controls.Add(this.Jet1);
            this.GBXFriendly.Controls.Add(this.Jet2);
            this.GBXFriendly.Controls.Add(this.Jet3);
            this.GBXFriendly.Location = new System.Drawing.Point(1148, 12);
            this.GBXFriendly.Name = "GBXFriendly";
            this.GBXFriendly.Size = new System.Drawing.Size(112, 280);
            this.GBXFriendly.TabIndex = 9;
            this.GBXFriendly.TabStop = false;
            this.GBXFriendly.Text = "Friendly Jet Selection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Enemy1);
            this.groupBox1.Controls.Add(this.Enemy4);
            this.groupBox1.Controls.Add(this.Enemy2);
            this.groupBox1.Controls.Add(this.Enemy3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 369);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enemy selection";
            // 
            // Enemy1
            // 
            this.Enemy1.Location = new System.Drawing.Point(16, 27);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(81, 77);
            this.Enemy1.TabIndex = 4;
            this.Enemy1.TabStop = false;
            this.Enemy1.Tag = "object";
            // 
            // Enemy4
            // 
            this.Enemy4.Location = new System.Drawing.Point(16, 276);
            this.Enemy4.Name = "Enemy4";
            this.Enemy4.Size = new System.Drawing.Size(81, 77);
            this.Enemy4.TabIndex = 7;
            this.Enemy4.TabStop = false;
            this.Enemy4.Tag = "object";
            // 
            // Enemy2
            // 
            this.Enemy2.Location = new System.Drawing.Point(16, 110);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(81, 77);
            this.Enemy2.TabIndex = 5;
            this.Enemy2.TabStop = false;
            this.Enemy2.Tag = "object";
            // 
            // Enemy3
            // 
            this.Enemy3.Location = new System.Drawing.Point(16, 193);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(81, 77);
            this.Enemy3.TabIndex = 6;
            this.Enemy3.TabStop = false;
            this.Enemy3.Tag = "object";
            // 
            // PGBFuel
            // 
            this.PGBFuel.Location = new System.Drawing.Point(1123, 39);
            this.PGBFuel.Name = "PGBFuel";
            this.PGBFuel.Size = new System.Drawing.Size(19, 310);
            this.PGBFuel.TabIndex = 11;
            // 
            // GBXStatus
            // 
            this.GBXStatus.Controls.Add(this.lblAlt);
            this.GBXStatus.Controls.Add(this.lblVelocity);
            this.GBXStatus.Controls.Add(this.lblSpeed);
            this.GBXStatus.Controls.Add(this.LblAltDisplay);
            this.GBXStatus.Controls.Add(this.lblVelocityDis);
            this.GBXStatus.Controls.Add(this.lblSpeedDis);
            this.GBXStatus.Location = new System.Drawing.Point(1148, 298);
            this.GBXStatus.Name = "GBXStatus";
            this.GBXStatus.Size = new System.Drawing.Size(112, 103);
            this.GBXStatus.TabIndex = 12;
            this.GBXStatus.TabStop = false;
            this.GBXStatus.Text = "Status";
            // 
            // lblSpeedDis
            // 
            this.lblSpeedDis.AutoSize = true;
            this.lblSpeedDis.Location = new System.Drawing.Point(6, 16);
            this.lblSpeedDis.Name = "lblSpeedDis";
            this.lblSpeedDis.Size = new System.Drawing.Size(38, 13);
            this.lblSpeedDis.TabIndex = 0;
            this.lblSpeedDis.Text = "Speed";
            // 
            // lblVelocityDis
            // 
            this.lblVelocityDis.AutoSize = true;
            this.lblVelocityDis.Location = new System.Drawing.Point(6, 38);
            this.lblVelocityDis.Name = "lblVelocityDis";
            this.lblVelocityDis.Size = new System.Drawing.Size(44, 13);
            this.lblVelocityDis.TabIndex = 1;
            this.lblVelocityDis.Text = "Velocity";
            // 
            // LblAltDisplay
            // 
            this.LblAltDisplay.AutoSize = true;
            this.LblAltDisplay.Location = new System.Drawing.Point(6, 70);
            this.LblAltDisplay.Name = "LblAltDisplay";
            this.LblAltDisplay.Size = new System.Drawing.Size(45, 13);
            this.LblAltDisplay.TabIndex = 2;
            this.LblAltDisplay.Text = "Altitude:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(71, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "0";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(71, 38);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(13, 13);
            this.lblVelocity.TabIndex = 4;
            this.lblVelocity.Text = "0";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(71, 70);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(13, 13);
            this.lblAlt.TabIndex = 5;
            this.lblAlt.Text = "0";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(1120, 20);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(27, 13);
            this.lblFuel.TabIndex = 13;
            this.lblFuel.Text = "Fuel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(135, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(958, 381);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // PBXArmory
            // 
            this.PBXArmory.BackColor = System.Drawing.SystemColors.Info;
            this.PBXArmory.Location = new System.Drawing.Point(141, 30);
            this.PBXArmory.Name = "PBXArmory";
            this.PBXArmory.Size = new System.Drawing.Size(66, 48);
            this.PBXArmory.TabIndex = 15;
            this.PBXArmory.TabStop = false;
            // 
            // PBCOfficersQuaters
            // 
            this.PBCOfficersQuaters.BackColor = System.Drawing.SystemColors.Info;
            this.PBCOfficersQuaters.Location = new System.Drawing.Point(213, 30);
            this.PBCOfficersQuaters.Name = "PBCOfficersQuaters";
            this.PBCOfficersQuaters.Size = new System.Drawing.Size(66, 48);
            this.PBCOfficersQuaters.TabIndex = 16;
            this.PBCOfficersQuaters.TabStop = false;
            // 
            // PBXMessHall
            // 
            this.PBXMessHall.BackColor = System.Drawing.SystemColors.Info;
            this.PBXMessHall.Location = new System.Drawing.Point(213, 122);
            this.PBXMessHall.Name = "PBXMessHall";
            this.PBXMessHall.Size = new System.Drawing.Size(66, 48);
            this.PBXMessHall.TabIndex = 17;
            this.PBXMessHall.TabStop = false;
            // 
            // PBXTankDepo
            // 
            this.PBXTankDepo.BackColor = System.Drawing.SystemColors.Info;
            this.PBXTankDepo.Location = new System.Drawing.Point(141, 205);
            this.PBXTankDepo.Name = "PBXTankDepo";
            this.PBXTankDepo.Size = new System.Drawing.Size(66, 48);
            this.PBXTankDepo.TabIndex = 18;
            this.PBXTankDepo.TabStop = false;
            // 
            // PBXBarracks
            // 
            this.PBXBarracks.BackColor = System.Drawing.SystemColors.Info;
            this.PBXBarracks.Location = new System.Drawing.Point(322, 122);
            this.PBXBarracks.Name = "PBXBarracks";
            this.PBXBarracks.Size = new System.Drawing.Size(66, 48);
            this.PBXBarracks.TabIndex = 19;
            this.PBXBarracks.TabStop = false;
            // 
            // PBXHospital
            // 
            this.PBXHospital.BackColor = System.Drawing.SystemColors.Info;
            this.PBXHospital.Location = new System.Drawing.Point(213, 205);
            this.PBXHospital.Name = "PBXHospital";
            this.PBXHospital.Size = new System.Drawing.Size(66, 48);
            this.PBXHospital.TabIndex = 20;
            this.PBXHospital.TabStop = false;
            // 
            // PBXStorage
            // 
            this.PBXStorage.BackColor = System.Drawing.SystemColors.Info;
            this.PBXStorage.Location = new System.Drawing.Point(141, 122);
            this.PBXStorage.Name = "PBXStorage";
            this.PBXStorage.Size = new System.Drawing.Size(66, 48);
            this.PBXStorage.TabIndex = 21;
            this.PBXStorage.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 387);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(112, 23);
            this.btnEnd.TabIndex = 23;
            this.btnEnd.Text = "End Simulation";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // PBXPlaneIA
            // 
            this.PBXPlaneIA.BackColor = System.Drawing.SystemColors.Menu;
            this.PBXPlaneIA.Location = new System.Drawing.Point(1033, 125);
            this.PBXPlaneIA.Name = "PBXPlaneIA";
            this.PBXPlaneIA.Size = new System.Drawing.Size(43, 45);
            this.PBXPlaneIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXPlaneIA.TabIndex = 24;
            this.PBXPlaneIA.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 413);
            this.Controls.Add(this.PBXPlaneIA);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.PBXStorage);
            this.Controls.Add(this.PBXHospital);
            this.Controls.Add(this.PBXBarracks);
            this.Controls.Add(this.PBXTankDepo);
            this.Controls.Add(this.PBXMessHall);
            this.Controls.Add(this.PBCOfficersQuaters);
            this.Controls.Add(this.PBXArmory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.GBXStatus);
            this.Controls.Add(this.PGBFuel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBXFriendly);
            this.Controls.Add(this.pbDeath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet3)).EndInit();
            this.GBXFriendly.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            this.GBXStatus.ResumeLayout(false);
            this.GBXStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXArmory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCOfficersQuaters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXMessHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXTankDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXBarracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPlaneIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pbDeath;
        public System.Windows.Forms.Panel back_ground;
        public System.Windows.Forms.PictureBox Jet1;
        public System.Windows.Forms.PictureBox Jet2;
        public System.Windows.Forms.PictureBox Jet3;
        private System.Windows.Forms.GroupBox GBXFriendly;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox Enemy1;
        public System.Windows.Forms.PictureBox Enemy4;
        public System.Windows.Forms.PictureBox Enemy2;
        public System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.ProgressBar PGBFuel;
        private System.Windows.Forms.GroupBox GBXStatus;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label LblAltDisplay;
        private System.Windows.Forms.Label lblVelocityDis;
        private System.Windows.Forms.Label lblSpeedDis;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PBXArmory;
        private System.Windows.Forms.PictureBox PBCOfficersQuaters;
        private System.Windows.Forms.PictureBox PBXMessHall;
        private System.Windows.Forms.PictureBox PBXTankDepo;
        private System.Windows.Forms.PictureBox PBXBarracks;
        private System.Windows.Forms.PictureBox PBXHospital;
        private System.Windows.Forms.PictureBox PBXStorage;
        private System.Windows.Forms.Button btnEnd;
        public System.Windows.Forms.PictureBox PBXPlaneIA;
    }
}

