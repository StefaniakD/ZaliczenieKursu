using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RodWpf
{
    class EnergyCounter
    {
            public DataTable GetRoomSet()
            {
                DatabaseConnection db = new DatabaseConnection();

                DataTable dt = db.QuerySelect(@"SELECT roomNumber FROM Rooms");
                
                return dt;
            }
    }
}
