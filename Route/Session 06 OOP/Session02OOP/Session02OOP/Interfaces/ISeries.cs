using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Interfaces
{
    public interface ISeries
    {
        public int Current { get; set; }
        void GetNext();
        void Rest()
        {
            Current=0;
        }
    }
}
