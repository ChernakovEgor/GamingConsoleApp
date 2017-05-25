using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsoleApp
{
    class GamingConsole
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _developer;
        public string Developer
        {
            get { return _developer; }
            set { _developer = value; }
        }

        private DateTime _releaseDate;
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        private int _unitsSold;
        public int UnitsSold
        {
            get { return _unitsSold; }
            set { _unitsSold = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public GamingConsole(string name, string developer, DateTime releaseDate, int unitsSold, double price)
        {
            _name = name;
            _developer = developer;
            _releaseDate = releaseDate;
            _unitsSold = unitsSold;
            _price = price;
        }
        public GamingConsole(string name, string developer)
        {
            _name = name;
            _developer = developer;
        }
        public GamingConsole(string name)
        {
            _name = name;
        }
    }
}
