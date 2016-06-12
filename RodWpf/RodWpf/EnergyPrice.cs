using System.Data;

namespace RodWpf
{
    class EnergyPrice : IPrices
    {
        private string _IssueDate;
        private float _Price;
        private int _ToPayDays;
        public string IssueDate
        {
            get
            {
                return _IssueDate;
            }

            set
            {
                _IssueDate = value;
            }
        }

        public float Price
        {
            get
            {
                return _Price;
            }

            set
            {
                _Price = value;
            }
        }

        public int ToPayDays
        {
            get
            {
                return _ToPayDays;
            }

            set
            {
                _ToPayDays = value;
            }
        }

        public EnergyPrice()
        {
            Select();
        }

        public void Update()
        {
            DatabaseConnection dc = new DatabaseConnection();
            DataTable dt = dc.QuerySelect("SELECT * FROM prices WHERE priceType LIKE 'ENERGY'");

            if (dt.Rows.Count != 0)
            {
                dc.Query("UPDATE Prices " +
                " SET price = " + Price.ToString().Replace(',','.') +
                ",issueDate = '" + IssueDate +
                "',toPayDays = " + ToPayDays +
                " WHERE priceType = 'ENERGY';");
            }
            else
            {
                dc.Query("INSERT INTO Prices VALUES ('ENERGY',"+Price+",'"+IssueDate+"',"+ToPayDays+");");
            }
            
        }

        public void Select()
        {
            DatabaseConnection dc = new DatabaseConnection();

            DataTable dt = dc.QuerySelect("SELECT * FROM prices WHERE priceType LIKE 'ENERGY'");
            if (dt.Rows.Count != 0)
            {
                this._Price = float.Parse(dt.Rows[0]["price"].ToString());
                this._IssueDate = dt.Rows[0]["issueDate"].ToString().Remove(10);
                this._ToPayDays = (int)dt.Rows[0]["toPayDays"];
            }
        }
    }
}
