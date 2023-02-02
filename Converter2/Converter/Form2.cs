using System;
using System.Drawing;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form2 : Form
    {
        UserList userList = new UserList();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCancelReg_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxRepeatedPassword.Clear();
            buttonCancelReg.Visible = false;
            buttonCompleteRegistration.Visible = false;
            buttonInter.Visible = true;
            buttonRegistration.Visible = true;
            textBoxRepeatedPassword.Visible = false;
            label3.Visible = false;
            Size = new Size(149, 167);
        }

        private void buttonCompleteRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxRepeatedPassword.Text != "")
            {
                if (textBoxRepeatedPassword.Text == textBoxPassword.Text)
                {
                    if (userList.SingUp(textBoxLogin.Text, textBoxPassword.Text))
                    {
                        MessageBox.Show("Успешная регистрация!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        textBoxRepeatedPassword.Clear();
                        buttonCancelReg.Visible = false;
                        buttonCompleteRegistration.Visible = false;
                        buttonInter.Visible = true;
                        buttonRegistration.Visible = true;
                        textBoxRepeatedPassword.Visible = false;
                        label3.Visible = false;
                        Size = new Size(149, 167);

                    }
                }
                else MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else MessageBox.Show("Проверьте, чтобы все поля были заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonInter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                if (userList.LogIn(textBoxLogin.Text, textBoxPassword.Text))
                {
                    MessageBox.Show("Авторизация выполнена", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else MessageBox.Show("Данного пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Проверьте, чтобы все поля были заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxRepeatedPassword.Clear();
            buttonCancelReg.Visible = true;
            buttonCompleteRegistration.Visible = true;
            buttonInter.Visible = false;
            buttonRegistration.Visible = false;
            textBoxRepeatedPassword.Visible = true;
            label3.Visible = true;
            Size = new Size(149, 202);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userList.SingUp("1", "1");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
