using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace VoidRef_Gez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }

        bool isPressed = false;
        int globalXOffset = 0;
        int globalYOffset = 0;

        private void moveImageUni(PictureBox tempPB)
        {
            Point tempPoint = PointToClient(Cursor.Position);
            tempPoint.X -= globalXOffset;
            tempPoint.Y -= globalYOffset;
            tempPB.Location = tempPoint;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox clickedPB = (PictureBox)sender;
            moveImageUni(clickedPB);
        }


        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox clickedPB = (PictureBox)sender;
            Point tempPoint = PointToClient(Cursor.Position);
            globalXOffset = tempPoint.X -= clickedPB.Location.X;
            globalYOffset = tempPoint.Y -= clickedPB.Location.Y;

            isPressed = true;

            if (deleteCB.Checked == true)
            {
                Controls.Remove(clickedPB);
                System.GC.Collect();
            }

            if (enlargeCB.Checked == true)
            {
                double enlargeVal = Convert.ToDouble(textBox1.Text);
                clickedPB.Height = Convert.ToInt32(clickedPB.Height * enlargeVal);
                clickedPB.Width = Convert.ToInt32(clickedPB.Width * enlargeVal);
            }

            if (reduceCB.Checked == true)
            {
                double reduceVal = Convert.ToDouble(textBox2.Text);
                clickedPB.Height = Convert.ToInt32(clickedPB.Height / reduceVal);
                clickedPB.Width = Convert.ToInt32(clickedPB.Width / reduceVal);
            }
        }


        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed == true)
            {
                PictureBox clickedPB = (PictureBox)sender;
                moveImageUni(clickedPB);
            }
        }


        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    int tempIndex = 0;
                    foreach (string element in fileNames)
                        try
                        {

                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Location = PointToClient(Cursor.Position),
                                Image = Image.FromFile(fileNames[tempIndex]),
                                Size = Image.FromFile(fileNames[tempIndex]).Size,
                                SizeMode = PictureBoxSizeMode.Zoom,
                            };

                            if (normalizeCB.Checked == true)
                            {
                                if (picture.Height > Convert.ToInt32(normalizeTB.Text))
                                {
                                    double diffCoeff = (Convert.ToDouble(normalizeTB.Text) / picture.Height);
                                    picture.Height = Convert.ToInt32(picture.Height * diffCoeff);
                                    picture.Width = Convert.ToInt32(picture.Width * diffCoeff);
                                }
                            }

                            this.Controls.Add(picture);

                            picture.MouseDown += new MouseEventHandler(pb_MouseDown);
                            picture.MouseUp += new MouseEventHandler(pb_MouseUp);
                            picture.MouseMove += new MouseEventHandler(pb_MouseMove);
                            tempIndex++;

                        }
                        catch (System.OutOfMemoryException)
                        {
                            MessageBox.Show("Unsupported file format, or the image is too large.");
                            tempIndex++;
                        }


                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            reduceCB.Enabled = !reduceCB.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            enlargeCB.Enabled = !enlargeCB.Enabled;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
