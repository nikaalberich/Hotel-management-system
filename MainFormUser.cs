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
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
               // Переходим на форму бронирования номеров
                RoomBookingForm bookingForm = new RoomBookingForm(new RoomManagmentForm());
                bookingForm.Show();
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
