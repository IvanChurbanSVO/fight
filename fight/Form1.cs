namespace fight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap image = Resource1.������;
            pictureBox2.Image = image;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap zondri = Resource1.������;
            e.Graphics.DrawImage(zondri, 0, 0);
        }
    }
}
