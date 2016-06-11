using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace RodWpf
{
    class Rooms
    {
        public Boolean Add(string roomNumber)
        {
            DatabaseConnection db = new DatabaseConnection();

            int roomId = db.QueryInsert("INSERT INTO rooms (roomNumber) OUTPUT inserted.roomid VALUES ('"+roomNumber+"');");
            
            return true;
        }
    }
}
