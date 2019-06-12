using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveXMethodCalling
{
    public class ActiveXClass
    {
        public string FName { set; get; }
        public string LName { set; get; }

        public string Name()
        {
            FName = "Sirajus";
            LName = "Salekin";
            return FName + LName;
        }
    }
}
