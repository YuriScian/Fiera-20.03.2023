using System.Runtime.ConstrainedExecution;

namespace Fiera_20._03._2023
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();

            foto.Filter = " yuri | *.jpg ; *.jpeg; *.bmp ; *.png";

            foto.ShowDialog();

            Bitmap bmp = new Bitmap(foto.FileName);

            Color destinazione;

            for (int y = 0; y < bmp.Height; y++)
            {
                for(int x = 0; x < bmp.Width; x++) 
                {
                    Color matteo = bmp.GetPixel(x, y);

                    destinazione = Color.FromArgb(255, (int)(matteo.R * trbRed.Value), (int)(matteo.G * trbGreen.Value), (int)(matteo.B * trbBlue.Value));


                    bmp.SetPixel(x, y, destinazione);
                }
            }

            float fatform = (float)bmp.Width / (float)pictureBox1.Width;
            float highform = (float)bmp.Height / (float)pictureBox1.Height;

            Bitmap bmp2 = new Bitmap( bmp , new Size ((int)(bmp.Width / fatform), (int)(bmp.Height / highform)));

            pictureBox1.Image = bmp2; 

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeColor(object sender, EventArgs e)
        {
            //pictureBox1.BackColor = Color.FromArgb( trbRed.Value, trbGreen.Value, trbBlue.Value );
        }
    }
}