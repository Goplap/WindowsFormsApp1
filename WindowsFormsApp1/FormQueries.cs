using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormQueries : Form
    {
        // Рядок підключення
        string connectionString = "Data Source=localhost;Initial Catalog=TransportLogistic;Integrated Security=True;TrustServerCertificate=True";

        public FormQueries()
        {
            InitializeComponent();
        }

        private void FormQueries_Load(object sender, EventArgs e)
        {
            // Очищаємо ComboBox
            comboBoxTable.Items.Clear();
            
            // Додаємо назви таблиць
            comboBoxTable.Items.AddRange(new string[] 
            {
                "CARGO_TYPE",
                "DELIVERY",
                "DRIVER",
                "RECIPIENT",
                "ROUTE",
                "SUPPLIER",
                "TRANSPORT_VEHICLE"
            });
            
            // Додаємо порядок сортування
            comboBoxSortOrder.Items.Clear();
            comboBoxSortOrder.Items.AddRange(new string[] 
            { 
                "ASC",
                "DESC"
            });
            
            // Встановлюємо перший елемент за замовчуванням
            if (comboBoxTable.Items.Count > 0)
                comboBoxTable.SelectedIndex = 0;
                
            if (comboBoxSortOrder.Items.Count > 0)
                comboBoxSortOrder.SelectedIndex = 0;
        }

        // Подія зміни вибору таблиці
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedItem == null)
                return;
                
            LoadTableColumns(comboBoxTable.SelectedItem.ToString());
        }

        // Завантаження стовпців таблиці
        private void LoadTableColumns(string tableName)
        {
            comboBoxSortField.Items.Clear();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Отримуємо список стовпців таблиці
                    string query = $@"
                        SELECT COLUMN_NAME 
                        FROM INFORMATION_SCHEMA.COLUMNS 
                        WHERE TABLE_NAME = '{tableName}'
                        ORDER BY ORDINAL_POSITION";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        comboBoxSortField.Items.Add(reader["COLUMN_NAME"].ToString());
                    }
                    
                    reader.Close();
                    
                    if (comboBoxSortField.Items.Count > 0)
                        comboBoxSortField.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження полів таблиці:\n\n" + ex.Message, 
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка сортування
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedItem == null)
            {
                MessageBox.Show("Оберіть таблицю!", "Увага", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (comboBoxSortField.SelectedItem == null)
            {
                MessageBox.Show("Оберіть поле для сортування!", "Увага", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string tableName = comboBoxTable.SelectedItem.ToString();
            string sortField = comboBoxSortField.SelectedItem.ToString();
            string sortOrder = comboBoxSortOrder.SelectedItem.ToString();
            
            // Формування SQL запиту
            string query;
            if (checkBoxTop10.Checked)
            {
                query = $"SELECT TOP 10 * FROM {tableName} ORDER BY {sortField} {sortOrder}";
            }
            else
            {
                query = $"SELECT * FROM {tableName} ORDER BY {sortField} {sortOrder}";
            }
            
            // Виконання запиту
            ExecuteQuery(query);
        }

        // Універсальний метод виконання запитів
        private void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    
                    // ЗМІНЕНО: використовуємо правильну назву DataGridView
                    dataGridViewResult.DataSource = dataTable;
                    
                    // Автоматичне налаштування ширини стовпців
                    dataGridViewResult.AutoResizeColumns();
                    
                    MessageBox.Show($"Знайдено записів: {dataTable.Rows.Count}", 
                                    "Результат", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка виконання запиту:\n\n" + ex.Message + 
                                "\n\n=== SQL Запит ===\n" + query, 
                                "Помилка", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        // ВСІ обробники подій з Designer.cs
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Не використовується
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Не використовується
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Не використовується
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Не використовується
        }
    }
}