using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
   public class Room
    {
        public int RoomNumber { get; set; } // Номер комнаты
        public string RoomType { get; set; } // Тип комнаты
        public bool HasBalcony { get; set; } // Наличие балкона
        public decimal PricePerNight { get; set; } // Цена за ночь

        public bool IsAvailable { get; set; }
      
        public DateTime BookedFrom { get; set; }
        public DateTime BookedTo { get; set; }
        public string GuestName { get; set; } // Имя гостя




        public Room(int roomNumber, string roomType, bool hasBalcony, decimal pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            HasBalcony = hasBalcony;
            PricePerNight = pricePerNight;
           
            BookedFrom = DateTime.MinValue;
            BookedTo = DateTime.MinValue;
            IsAvailable = true; // по умолчанию все комнаты доступны
        }

        public void Book(string guestName, DateTime bookedFrom, DateTime bookedTo)
        {
            if (bookedFrom >= bookedTo)
            {
                throw new ArgumentException("The date of entry must be less than date of deparchure!");
            }

            IsAvailable = false;
            BookedFrom = bookedFrom;
            BookedTo = bookedTo;
        }

        public void Unbook()
        {
            IsAvailable = true;
            BookedFrom = DateTime.MinValue;
            BookedTo = DateTime.MinValue;
        }


    }
}
