using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsoleApp
{
    public class Developer
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        private DateTime _founded;
        public DateTime Founded
        {
            get { return _founded; }
            set { _founded = value; }
        }

        public Developer(string name, string country, string founded)
        {
            _name = name;
            _country = country;
            var parts = founded.Split(' ');
            try
            {
                int day, mounth, year;
                day = int.Parse(parts[0]);
                mounth = int.Parse(parts[1]);
                year = int.Parse(parts[2]);
                _founded = new DateTime(year, mounth, day);
            }
            catch
            {
                _founded = new DateTime();
            }
        }
    }
}
