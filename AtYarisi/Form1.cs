using WMPLib;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int kosus = 0;

        public Form1()
        {
            InitializeComponent();
            player.URL = "Sesler/tufek.mp3";
            player.controls.stop();
            player.settings.volume = 5;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ara Verdik !");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kosus++;
            at1.Left += rnd.Next(1, 10);
            at2.Left += rnd.Next(1, 10);
            at3.Left += rnd.Next(1, 10);

            PictureBox ondeki = at1;

            if (at2.Left > ondeki.Left)
                ondeki = at2;
            if (at3.Left > ondeki.Left)
                ondeki = at3;
            if (ondeki.Right > bitis.Left)
            {
                timer1.Stop();
            }
            if (kosus > 10)
            {
                lblSpiker.Text = ondeki.Tag + " nolu at yarýþý önde götürüyor ";
            }

            if (ondeki.Right > bitis.Left)
            {
                timer1.Stop();
                lblSpiker.Text = ondeki.Tag + " nolu at yarýþý kazandý";
                MessageBox.Show("Oyun Bitti.");
                YeniOyun();
            }

        }

        private void YeniOyun()
        {
            kosus = at1.Left = at2.Left = at3.Left = 0;
            btnBaslat.Show();
            lblSpiker.Text = "Atlar yarýþa hazýr...";
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblSpiker.Text = "ve yarýþ baþladý...";
            player.URL = "Sesler/tufek";
            btnBaslat.Hide();
        }

        private void lblSpiker_Click(object sender, EventArgs e)
        {

        }
    }
}
