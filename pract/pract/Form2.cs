using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void write(object sender, EventArgs e) //ввод текста
        {

        }

        public void encodingbutton(object sender, EventArgs e) //шифровка
        {
            string text = windowinput.Text;
            int column = Convert.ToInt32(this.x.Text);
            int line = Convert.ToInt32(this.y.Text);
            int indexCounter = 0;
            char[,] array = new char[column, line];
            for (int columnwrite = 0; columnwrite < column; columnwrite++)
            {
                for (int linewrite = 0; linewrite < line; linewrite++)
                {
                    array[columnwrite, linewrite] = text[indexCounter];
                    indexCounter++;
                }
            }
            String encodingresult = ""; //результат зашифрованного слова (заполняется)
            for (int lineread = 0; lineread < line; lineread++)
            {
                for (int columnread = 0; columnread < column; columnread++)
                {
                    encodingresult += array[columnread, lineread];
                }
            }
            windowoutput.Text = encodingresult;
        }

        public void decodingbutton(object sender, EventArgs e) //дешифровка
        {
            string text = windowinput.Text;
            int x = Convert.ToInt32(this.x.Text);
            int y = Convert.ToInt32(this.y.Text);
            int indexCounter = 0;
            char[,] array = new char[x, y];
            for (int columnwrite = 0; columnwrite < x; columnwrite++)
            {
                for (int linewrite = 0; linewrite < y; linewrite++)
                {
                    array[columnwrite, linewrite] = text[indexCounter];
                    indexCounter++;
                }
            }
            String decodingresult = "";
            for (int lineread = 0; lineread < y; lineread++)
            {
                for (int columnread = 0; columnread < x; columnread++)
                {
                    decodingresult += array[columnread, lineread];
                }
            }
            windowoutput.Text = decodingresult;
        }

        public void read(object sender, EventArgs e) //чтение
        {

        }

        private void choose(object sender, EventArgs e)
        {

        }

        private void writex(object sender, EventArgs e) // column
        {

        }

        private void writey(object sender, EventArgs e) // line
        {

        }
    }
}
