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
        public int winCount;

        public Runner()
        {
            _x = 0; _y = 0;
        }

        public Runner(string name, int x, int y)
        {
            _name = name;
            _x = x;
            _y = y;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
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

        public double Chance(double margin)
        {
            return (DecimalPrice / margin) * 100;
        }
    }
}
