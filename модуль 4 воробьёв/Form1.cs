using System;
using System.Windows.Forms;
using модуль_4_воробьёв; // Убедитесь, что пространство имен соответствует вашему проекту

namespace модуль_4_воробьёв
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Обработчик для пункта меню "Задание 1"
        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1Form task1Form = new Task1Form();
            task1Form.Show();
        }

        // Обработчик для пункта меню "Задание 2"
        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2Form task2Form = new Task2Form();
            task2Form.Show();
        }

        // Обработчик для пункта меню "Задание 3"
        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task3Form task3Form = new Task3Form();
            task3Form.Show();
        }

        // Обработчик для пункта меню "Задание 4"
        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task4Form task4Form = new Task4Form();
            task4Form.Show();
        }

        // Обработчик для пункта меню "Задание 5"
        private void задание5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task5Form task5Form = new Task5Form();
            task5Form.Show();
        }
    }
}