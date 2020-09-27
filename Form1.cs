using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;
using System.Globalization;
using System.Resources;
using VelcroPhysics.Collision.ContactSystem;
using VelcroPhysics.Dynamics;
using VelcroPhysics.Collision.Shapes;

namespace moving_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object tempsend;

        public int counter = 0;

        public Thread thread1, thread2;
        private Point location;

        public Point Locate {get => location; set => location = value;}

        private Point origin;

        public Point Origin { get => origin; set => origin = value; }


        public MouseEventArgs temp;

        public PictureBox enemyHit;
        public PictureBox Destroyed;

        public Point point;


        public bool exitLoop = false;

        public CollisionHandeler col;
       public Rectangle Plane;//our racket sprite


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            back_ground.Size = pictureBox1.Size;
            back_ground.Height = pictureBox1.Height + 4;
            back_ground.Width = pictureBox1.Width + 4;
            
            back_ground.Location = pictureBox1.Location;

            Enemy1.BackColor = Color.Red;
            Enemy2.BackColor = Color.Red;
            Enemy3.BackColor = Color.Red;
            Enemy4.BackColor = Color.Red;

            enemyHit = Enemy1;
            Destroyed = pbDeath;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            // y  =   pictureBox1.Location.Y;
            Move(tempsend, temp);

          


        }


        public void Move(object sender, MouseEventArgs e)
        {
            int x, y;

            x = e.X;
            y = e.Y;

          


            point = new Point(x, y);

            Point point1 = pictureBox1.Location;
            Point point2 = pictureBox1.Location;
            origin = pictureBox1.Location;


            thread1 = Thread.CurrentThread;
            getPoint(point);

        //    object rect1 = { xAxis:x, yAxisy, Width: 50, height: 50 }
        //var rect2 = { x: 20, y: 10, width: 10, height: 10 }

            Turn(point, point1);
            Thread.CurrentThread.Join(100);


          





            while (point1.X != point.X)
                {



                    if (point.X > point1.X)
                    {


                        Thread.Sleep(50);


                        point1.X++;

                        pictureBox1.Location = point1;
                        back_ground.Location = pictureBox1.Location;






                    }
                    else
                    {

                        X_left();
                        Thread.CurrentThread.Join(100);

                        point1.X--;
                        Thread.Sleep(50);
                        pictureBox1.Location = point1;

                        back_ground.Location = pictureBox1.Location;

                    }


                    if (point.X == point1.X)
                    {
                        MessageBox.Show(point.X + " " + point.Y);
                    }
                    else
                    {
                        col = new CollisionHandeler();

                        foreach (Control c in this.Controls)
                        {
                                if (c is PictureBox && (string)c.Tag == "object")
                                {
                                    if (pictureBox1.Bounds.IntersectsWith(c.Bounds))
                                    {
                                        counter++;
                                        Locate = c.Location;

                                        Destroyed.Location = Locate;

                                        col.EnemyHit = c;
                                    //point1.X = point.X;

                                        if (counter<2)
                                        {
                                            col.Victory_OR_Fail();
                                            counter++;
                                        }


                                        continue;


                                    }

                                }   
                        }
                    }

                     
                
                }


            while (point1.Y != point.Y)
            {

                col = new CollisionHandeler();
                col.Collision();

                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && (string)c.Tag == "object")
                    {
                        if (pictureBox1.Bounds.IntersectsWith(c.Bounds))
                        {
                            counter++;
                            Locate = c.Location;
                            col.EnemyHit = c;

                            pbDeath.Visible = true;
                            pbDeath.Location = Locate;
                            pbDeath.BringToFront();
                            c.Visible = false;
                            Enemy1.SendToBack();
                            //point1.Y = point.Y;

                            if (counter < 2)
                            {
                                col.Victory_OR_Fail();
                                counter++;
                            }
                            //MessageBox.Show(counter.ToString());

                            continue;
                        }
                    }
                }


                //  Thread.Sleep(50);

                if (point.Y > point1.Y)
                {
                   Y_UP();
                    Thread.CurrentThread.Join(100);
                    point1.Y++;
                    Thread.Sleep(50);
                    pictureBox1.Location = point1;
                    back_ground.Location = pictureBox1.Location;
                }
                else
                {
                   Y_Down();
                    Thread.CurrentThread.Join(100);
                    point1.Y--;
                    Thread.Sleep(50);
                    pictureBox1.Location = point1;
                    back_ground.Location = pictureBox1.Location;
                }

            }

            

          



            Thread.Sleep(3000);

            //=====================================================================================================================================
            //return trip


            while (point.X != point2.X)
            {

               

                if (point.X > point2.X)
                {
                    X_left();
                    Thread.CurrentThread.Join(100);
                    point.X--;
                    Thread.Sleep(50);
                    pictureBox1.Location = point;
                    back_ground.Location = pictureBox1.Location;
                }
                else
                {
                    X_Right();
                    Thread.CurrentThread.Join(100);

                    point.X++;
                    Thread.Sleep(50);
                    pictureBox1.Location = point;
                    back_ground.Location = pictureBox1.Location;
                }

                //col = new CollisionHandeler();
                //col.Collision();
            }

            while (point2.Y != point.Y)
            {

                //Thread.Sleep(50);

                if (point.Y > point2.Y)
                {
                    Y_Down();

                    Thread.CurrentThread.Join(100);
                    point.Y--;
                    //Thread.Sleep(50);
                    pictureBox1.Location = point;
                    back_ground.Location = pictureBox1.Location;
                }
                else
                {
                    Y_UP();

                    Thread.CurrentThread.Join(100);
                    point.Y++;
                   // Thread.Sleep(50);
                    pictureBox1.Location = point;
                    back_ground.Location = pictureBox1.Location;
                }


                //if (point.Y==pictureBox1.Location.Y)
                //{
                //    MessageBox.Show(point.X + " " + point.Y);
                //    break;
                //}



                //col = new CollisionHandeler();
                //col.Collision();
                Enemy1.Visible = true;
                Enemy2.Visible = true;
                Enemy3.Visible = true;
                Enemy4.Visible = true;


                Point statonariy = new Point();
                statonariy.X = 12;
                statonariy.Y = 39;



                Enemy1.Location = statonariy;

                statonariy = new Point(12, 122);
                Enemy2.Location = statonariy;

                statonariy = new Point(12, 216);
                Enemy3.Location = statonariy;

                statonariy = new Point(10, 299);

                Enemy4.Location = statonariy;

            }
        }


        public void X_left( ) 
        {
            // pictureBox1 = "D:\\Downloads\\86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (6).png";

            pictureBox1.Image = imageList1.Images[2];
            pictureBox1.Visible = true;

            thread2 = Thread.CurrentThread;

        }

        public void X_Right()
        {
            // pictureBox1 = "D:\\Downloads\\86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (6).png";
            //  Thread.CurrentThread.Start();
            
           pictureBox1.Image = imageList1.Images[1];
            pictureBox1.Visible = true;
            

        }

        public void Y_Down()
        {
            // pictureBox1 = "D:\\Downloads\\86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (6).png";

            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.Visible = true;
        }

        public void Y_UP()
        {
            // pictureBox1 = "D:\\Downloads\\86-865313_picture-transparent-stock-plane-big-image-png-airplane - Copy (6).png";

            pictureBox1.Image = imageList1.Images[3];
            pictureBox1.Visible = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();

            tempsend = sender;
            temp = e;


        }


        public void Turn(Point point,Point point1)
        {

            
            if (point.X > point1.X)
            {


                //var t = Task.Run(() => X_Right());
                //t.Wait();
                // Thread.CurrentThread.Suspend();

                // thread2.Start();
                // thread1.Suspend();


                Thread.Sleep(10);
                X_Right();

                //  Thread.CurrentThread.Resume();

            }
            else
            {
                X_left();
                Thread.Sleep(100);
            }
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        
        //    Pen myPen = new Pen(Color.Aqua, 2);
        //    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//for smoother graphics/shapes



        //    e.Graphics.DrawRectangle(myPen, getPoint(point).X, getPoint(point).Y, 30, 30);


          

        //    pnl1_Enemy1.Width = 31;
        //    pnl1_Enemy1.Height = 31;
        //    Enemy1.Width = pnl1_Enemy1.Width;
        //    Enemy1.Height = pnl1_Enemy1.Height;
        //    Enemy1.Location = pnl1_Enemy1.Location;
        //    Enemy1.BackColor = Color.Red;
            
        //}

       




            private Point getPoint(Point point) 
        {
            return point;

        }



        //private void pnl1_Enemy1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {

        //        Point newLoc = new Point(e.X + pnl1_Enemy1.Location.X, e.Y + pnl1_Enemy1.Location.Y);
        //        pnl1_Enemy1.Location = newLoc;

        //    }
        //}

        private void back_ground_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//for smoother graphics/shapes

            Plane = new Rectangle(120, 270, 60, 10);//sprite initialization


            // e.Graphics.DrawString("score: " + hitCount, DefaultFont, new SolidBrush(Color.Black), new Point(1, 1));

            Plane.Size = pictureBox1.Size;
            Plane.Location = pictureBox1.Location;
            Plane.Width = pictureBox1.Width + 1;
            Plane.Height = pictureBox1.Height + 1;
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), Plane);


            e.Graphics.DrawRectangle(myPen, pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width + 1, pictureBox1.Height + 1);
            //  pictureBox1.Visible = false;

        }

        private void Enemy1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy1.Location.X, e.Y + Enemy1.Location.Y);
                Enemy1.Location = newLoc;

            }
        }


        private void Enemy2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy2.Location.X, e.Y + Enemy2.Location.Y);
                Enemy2.Location = newLoc;

            }
        }


        private void Enemy3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy3.Location.X, e.Y + Enemy3.Location.Y);
                Enemy3.Location = newLoc;

            }
        }


        private void Enemy4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy4.Location.X, e.Y + Enemy4.Location.Y);
                Enemy4.Location = newLoc;

            }
        }

        private void Enemy2_Click(object sender, EventArgs e)
        {

        }

        private void Enemy3_Click(object sender, EventArgs e)
        {

        }

        private void Enemy4_Click(object sender, EventArgs e)
        {

        }

        //private void back_ground_MouseClick(object sender, MouseEventArgs e)
        //{
        //    timer1.Start();

        //    tempsend = sender;
        //    temp = e;
        //}

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }







       static public void Fail()
        {

            

            Form1 formvars = new Form1();

            formvars.Locate = formvars.pictureBox1.Location;

            MessageBox.Show("The plain has crashed", "Death Insued", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            formvars.pbDeath.Size = formvars.pictureBox1.Size;
            formvars.pbDeath.Location = formvars.Locate;
            formvars.pbDeath.Visible = true;
            formvars.pictureBox1.Visible = false;

        }

        private void Enemy2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy2.Location.X, e.Y + Enemy2.Location.Y);
                Enemy2.Location = newLoc;

            }
        }

        private void Enemy3_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy3.Location.X, e.Y + Enemy3.Location.Y);
                Enemy3.Location = newLoc;

            }
        }

        private void Enemy4_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point newLoc = new Point(e.X + Enemy4.Location.X, e.Y + Enemy4.Location.Y);
                Enemy4.Location = newLoc;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        static public void PlayerVictory()
        {
            MessageBox.Show("The enemy has been destroyed", "Death to the Enemy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //hitbox.pbDeath.Size = EnemyHit.Size;
            Form1 formvars = new Form1();

           

           


            //formvars.Destroyed.Location = formvars.Locate;
           

        }













    }
}