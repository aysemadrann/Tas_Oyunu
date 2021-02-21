using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp55
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            label1.Parent = pctrbx1; // burada labelların picturebox üzerinde kalmaları için bu işlemi gerçekleştirdik.
            label1.BringToFront();
            label1.Location = new Point(0, 0);

            label11.Parent = pctrbx2;
            label11.BringToFront();
            label11.Location = new Point(0, 0);

            label6.Parent = pctrbx3;
            label6.BringToFront();
            label6.Location = new Point(0, 0);

            label8.Parent = pctrbx4;
            label8.BringToFront();
            label8.Location = new Point(0, 0);

            label7.Parent = pctrbx5;
            label7.BringToFront();
            label7.Location = new Point(0, 0);

            label10.Parent = pctrbx6;
            label10.BringToFront();
            label10.Location = new Point(0, 0);

         
        }
        Point konum; //Taşları hareket ettirmek için ilk başta onların konumlarını ayarladık.
        Point konum2;
        Point konum3;
        Point konum4;
        Point konum5;
        Point konum6;
       

        void Form1_Load(object sender, EventArgs e)
        {
            Button[,] btn = new Button[9, 9];  // burada dinamik butonlardan oluşan dama tahtamızı oluşturduk.8 e 8 kareler olarak oluşturduk.
            int top = 0;
            int left = 0;
            for (int i = 0; i < btn.GetUpperBound(0); i++)
            {
                for(int j = 0; j < btn.GetUpperBound(1); j++)
                {
                    btn[i,j] = new Button(); //burada i j satırları olarak butonlarımızı olusturduk.
                    btn[i,j].Width = 60; //burada width ve height değerlerimizi verdik.
                    btn[i, j].Height = 60;
                    btn[i, j].Left = left;
                    btn[i, j].Top = top;
                    left += 60;
                    if ((i+j) % 2 == 0) //burada if koşulu kullanarak bazı butonlarımızı siyah bazılarını beyaz yaptık.
                    {
                        btn[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        btn[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(btn[i, j]);
                }
                top += 60;
                left = 0;

            }

            
        }

        


        private void pctrbx1_MouseDown(object sender, MouseEventArgs e) // mousedown özelliği ile drag drop olayımıza başladık.
        {
            konum = e.Location; // konumumuzu işaretledik.
        }

        private void pctrbx1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pctrbx1.Left += e.X - (konum.X); // x ve y konumlarımızı oluşturduk.
                pctrbx1.Top += e.Y - (konum.Y);
            }
        }

        private void pctrbx2_MouseDown(object sender, MouseEventArgs e)
        {
            konum2 = e.Location;      //mousemove ve mousedown işlemleriyle drag drop olayını gerçekleştirdik bütün taşlar için.
        }

        private void pctrbx2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pctrbx2.Left += e.X - (konum2.X);
                pctrbx2.Top += e.Y - (konum2.Y);
            }
        }

        private void pctrbx3_MouseDown(object sender, MouseEventArgs e)
        {
            konum3 = e.Location;
        }

        private void pctrbx3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pctrbx3.Left += e.X - (konum3.X);
                pctrbx3.Top += e.Y - (konum3.Y);
            }
        }

        private void pctrbx4_MouseDown(object sender, MouseEventArgs e)
        {
            konum4 = e.Location;
        }

        private void pctrbx4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pctrbx4.Left += e.X - (konum4.X);
                pctrbx4.Top += e.Y - (konum4.Y);
            }
        }

        private void pctrbx5_MouseDown(object sender, MouseEventArgs e)
        {
            konum5 = e.Location;
        }

        private void pctrbx5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pctrbx5.Left += e.X - (konum5.X);
                pctrbx5.Top += e.Y - (konum5.Y);
            }
        }

        private void pctrbx6_MouseDown(object sender, MouseEventArgs e)
        {
            konum6 = e.Location;
        }

        private void pctrbx6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pctrbx6.Left += e.X - (konum6.X);
                pctrbx6.Top += e.Y - (konum6.Y);
            }
        }

        private void btnust1_Click(object sender, EventArgs e)
        {
            pctrbx1.Top += -60;     //burada ise taşlarımızın sağa, sola, aşağı, yukarıya hareketini gerçekleştirdik.
        }

        private void btnsag1_Click(object sender, EventArgs e)
        {
            pctrbx1.Left += 60;
        }

        private void btnsol1_Click(object sender, EventArgs e)
        {
            pctrbx1.Left += -60;
        }

        private void btnalt1_Click(object sender, EventArgs e)
        {
            pctrbx1.Top += 60;
        }

        private void btnust2_Click_1(object sender, EventArgs e)
        {
            pctrbx2.Top += -60;
        }

        private void btnsag2_Click(object sender, EventArgs e)
        {
            pctrbx2.Left += 60;
        }

        private void btnsol2_Click(object sender, EventArgs e)
        {
            pctrbx2.Left += -60;
        }

        private void btnalt2_Click(object sender, EventArgs e)
        {
            pctrbx2.Top += 60;
        }

        private void btnust3_Click(object sender, EventArgs e)
        {
            pctrbx3.Top += -60;
        }

        private void btnsag3_Click(object sender, EventArgs e)
        {
            pctrbx3.Left += 60;
        }

        private void btnsol3_Click(object sender, EventArgs e)
        {
            pctrbx3.Left += -60;
        }

        private void btnalt3_Click(object sender, EventArgs e)
        {
            pctrbx3.Top += 60;
        }

        private void btnust4_Click(object sender, EventArgs e)
        {
            pctrbx4.Top += -60;
        }

        private void btnsag4_Click(object sender, EventArgs e)
        {
            pctrbx4.Left += 60;
        }

        private void btnsol4_Click(object sender, EventArgs e)
        {
            pctrbx4.Left += -60;
        }

        private void btnalt4_Click(object sender, EventArgs e)
        {
            pctrbx4.Top += 60;
        }

        private void btnust5_Click(object sender, EventArgs e)
        {
            pctrbx5.Top += -60;
        }

        private void btnsag5_Click(object sender, EventArgs e)
        {
            pctrbx5.Left += 60;
        }

        private void btnsol5_Click(object sender, EventArgs e)
        {
            pctrbx5.Left += -60;
        }

        private void btnalt5_Click(object sender, EventArgs e)
        {
            pctrbx5.Top += 60;
        }

        private void btnust6_Click(object sender, EventArgs e)
        {
            pctrbx6.Top += -60;
        }

        private void btnsag6_Click(object sender, EventArgs e)
        {
            pctrbx6.Left += 60;
        }

        private void btnsol6_Click(object sender, EventArgs e)
        {
            pctrbx6.Left += -60;
        }

        private void btnalt6_Click(object sender, EventArgs e)
        {
            pctrbx6.Top += 60;
        }

      

     

    }

  


}
