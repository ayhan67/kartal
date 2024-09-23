namespace Fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int toplamaYapveGoster(int sayi5, int sayi2)
        {
            int toplam = sayi5 + sayi2;
            return toplam;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi5 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int top = toplamaYapveGoster(sayi5, sayi2);
            label1.Text = top.ToString();
        }
    }
}
