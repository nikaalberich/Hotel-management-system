using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class RoomBookingForm : Form
    {
        private RoomManagmentForm roomManagementForm;

        public RoomBookingForm(RoomManagmentForm roomManagementForm)
        {
            InitializeComponent();
            this.roomManagementForm = roomManagementForm;

            // заполнение списка комнат
            string path = "rooms.json";
            string json = File.ReadAllText(path);
            List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(json);

            // привязка списка объектов к источнику данных DataGridView
            dataGridView1.DataSource = rooms;

            // заполнение DataGridView
            //dataGridView1.DataSource = rooms.Where(r => r.IsAvailable).ToList();

            //dataGridView1.Columns["BookedTo"].Visible = false;
            dataGridView1.Columns["IsAvailable"].Visible = false;

            // автоматическое изменение размеров столбцов
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void bookRoomButton_Click(object sender, EventArgs e)
        {

            string guestName = guestNameTextBox.Text;

            // проверка выбрана ли комната
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must choose room for booking!");
                return;
            }

            Room selectedRoom = (Room)dataGridView1.SelectedRows[0].DataBoundItem;

            // проверка, что введены данные гостя
            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("You must enter your name");
                return;
            }

            // проверка, что выбраны даты въезда и выезда
            if (dtpCheckInDate.Value == dtpCheckOutDate.Value)
            {
                MessageBox.Show("You must enter data");
                return;
            }

            if (dtpCheckInDate.Value > dtpCheckOutDate.Value)
            {
                MessageBox.Show("The date of entry must be less than date of deparchure!");
                return;
            }


            // бронирование комнаты
            if (selectedRoom.IsAvailable)
            {
                selectedRoom.IsAvailable = false;
                
                selectedRoom.BookedFrom = dtpCheckInDate.Value;
                selectedRoom.BookedTo = dtpCheckOutDate.Value;
                selectedRoom.GuestName = guestName;

                // сохранение изменений в файле
                string path = "rooms.json";
                string json = File.ReadAllText(path);
                List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(json);

                int index = rooms.FindIndex(r => r.RoomNumber == selectedRoom.RoomNumber);
                rooms[index] = selectedRoom;

                string output = JsonConvert.SerializeObject(rooms, Formatting.Indented);
                File.WriteAllText(path, output);

                // вывод сообщения об успешном бронировании
                MessageBox.Show($"Room {selectedRoom.RoomNumber} succsessfully booked for {guestName}");

                // обновление источника данных DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = rooms;

            }
            else
            {
                MessageBox.Show($"Room {selectedRoom.RoomNumber} already booked by someone");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved. Back to main menu.");
            this.Hide();
            this.Close();
        }
    }
}
