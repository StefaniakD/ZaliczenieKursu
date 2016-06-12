using System.Data;

namespace RodWpf
{
    class Rooms
    {
        public int Add(string roomNumber)
        {
            DatabaseConnection db = new DatabaseConnection();

            int roomId = db.QueryInsert("INSERT INTO rooms (roomNumber) OUTPUT inserted.roomid VALUES ('"+roomNumber+"');");
            
            return roomId;
        }

        public DataTable GetRoomSet()
        {
            DatabaseConnection db = new DatabaseConnection();

            DataTable dt = db.QuerySelect("SELECT * FROM Rooms ORDER BY roomNumber ASC");
            return dt;
        }

        public void AssignEnergyCounterToRoom(int roomId, int pEnergyCounter)
        {
            DatabaseConnection dt = new DatabaseConnection();

            dt.Query("UPDATE rooms SET pEnergyCounter = '"+pEnergyCounter+"' WHERE roomId = '"+roomId+"';");
        }
    }
}
