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
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();

            // Заполняем список пользователей
            users = new List<User>();
            users.Add(new User("admin", "admin", true));
            users.Add(new User("user", "password", false));

            txtPassword.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Ищем пользователя с введенным логином
            User user = users.FirstOrDefault(u => u.Username == username);

            // Проверяем, существует ли пользователь и совпадает ли пароль
            if (user != null && user.Password == password)
            {
                if (user.IsAdmin)
                {
                    // Если пользователь - администратор, открываем главное окно системы для администрирования
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
                }
                else
                {
                    // Если пользователь - обычный пользователь, открываем главное окно для бронирования номеров
                    MainFormUser mainFormUser = new MainFormUser();
                    mainFormUser.Show();
                }

                this.Hide();
            }
            else
            {
                // Если аутентификация не удалась, выводим сообщение об ошибке
                MessageBox.Show("Invalid login or password!");
            }


        }

        private void btn_closeLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
