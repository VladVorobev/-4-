using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace модуль_4_воробьёв
{
    public partial class Task3Form : Form
    {
        private List<IStudent> students = new List<IStudent>();

        public Task3Form()
        {
            InitializeComponent();
        }

        private void Task3Form_Load(object sender, EventArgs e)
        {
            dgvStudents.ReadOnly = true; // Делаем DataGridView только для чтения
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Проверяем введенные значения
            if (decimal.TryParse(txtGPA.Text, out decimal gpa) &&
                int.TryParse(txtCourse.Text, out int course) &&
                course >= 1 && course <= 4)
            {
                string name = txtName.Text; // Получаем имя студента

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Пожалуйста, введите имя студента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IStudent newStudent = null;

                // Используем if вместо switch
                if (course == 1)
                {
                    newStudent = new FirstYearStudent(name, gpa);
                }
                else if (course == 2)
                {
                    newStudent = new SecondYearStudent(name, gpa);
                }
                else if (course == 3)
                {
                    newStudent = new ThirdYearStudent(name, gpa);
                }
                else if (course == 4)
                {
                    newStudent = new FourthYearStudent(name, gpa);
                }

                if (newStudent != null)
                {
                    students.Add(newStudent);

                    // Добавляем данные студента в DataGridView
                    dgvStudents.Rows.Add(newStudent.GetName(), newStudent.GetGPA(), newStudent.GetCourse());

                    // Очищаем поля ввода
                    txtGPA.Clear();
                    txtCourse.Clear();
                    txtName.Clear();
                    MessageBox.Show("Студент добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось создать студента для данного курса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения среднего балла и курса (1-4).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            txtGPA.Clear();
            txtCourse.Clear();
            txtName.Clear();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int rowIndex = dgvStudents.SelectedRows[0].Index;

                // Удаляем студента из списка и DataGridView
                students.RemoveAt(rowIndex);
                dgvStudents.Rows.RemoveAt(rowIndex);

                MessageBox.Show("Студент успешно удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
