namespace pract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //способ таблицы
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e) //спсоб Цезаря
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e) //способ Многоалфавитной замены
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }
    }
}