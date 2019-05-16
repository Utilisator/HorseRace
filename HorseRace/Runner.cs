using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    public class Runner
    {
        private string _name;
        private int _x;
        private int _y;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FractionalPrice
        {
            get { return $"{_x}/{_y}"; }
        }

        public double DecimalPrice
        {
            get
            {
                return 100 / (1 + (double)_x / (double)_y);
            }
        }
    }
}
