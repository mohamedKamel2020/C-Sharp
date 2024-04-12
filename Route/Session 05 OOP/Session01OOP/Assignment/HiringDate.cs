using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class HiringDate
    {

        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        #endregion

        #region Constructor
        public HiringDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }
        public HiringDate()
        {

        } 
        #endregion
    }
}
