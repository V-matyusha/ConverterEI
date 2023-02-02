using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Text = "Выбрать ЕИ...";
            comboBox3.Text = "Выбрать ЕИ...";
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;

            if (comboBox1.Text == "Масса")
            {
                comboBox2.Items.Add("Килограмм");
                comboBox2.Items.Add("Тонна");
                comboBox2.Items.Add("Грамм");
                comboBox2.Items.Add("Миллиграмм");
                comboBox3.Items.Add("Грамм");
                comboBox3.Items.Add("Килограмм");
                comboBox3.Items.Add("Тонна");
                comboBox3.Items.Add("Миллиграмм");

            }

            else if (comboBox1.Text == "Температура")
            {
                comboBox2.Items.Add("Градус Цельсия");
                comboBox2.Items.Add("Градус Фаренгейта");
                comboBox2.Items.Add("Кельвин");
                comboBox3.Items.Add("Градус Цельсия");
                comboBox3.Items.Add("Градус Фаренгейта");
                comboBox3.Items.Add("Кельвин");

            }

            else if (comboBox1.Text == "Длина")
            {
                comboBox2.Items.Add("Километр");
                comboBox2.Items.Add("Метр");
                comboBox2.Items.Add("Сантиметр");
                comboBox2.Items.Add("Миллиметр");
                comboBox3.Items.Add("Километр");
                comboBox3.Items.Add("Метр");
                comboBox3.Items.Add("Сантиметр");
                comboBox3.Items.Add("Миллиметр");

            }

            else if (comboBox1.Text == "Площадь")
            {
                comboBox2.Items.Add("Кв. Метр");
                comboBox2.Items.Add("Кв. Километр");
                comboBox2.Items.Add("Гектар");
                comboBox3.Items.Add("Кв. Метр");
                comboBox3.Items.Add("Кв. Километр");
                comboBox3.Items.Add("Гектар");

            }

            else if (comboBox1.Text == "Скорость")
            {
                comboBox2.Items.Add("Метр в сек.");
                comboBox2.Items.Add("Километр в час");
                comboBox3.Items.Add("Метр в сек.");
                comboBox3.Items.Add("Километр в час");

            }

            else if (comboBox1.Text == "Частота")
            {
                comboBox2.Items.Add("Герц");
                comboBox2.Items.Add("Килогерц");
                comboBox2.Items.Add("Мегагерц");
                comboBox2.Items.Add("Гигагерц");
                comboBox3.Items.Add("Герц");
                comboBox3.Items.Add("Килогерц");
                comboBox3.Items.Add("Мегагерц");
                comboBox3.Items.Add("Гигагерц");

            }

            else if (comboBox1.Text == "Энергия")
            {
                comboBox2.Items.Add("Джоуль");
                comboBox2.Items.Add("Килоджоуль");
                comboBox3.Items.Add("Джоуль");
                comboBox3.Items.Add("Килоджоуль");

            }

            else if (comboBox1.Text == "Время")
            {
                comboBox2.Items.Add("Миллисекунда");
                comboBox2.Items.Add("Секунда");
                comboBox2.Items.Add("Минута");
                comboBox2.Items.Add("Час");
                comboBox2.Items.Add("Сутки");
                comboBox3.Items.Add("Миллисекунда");
                comboBox3.Items.Add("Секунда");
                comboBox3.Items.Add("Минута");
                comboBox3.Items.Add("Час");
                comboBox3.Items.Add("Сутки");

            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Выбрать СИ...")
            {
                if (comboBox2.Text != "Выбрать ЕИ..." && comboBox3.Text != "Выбрать ЕИ...")
                {
                    Converting(comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox1.Text);
                }
                else MessageBox.Show("Выберите единицы измерения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Выберите систему счисления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Converting(string comboBox1, string comboBox2, string comboBox3, string textBox1)
        {
            double x, y, z;
            z = 0;
            x = 0;
            if (textBox1 == "")
            { MessageBox.Show("Введите данные!", "Error"); z = 1; }
            else
            {
                try
                {
                    x = Convert.ToDouble(textBox1);
                    y = 0;

                    if (comboBox2 == "Килограмм")

                    {
                        if (comboBox3 == "Тонна") y = x * 0.001;
                        if (comboBox3 == "Килограмм") y = x * 1;
                        if (comboBox3 == "Грамм") y = x * 1000;
                        if (comboBox3 == "Миллиграмм") y = x * 1000000;

                    }

                    if (comboBox2 == "Тонна")

                    {
                        if (comboBox3 == "Тонна") y = x * 1;
                        if (comboBox3 == "Килограмм") y = x * 1000;
                        if (comboBox3 == "Грамм") y = x * 1000000;
                        if (comboBox3 == "Миллиграмм") y = x * 1000000000;

                    }

                    if (comboBox2 == "Грамм")

                    {
                        if (comboBox3 == "Тонна") y = x * 0.000001;
                        if (comboBox3 == "Килограмм") y = x * 0.001;
                        if (comboBox3 == "Грамм") y = x * 1;
                        if (comboBox3 == "Миллиграмм") y = x * 1000;
                    }

                    if (comboBox2 == "Миллиграмм")

                    {
                        if (comboBox3 == "Тонна") y = x * 0.000000001;
                        if (comboBox3 == "Килограмм") y = x * 0.000001;
                        if (comboBox3 == "Грамм") y = x * 0.001;
                        if (comboBox3 == "Миллиграмм") y = x * 1;
                    }

                    if (comboBox2 == "Градус Цельсия")

                    {
                        if (comboBox3 == "Градус Фаренгейта") y = x * 1.8 + 32;
                        if (comboBox3 == "Кельвин") y = x + 273;
                        if (comboBox3 == "Градус Цельсия") y = x * 1;
                    }

                    if (comboBox2 == "Градус Фаренгейта")

                    {
                        if (comboBox3 == "Градус Цельсия") y = (x - 32) / 1.8;
                        if (comboBox3 == "Кельвин") y = x * 0.556 + 255.372;
                        if (comboBox3 == "Градус Фаренгейта") y = x * 1;
                    }

                    if (comboBox2 == "Кельвин")

                    {
                        if (comboBox3 == "Градус Фаренгейта") y = x * 1.8 - 459.67;
                        if (comboBox3 == "Кельвин") y = x;
                        if (comboBox3 == "Градус Цельсия") y = x - 273;
                    }

                    if (comboBox2 == "Метр в сек.")

                    {
                        if (comboBox3 == "Метр в сек.") y = x;
                        if (comboBox3 == "Километр в час") y = x * 3.6;
                    }

                    if (comboBox2 == "Километр в час")

                    {
                        if (comboBox3 == "Метр в сек.") y = x * 0.277;
                        if (comboBox3 == "Километр в час") y = x;
                    }

                    if (comboBox2 == "Кв. Метр")

                    {
                        if (comboBox3 == "Кв. Метр") y = x;
                        if (comboBox3 == "Кв. Километр") y = x * 0.000001;
                        if (comboBox3 == "Гектар") y = x * 0.0001;
                    }

                    if (comboBox2 == "Кв. Километр")

                    {
                        if (comboBox3 == "Кв. Метр") y = x * 1000000;
                        if (comboBox3 == "Кв. Километр") y = x;
                        if (comboBox3 == "Гектар") y = x * 100;
                    }

                    if (comboBox2 == "Гектар")

                    {
                        if (comboBox3 == "Кв. Метр") y = x * 10000;
                        if (comboBox3 == "Кв. Километр") y = x * 0.01;
                        if (comboBox3 == "Гектар") y = x;
                    }

                    if (comboBox2 == "Джоуль")

                    {
                        if (comboBox3 == "Джоуль") y = x;
                        if (comboBox3 == "Килоджоуль") y = x * 0.001;
                    }

                    if (comboBox2 == "Килоджоуль")

                    {
                        if (comboBox3 == "Джоуль") y = x * 1000;
                        if (comboBox3 == "Килоджоуль") y = x;
                    }

                    if (comboBox2 == "Километр")

                    {
                        if (comboBox3 == "Километр") y = x;
                        if (comboBox3 == "Метр") y = x * 1000;
                        if (comboBox3 == "Сантиметр") y = x * 100000;
                        if (comboBox3 == "Миллиметр") y = x * 1000000;
                    }

                    if (comboBox2 == "Метр")

                    {
                        if (comboBox3 == "Километр") y = x * 0.001;
                        if (comboBox3 == "Метр") y = x;
                        if (comboBox3 == "Сантиметр") y = x * 100;
                        if (comboBox3 == "Миллиметр") y = x * 1000;
                    }

                    if (comboBox2 == "Сантиметр")

                    {
                        if (comboBox3 == "Километр") y = x * 0.00001;
                        if (comboBox3 == "Метр") y = x * 0.01;
                        if (comboBox3 == "Сантиметр") y = x;
                        if (comboBox3 == "Миллиметр") y = x * 10;
                    }

                    if (comboBox2 == "Миллиметр")

                    {
                        if (comboBox3 == "Километр") y = x * 0.000001;
                        if (comboBox3 == "Метр") y = x * 0.001;
                        if (comboBox3 == "Сантиметр") y = x * 0.1;
                        if (comboBox3 == "Миллиметр") y = x;
                    }

                    if (comboBox2 == "Герц")

                    {
                        if (comboBox3 == "Герц") y = x;
                        if (comboBox3 == "Килогерц") y = x * 0.001;
                        if (comboBox3 == "Мегагерц") y = x * 0.000001;
                        if (comboBox3 == "Гигагерц") y = x * 0.000000001;
                    }

                    if (comboBox2 == "Килогерц")

                    {
                        if (comboBox3 == "Герц") y = x * 1000;
                        if (comboBox3 == "Килогерц") y = x;
                        if (comboBox3 == "Мегагерц") y = x * 0.001;
                        if (comboBox3 == "Гигагерц") y = x * 0.000001;
                    }

                    if (comboBox2 == "Мегагерц")

                    {
                        if (comboBox3 == "Герц") y = x * 1000000;
                        if (comboBox3 == "Килогерц") y = x * 1000;
                        if (comboBox3 == "Мегагерц") y = x;
                        if (comboBox3 == "Гигагерц") y = x * 0.001;
                    }

                    if (comboBox2 == "Гигагерц")

                    {
                        if (comboBox3 == "Герц") y = x * 1000000000;
                        if (comboBox3 == "Килогерц") y = x * 1000000;
                        if (comboBox3 == "Мегагерц") y = x * 1000;
                        if (comboBox3 == "Гигагерц") y = x;
                    }

                    if (comboBox2 == "Миллисекунда")

                    {
                        if (comboBox3 == "Миллисекунда") y = x;
                        if (comboBox3 == "Секунда") y = x * 0.001;
                        if (comboBox3 == "Минута") y = x * 0.0000167;
                        if (comboBox3 == "Час") y = x * 0.000000278;
                        if (comboBox3 == "Сутки") y = x * 0.000000011574;
                    }

                    if (comboBox2 == "Секунда")

                    {
                        if (comboBox3 == "Миллисекунда") y = x * 1000;
                        if (comboBox3 == "Секунда") y = x;
                        if (comboBox3 == "Минута") y = x * 0.016;
                        if (comboBox3 == "Час") y = x * 0.00027;
                        if (comboBox3 == "Сутки") y = x * 0.000011574;
                    }

                    if (comboBox2 == "Минута")

                    {
                        if (comboBox3 == "Миллисекунда") y = x * 60000;
                        if (comboBox3 == "Секунда") y = x * 60;
                        if (comboBox3 == "Минута") y = x;
                        if (comboBox3 == "Час") y = x * 0.016;
                        if (comboBox3 == "Сутки") y = x * 0.000694;
                    }

                    if (comboBox2 == "Час")

                    {
                        if (comboBox3 == "Миллисекунда") y = x * 3600000;
                        if (comboBox3 == "Секунда") y = x * 3600;
                        if (comboBox3 == "Минута") y = x * 60;
                        if (comboBox3 == "Час") y = x;
                        if (comboBox3 == "Сутки") y = x * 0.0416;
                    }

                    if (comboBox2 == "Сутки")

                    {
                        if (comboBox3 == "Миллисекунда") y = x * 86400000;
                        if (comboBox3 == "Секунда") y = x * 86400;
                        if (comboBox3 == "Минута") y = x * 1440;
                        if (comboBox3 == "Час") y = x * 24;
                        if (comboBox3 == "Сутки") y = x;
                    }

                    if (z == 0)
                    { textBox2.Text = Convert.ToString(y); }
                    else { }
                }
                catch
                {
                    MessageBox.Show("Используйте только числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение разработано для перевода числовых значений из одних единиц измерения в другие" +
                "\nв рамках одной системы счисления" +
                "\nДля перевода значений необходимо:" +
                "\n- Выбрать систему счисления;" +
                "\n- Выбрать обе единицы измерения;" +
                "\n- Ввести значение в левое поле значений;" +
                "\n- Нажать на кнопку Конвертировать;", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
