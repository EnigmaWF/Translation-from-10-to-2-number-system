using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translation_from_10_to_2_number_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string f(string s, int n)
        {

            if (n == 0)
            {
                return (s + "0");
            }
            else if (n < 2 && n != 0) //число делится на 2 до тех пор, пока не станет <2
            {
                return (s + "1");
            }
            else
            {
                s += n % 2;
                return f(s, n / 2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*2. Написать рекурсивную функцию для перевода натурального числа из десятичной системы счисления в двоичную.*/
            int n = Convert.ToInt32(textBox1.Text); //число для перевода в двоичную систему
            string s = ""; //cтрока для представления числа в двоичном виде
            s = f(s, n); //вызов функции
            char[] st = s.ToCharArray();
            Array.Reverse(st);
            s = new string(st);
            label1.Text = n + " в двоичной системе равно " + s;
        }
    }
}
