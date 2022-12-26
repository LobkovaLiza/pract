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

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void windowinput(object sender, EventArgs e)
        {
            //поле ввода информации
        }

        private void windowoutput(object sender, EventArgs e)
        {//поле вывода информации
        }

        private void Encodingbutton(object sender, EventArgs e) //шифровка кнопка
        {
            string encoding = textBox1.Text;
            //byte[] buffer = Encoding.Default.GetBytes(encoding);
            //Console.WriteLine(BitConverter.ToString(buffer), buffer.Length);
            //string encodingresult = BitConverter.ToString(buffer, 0, buffer.Length);
            int step = 8;
            char[] code = new char[encoding.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = encoding[i];

                if (!Char.IsLetter(c))
                    code[i] = c;
                else if (Char.IsLower(c))
                    code[i] = (char)((c + step) % 32 + 'а');
                else
                    code[i] = (char)((c + step) % 32 + 'А');
            }
            string result = new string(code);
            textBox2.Text = result;
        }

        private void Decoding(object sender, EventArgs e) //дешифровка кнопка
        {
            //Encoding encoding = Encoding.ASCII;
            string decoding = textBox1.Text;
            ////byte decodingtobyte = Convert.ToByte(decoding);
            //byte[] decodingbytearray = decoding.ToByteArray(encoding);
            //string decodingresult = Encoding.UTF8.GetString(decodingbytearray);
            int step = 8;
            char[] code = new char[decoding.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = decoding[i];

                if (!Char.IsLetter(c))
                    code[i] = c;
                else if (Char.IsLower(c))
                    code[i] = (char)((c - step) % 32 + 'а');
                else
                    code[i] = (char)((c - step) % 32 + 'А');
            }
            string result = new string(code);
            textBox2.Text = result;
        }

    }
    public static class Extention
    {
        public static byte[] ToByteArray(this string decoding, Encoding encoding)
        {
            return encoding.GetBytes(decoding);
        }
    }
}
