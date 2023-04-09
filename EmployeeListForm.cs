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
    public partial class EmployeeListForm : Form
    {
        List<Employee> employees = new List<Employee>();
        public EmployeeListForm()
        {
            InitializeComponent();

            // Загружаем список сотрудников из файла
            string path = "employees.csv";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');

                    Employee employee = new Employee
                    {
                        Name = fields[0],
                        Position = fields[1],
                        Salary = int.Parse(fields[2])
                    };

                    employees.Add(employee);
                }
            }

            // Заполняем таблицу данными
            dataGridView.DataSource = employees;
        }

        private void bDelEmp_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                Employee selectedEmployee = (Employee)dataGridView.SelectedRows[0].DataBoundItem;
                employees.Remove(selectedEmployee);
                dataGridView.DataSource = null;
                dataGridView.DataSource = employees;
            }
        }

        private void bSaveChang_Click(object sender, EventArgs e)
        {
            string path = "employees.csv";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Employee employee in employees)
                {
                    writer.WriteLine($"{employee.Name},{employee.Position},{employee.Salary}");
                }
            }
            MessageBox.Show("Saved");
        }

        private void bBackMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
  
}
