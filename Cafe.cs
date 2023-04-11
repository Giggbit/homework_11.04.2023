using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Дополнительные_диалоги_homework_11._04._2023
{
    public partial class Cafe : Form
    {
        public Cafe() {
            InitializeComponent();

            textBox6.Text = "2,00";
            textBox7.Text = "2,50";
            textBox8.Text = "1,50";
            textBox9.Text = "0,90";
        }

        double sum_cafe = 0;
        double hotdog = 0;
        double burger = 0;
        double potato = 0;
        double cola = 0;

        private void textBox13_TextChanged(object sender, EventArgs e) {
            if (checkBox1.Checked && textBox13.Text.Length > 0) {
                sum_cafe = Convert.ToDouble(textBox6.Text);
                hotdog = sum_cafe * Convert.ToDouble(textBox13.Text);
            }
            else {
                hotdog = 0;
            }
            textBox14.Text = hotdog.ToString();

            if (!checkBox1.Checked) { 
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e) {
            if (checkBox2.Checked && textBox12.Text.Length > 0) {
                sum_cafe = Convert.ToDouble(textBox7.Text);
                burger = sum_cafe * Convert.ToDouble(textBox12.Text);
            }
            else {
                burger = 0;
            }
            textBox14.Text = burger.ToString();

            if (!checkBox2.Checked) {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e) {
            if (checkBox3.Checked && textBox10.Text.Length > 0) {
                sum_cafe = Convert.ToDouble(textBox8.Text);
                potato = sum_cafe * Convert.ToDouble(textBox10.Text);
            }
            else {
                potato = 0;
            }
            textBox14.Text = potato.ToString();

            if (!checkBox3.Checked) {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e) {
            if (checkBox4.Checked && textBox11.Text.Length > 0) {
                sum_cafe = Convert.ToDouble(textBox9.Text);
                cola = sum_cafe * Convert.ToDouble(textBox11.Text);
            }
            else {
                cola = 0;
            }
            textBox14.Text = cola.ToString();

            if (!checkBox4.Checked) {
                textBox14.Text = Convert.ToString(0);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            double sum = hotdog + burger + potato + cola;
            textBox1.Text = sum.ToString();
        }
    }
}
