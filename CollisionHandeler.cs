using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moving_picture
{
   public class CollisionHandeler: Form1
    {

        public Form1 hitbox;
        public Control EnemyHit;

        public void Collision()
        {
            Random r = new Random(2);

            //======================================================================================================================================
            //===================
            //  Fixture fixtureA;
            //===================

            // ShapeType box = (ShapeType)(-1);
            //int x = r.Next(0, 800 - pictureBox1.Width);
            //int y = r.Next(0, 500 - pictureBox1.Width);
            //pictureBox1.Top = y;
            //pictureBox1.Left = x;

            //if ((pnl1_Enemy1.Bounds.IntersectsWith(pictureBox1.Bounds))||(pictureBox1.Location.Y==pnl1_Enemy1.Location.Y-pnl1_Enemy1.Height))
            //{
            // MessageBox.Show("hi");
            //===================================================================================================================================



            Rectangle Enemy;//our ball sprite


            Enemy = new Rectangle(140, 10, 20, 20);

            Plane.Size = back_ground.Size;
            Plane.Location = back_ground.Location;




            Enemy.Size = Jet1.Size;
                Enemy.X = Jet1.Location.X;
                Enemy.Y = Jet1.Location.Y;

            //===================================================================================
            //if (Plane.Right > pictureBox1.Right) { Plane.X = pictureBox1.Right - Plane.Width; }
            //  Refresh();
            //===================================================================================

            //}
        }

        public void Victory_OR_Fail() 
        {

            MessageBox.Show("hi");
            Random random = new Random(2);
            int val = 0;

           val= random.Next(0,2);

            if (val==0)
            {
                Fail();
            }
            else
            {
                PlayerVictory();
            }

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollisionHandeler));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1054, 335);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbDeath
            // 
            this.pbDeath.Location = new System.Drawing.Point(1030, 12);
            // 
            // back_ground
            // 
            this.back_ground.Location = new System.Drawing.Point(1051, 386);
            this.back_ground.Size = new System.Drawing.Size(46, 52);
            // 
            // Jet1
            // 
            this.Jet1.BackColor = System.Drawing.Color.Red;
            this.Jet1.Click += new System.EventHandler(this.Enemy1_Click);
            // 
            // Jet2
            // 
            this.Jet2.BackColor = System.Drawing.Color.Red;
            // 
            // Jet3
            // 
            this.Jet3.BackColor = System.Drawing.Color.Red;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Crimson;
            // 
            // Enemy4
            // 
            this.Enemy4.BackColor = System.Drawing.Color.Crimson;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Crimson;
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Crimson;
            // 
            // CollisionHandeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1268, 429);
            this.Name = "CollisionHandeler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Enemy1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
