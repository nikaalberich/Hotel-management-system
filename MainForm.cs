using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;

            // Если пользователь не является администратором, скрываем кнопку управления номерами
            if (!user.IsAdmin)
            {
                btnManageRooms.Hide();
            }
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            // Переходим на форму управления номерами
            RoomManagmentForm roomForm = new RoomManagmentForm();
            roomForm.Show();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddEmployeeForm reportsForm = new AddEmployeeForm();
            reportsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeListForm empListForm = new EmployeeListForm();
            empListForm.Show();
        }

        private void btn_BackAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
