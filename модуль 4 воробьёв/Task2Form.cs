using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace модуль_4_воробьёв
{
    public partial class Task2Form : Form
    {
        private List<IProduct> products;

        public Task2Form()
        {
            InitializeComponent();
            products = new List<IProduct>();
            dgvProducts.ReadOnly = true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price) &&
                int.TryParse(txtStock.Text, out int stock) &&
                !string.IsNullOrWhiteSpace(txtProductName.Text)) // Проверка на пустое имя продукта
            {
                // Создаем новый продукт с именем
                IProduct newProduct = new Product(txtProductName.Text, price, stock);

                // Добавляем его в список продуктов
                products.Add(newProduct);

                // Добавляем данные продукта в DataGridView
                dgvProducts.Rows.Add(newProduct.GetName(), newProduct.GetPrice(), newProduct.GetStock());

                // Очищаем поля ввода
                txtProductName.Clear(); // Очищаем поле имени
                txtPrice.Clear();
                txtStock.Clear();
                MessageBox.Show("Продукт добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения имени товара, цены и остатка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddProduct_MouseEnter(object sender, EventArgs e)
        {
            btnAddProduct.BackColor = System.Drawing.Color.DarkGreen;
            btnAddProduct.ForeColor = System.Drawing.Color.White;
        }

        private void btnAddProduct_MouseLeave(object sender, EventArgs e)
        {
            btnAddProduct.BackColor = System.Drawing.Color.Green;
            btnAddProduct.ForeColor = System.Drawing.Color.White;
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                // Удалить выделенную строку
                dgvProducts.Rows.RemoveAt(dgvProducts.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            // Игнорируем нажатие клавиши Delete
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true; // Отключаем дальнейшую обработку нажатия
            }
        }
    }
}