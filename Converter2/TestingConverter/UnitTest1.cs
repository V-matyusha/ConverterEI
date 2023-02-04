using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Converter
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void LogInTest1()
        {
            UserList list = new UserList();

            list.SingUp("1", "1");
            bool result = list.LogIn("1", "1");//логин, пароль

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RegTest1()
        {
            UserList list = new UserList();

            bool result = list.SingUp("1234", "1234");//логин, пароль

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ConvertTest1()
        {
            Form1 form1 = new Form1();
            form1.comboBox1.Text = "Масса";
            form1.comboBox2.Text = "Килограмм";
            form1.comboBox3.Text = "Тонна";
            form1.textBox1.Text = "1500";
            form1.Converting(form1.comboBox1.Text, form1.comboBox2.Text, form1.comboBox3.Text, form1.textBox1.Text);
            string result = form1.textBox2.Text;
            Assert.AreEqual("1,5", result);
        }
        [TestMethod]
        public void ConvertTest2()
        {
            Form1 form1 = new Form1();
            form1.comboBox1.Text = "Длина";
            form1.comboBox2.Text = "Километр";
            form1.comboBox3.Text = "Метр";
            form1.textBox1.Text = "2";
            form1.Converting(form1.comboBox1.Text, form1.comboBox2.Text, form1.comboBox3.Text, form1.textBox1.Text);
            string result = form1.textBox2.Text;
            Assert.AreEqual("2000", result);
        }
    }
}


