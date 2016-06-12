using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodWpf
{
    interface IPrices
    {
        float Price { get; set; }
        string IssueDate { get; set; }
        int ToPayDays { get; set; }

        void Update();
    }
}
