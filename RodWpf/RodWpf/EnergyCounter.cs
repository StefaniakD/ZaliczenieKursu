using System.Data;

namespace RodWpf
{
    class EnergyCounter
    {
            public DataTable GetRoomSet()
            {
                DatabaseConnection db = new DatabaseConnection();

                DataTable dt = db.QuerySelect(@"SELECT roomNumber FROM Rooms ORDER BY roomNumber ASC");
                
                return dt;
            }

      
    }
}
