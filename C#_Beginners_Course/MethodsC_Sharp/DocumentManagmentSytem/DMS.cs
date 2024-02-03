using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagmentSystem
{
    public class DMS
    {
        public DMS()
        {

        }
        public bool CreateDocument(string name, string description, ref int id)
        {
            int webCallResult = 0;
            bool success = false;



            webCallResult = 8;

            if (webCallResult != 0)
            {
                success = true;
            }

            id = webCallResult;

            return success;
        }
    }

}
