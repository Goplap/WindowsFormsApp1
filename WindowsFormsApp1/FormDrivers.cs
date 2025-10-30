using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDrivers : Form
    {
        // Рядок підключення
        string connectionString = "Data Source=localhost;Initial Catalog=TransportLogistic;Integrated Security=True;Trust Server Certificate=True";
        DataTable dataTable;
        SqlDataAdapter adapter;

        public FormDrivers()
        {
            InitializeComponent();
        }

        private void FormDrivers_Load(object sender, EventArgs e)
        {
            // Завантаження даних
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM DRIVER", connection);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Додавання нового рядка
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                dataTable.Rows.Add(newRow);
                dataGridView1.DataSource = dataTable;

                // Переходимо до нового рядка
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];

                MessageBox.Show("Новий рядок додано. Заповніть дані та натисніть 'Зберегти'",
                                "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка додавання: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Видалення виділеного рядка
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Ви впевнені, що хочете видалити вибрані рядки?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                dataGridView1.Rows.Remove(row);
                            }
                        }
                        MessageBox.Show("Рядки видалено. Натисніть 'Зберегти' для підтвердження змін",
                                        "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть рядок для видалення",
                                    "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Збереження даних
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM DRIVER", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable changes = dataTable.GetChanges();
                    if (changes != null)
                    {
                        adapter.Update(dataTable);
                        dataTable.AcceptChanges();
                        MessageBox.Show("Дані успішно збережено!", "Успіх",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Немає змін для збереження", "Інформація",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження даних: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пошук
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBoxSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Введіть текст для пошуку", "Увага",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Створюємо фільтр для пошуку по всіх текстових колонках
                string filter = "";
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.DataType == typeof(string))
                    {
                        if (filter.Length > 0)
                            filter += " OR ";
                        filter += $"[{column.ColumnName}] LIKE '%{searchText}%'";
                    }
                }

                DataView dv = dataTable.DefaultView;
                dv.RowFilter = filter;

                if (dv.Count == 0)
                {
                    MessageBox.Show("Нічого не знайдено", "Результат пошуку",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка пошуку: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Скидання фільтрів
        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable.DefaultView.RowFilter = "";
                textBoxSearch.Text = "";
                MessageBox.Show("Фільтри скинуто", "Інформація",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка скидання фільтрів: " + ex.Message,
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Оновлення даних з бази
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Дані оновлено", "Інформація",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}