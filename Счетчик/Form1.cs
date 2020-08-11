using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Счетчик
{ 
    public partial class Form1 : Form
    { int Znachenie,podschet_1,podschet_2;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Znachenie = Convert.ToInt32(textBox1.Text);
                if (Znachenie > 0)
                {
                    ++podschet_1;
                    textBox2.Text = podschet_1.ToString();
                    textBox1.Text = "";
                }
                else if (Znachenie < 0)
                {
                    ++podschet_2;
                    textBox3.Text = podschet_2.ToString();
                    textBox1.Text = "";
                }
                else
                 if (Znachenie == 0)
                    textBox1.Text = "Я нули не считаю";
            }
            catch
            {
                
            }
            
        }

    }
}
