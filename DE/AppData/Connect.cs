using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE.AppData
{
    internal class Connect
    {
        public static user3Entities c;
        public static user3Entities con
        {
            get
            {
                if (c == null) c = new user3Entities();
                return c;   
            }
        }
    }
}
