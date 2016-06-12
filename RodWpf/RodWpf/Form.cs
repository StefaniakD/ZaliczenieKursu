using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodWpf
{
    class Form
    {
        public DataTable Load()
        {
            DatabaseConnection dc = new DatabaseConnection();

            return dc.QuerySelect("SELECT * FROM energyCounters");
        }
    }
}
