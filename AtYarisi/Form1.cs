namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rand = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;
            int bitisuzakligi = label4.Left;
            int sayi = Convert.ToInt32(label6.Text);
            sayi++;
            label6.Text = sayi.ToString();


            pictureBox1.Left += rand.Next(5, 18);
            pictureBox2.Left += rand.Next(5, 18);
            pictureBox3.Left += rand.Next(5, 18);
            if(pictureBox1.Left>pictureBox2.Left +5 && pictureBox1.Left>pictureBox3.Left + 5)
            {
                label5.Text = "1 onde";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label5.Text = "2 onde";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label5.Text = "3 onde";
            }



            if (birinciatingenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numarali At Kazandi");
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numarali At Kazandi");
            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numarali At Kazandi");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }
    }
}