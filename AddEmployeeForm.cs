using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(salaryTextBox.Text, out int salary))
            {
                MessageBox.Show("Incorrect salary format. Enter the numbers.");
                return;
            }


            // Создаем нового сотрудника на основе введенной информации
            Employee employee = new Employee
            {
                Name = nameTextBox.Text,
                Position = positionTextBox.Text,
                Salary = salary
            };

            // Добавляем сотрудника в файл
            string path = "employees.csv";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{employee.Name},{employee.Position},{employee.Salary}");
            }

            // Очищаем поля ввода
            nameTextBox.Clear();
            positionTextBox.Clear();
            salaryTextBox.Clear();

            MessageBox.Show("An employee added");
            
        }

        private void btn_ExittoMain_Click(object sender, EventArgs e)
        {
             this.Hide();
             this.Close();
        }
    }
}
