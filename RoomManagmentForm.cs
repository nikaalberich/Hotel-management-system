using Newtonsoft.Json;
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
    public partial class RoomManagmentForm : Form
    {
        private List<Room> rooms; // Список всех номеров в гостинице
                                  

        public List<Room> Rooms { get; } = new List<Room>();

        public RoomManagmentForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            // Загрузка списка всех номеров из файловой системы или другого хранилища
            rooms = LoadRoomsFromStorage();

            // Отображение списка номеров в DataGridView
            dgvRooms.DataSource = rooms;
        }

        private List<Room> LoadRoomsFromStorage()
        {
            

            string path = "rooms.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                rooms = JsonConvert.DeserializeObject<List<Room>>(json);
            }

            return rooms;
        }

     

        private void SaveRoomsToStorage(List<Room> rooms)
        {
            // Преобразование списка комнат в JSON-строку
            string json = JsonConvert.SerializeObject(rooms);

            // Запись JSON-строки в файл
            string filePath = "rooms.json";
            File.WriteAllText(filePath, json);
        }



        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            // Получение значений из текстовых полей формы
            int roomNumber = int.Parse(txtRoomNumber.Text);
            string roomType = txtRoomType.Text;
            bool hasBalcony = chkHasBalcony.Checked;
            decimal pricePerNight = decimal.Parse(txtPricePerNight.Text);
           

            // Создание нового экземпляра Room и добавление его в список номеров
            Room newRoom = new Room(roomNumber, roomType, hasBalcony, pricePerNight);
            rooms.Add(newRoom);

            // Обновление отображения в DataGridView
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = rooms;
        }

      
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            // Удаление выбранного номера из списка и обновление отображения в DataGridView
            if (dgvRooms.SelectedRows.Count > 0)
            {
                Room selectedRoom = (Room)dgvRooms.SelectedRows[0].DataBoundItem;
                rooms.Remove(selectedRoom);
                dgvRooms.DataSource = null;
                dgvRooms.DataSource = rooms;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в файловую систему или другое хранилище
            SaveRoomsToStorage(rooms);

            // Проверка наличия сохраненных комнат и вывод сообщения об успешном сохранении
            if (rooms.Count > 0)
            {
                MessageBox.Show("Saved. Back to main menu.");
                this.Hide();
                //MainForm mainForm = new MainForm();
                //mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("The list of rooms are empty. No data to save.");
            }

        }
    }
}
