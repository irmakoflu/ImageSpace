using System.Drawing.Drawing2D;

namespace ImageSpace
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void importbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                string path = ofd.FileName;
                bitmap = new Bitmap(path);
                pictureBox2.Image = bitmap;
            }
        }

        private void exportbutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (DialogResult.OK == sfd.ShowDialog())
            {
                string path = sfd.FileName;
                bitmap.Save(path);
                MessageBox.Show("Resim kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void demonicbutton_Click(object sender, EventArgs e)
        {
            ApplyGradient(242, 0, 6, 40, 20, 50);
        }
        public void ApplyGradient(int R1, int G1, int B1, int R2, int G2, int B2)
        {

            Graphics graphics = Graphics.FromImage(bitmap);
            LinearGradientBrush linearGradient = new LinearGradientBrush(new Point(0, 0), new Point(bitmap.Width, 0), Color.FromArgb(50, R1, G1, B1), Color.FromArgb(50, R2, G2, B2));
            graphics.FillRectangle(linearGradient, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            pictureBox2.Image = bitmap;

        }

        private void freezingbutton_Click(object sender, EventArgs e)
        {
            ApplyGradient(0,128,192,14,18,177);
        }

        private void futuristicbutton_Click(object sender, EventArgs e)
        {
            ApplyGradient(164,28,116,158,0,191);
        }

        private void holybutton_Click(object sender, EventArgs e)
        {
            ApplyGradient(241,189,201,255,255,0);
        }

        private void naturalbutton_Click(object sender, EventArgs e)
        {
            ApplyGradient(0,255,0,0,64,0);
        }

        private void sunbutton_Click(object sender, EventArgs e)
        {
            ApplyGradient(255,255,128,255,255,0);
        }
    }
}
