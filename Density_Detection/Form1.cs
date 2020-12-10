using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Imaging;
using AForge;
using AForge.Imaging.Filters;

namespace Density_Detection
{
    public partial class Form1 : Form
    {
        int Gdefault = 120;
        float lowDefault = 5;
     
        public Form1()
        {
            InitializeComponent();
            txt_Gvalue.Text = Gdefault.ToString();

        }

        private void button_upload_Click(object sender, EventArgs e) //Find image
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image file (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.image_Original.Image = new Bitmap(ofile.FileName);
                string strfilename = ofile.FileName;
                lbl_fileName.Text = strfilename.ToString();
            }
            lbl_Coor.Visible = true;
            dataGridView1.Rows.Clear();
        }

        private void btn_bw_Click(object sender, EventArgs e)
        {
            image_Bw.Visible=false;
            float counterWhite = 0;
            float counterAll;
            float counterBlack;
            float density;
            float sum = 0;
            float counterWhite2 = 0;
            float counterAll2;
            float density2;
            float counterBlack2 =0;

            Bitmap b = new Bitmap((Bitmap)this.image_Original.Image);
            int[] vec = new int[b.Width * b.Height];
            int counterX = 0;
            // Set each pixel in myBitmap to black.
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    sum = sum + c1.G;
                    vec[counterX] = c1.G;
                    if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                        b.SetPixel(i, j, Color.Black);
                    else
                        counterWhite++;

                    counterX++;
                }
            }

            int[] vec2 = new int[Convert.ToInt16(txt_width.Text) * Convert.ToInt16(txt_height.Text)];
            int counterX2 = 0;
            // Set each pixel in myBitmap to black.
            int xEnd = Convert.ToInt16(txt_width.Text) + Convert.ToInt16(txt_xRect.Text);
            int yEnd = Convert.ToInt16(txt_height.Text) + Convert.ToInt16(txt_yRect.Text);
            for (int i = Convert.ToInt16(txt_xRect.Text); i < xEnd; i++)
            {
                for (int j = Convert.ToInt16(txt_yRect.Text); j < yEnd; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    sum = sum + c1.G;
                    vec2[counterX2] = c1.G;
                    if (c1.G < Convert.ToInt16(txt_Gvalue.Text))
                        //b.SetPixel(i, j, Color.Black);
                        counterBlack2++;
                    else
                        counterWhite2++;

                    counterX2++;
                }
            }

            counterAll = b.Width * b.Height;
            counterAll2 = Convert.ToInt16(txt_width.Text) * Convert.ToInt16(txt_height.Text);
            this.image_Bw.Image = b;
            //this.image_Adjust.Image = c;
            image_Bw.Visible = true;
            counterBlack = counterAll - counterWhite;
            density = counterWhite * 100 / counterAll;
            density2 = counterWhite2 * 100 / counterAll2;

            lbl_Density.Text = "Noise Area % =" + density.ToString("#.##") + " %";
            label_rect.Text = "Noise Area % (rect)=" + density2.ToString("#.##") + " %";
            //lbl_Average.Text = "Average G value =" + average.ToString("#.##");
        }

                
        private void image_Original_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Visible = true;

            if(btn_indi.Enabled == false && btn_areaAround.Enabled == true)
            {

                Graphics gB = image_Bw.CreateGraphics(); //drawing cross on click point
                Pen penB = new Pen(Color.White);
                gB.DrawLine(penB, e.X - 15, e.Y, e.X + 15, e.Y);
                gB.DrawLine(penB, e.X, e.Y - 15, e.X, e.Y + 15);
                gB.Dispose();

                Graphics gA = image_Original.CreateGraphics(); //drawing cross on click point
                Pen penA = new Pen(Color.White);
                gA.DrawLine(penA, e.X - 15, e.Y, e.X + 15, e.Y);
                gA.DrawLine(penA, e.X, e.Y - 15, e.X, e.Y + 15);
                gA.Dispose();

                Bitmap d = new Bitmap((Bitmap)this.image_Original.Image);
                Color d1 = d.GetPixel(e.X, e.Y);
                dataGridView1.Rows.Add(e.X, e.Y, d1.G);

                decimal val = 0;
                decimal average_G = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells[2] != null && item.Cells[2].Value != null)
                        val += Convert.ToDecimal(item.Cells[2].Value);
                }

                average_G = val / (Convert.ToDecimal(dataGridView1.RowCount) - 1);

                txt_Gvalue.Text = Convert.ToInt16(average_G).ToString();
            }

            if (btn_indi.Enabled == true && btn_areaAround.Enabled == false)
            {
                Rectangle rec = new Rectangle(e.X, e.Y, Convert.ToInt16(txt_width.Text), Convert.ToInt16(txt_height.Text));
                Graphics img_rectangle = image_Original.CreateGraphics();
                Pen redPen = new Pen(Color.Red, 3);
                img_rectangle.DrawRectangle(redPen, rec);
                txt_xRect.Text = Convert.ToString(e.X);
                txt_yRect.Text = Convert.ToString(e.Y);
            }

        }

        private void image_Original_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Coor.Text = "X = " + e.X + " ; Y = " + e.Y;
        }

        private void image_Bw_MouseClick(object sender, MouseEventArgs e)
        {
            //button1.Visible = true;

            //Graphics gC = image_Adjust.CreateGraphics(); //drawing cross on click point
            //Pen penC = new Pen(Color.White);
            //gC.DrawLine(penC, e.X - 15, e.Y, e.X + 15, e.Y);
            //gC.DrawLine(penC, e.X, e.Y - 15, e.X, e.Y + 15);
            //gC.Dispose();

            //Graphics gB = image_Bw.CreateGraphics(); //drawing cross on click point
            //Pen penB = new Pen(Color.White);
            //gB.DrawLine(penB, e.X - 15, e.Y, e.X + 15, e.Y);
            //gB.DrawLine(penB, e.X, e.Y - 15, e.X, e.Y + 15);
            //gB.Dispose();

            //Graphics gA = image_Original.CreateGraphics(); //drawing cross on click point
            //Pen penA = new Pen(Color.White);
            //gA.DrawLine(penA, e.X - 15, e.Y, e.X + 15, e.Y);
            //gA.DrawLine(penA, e.X, e.Y - 15, e.X, e.Y + 15);
            //gA.Dispose();
        }

        private void image_Bw_MouseMove(object sender, MouseEventArgs e) //show coordinates of the mouse
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            image_Bw.Invalidate();
            image_Original.Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            image_Bw.Invalidate();
            image_Original.Invalidate();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //txt_Gvalue.Text = null;
        }

        private void txt_Gvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_areaAround_Click(object sender, EventArgs e)
        {
            btn_indi.Enabled = true;
            btn_areaAround.Enabled = false;
        }

        private void btn_indi_Click(object sender, EventArgs e)
        {
            btn_indi.Enabled = false;
            btn_areaAround.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
