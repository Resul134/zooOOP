using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zooOOP
{
    class Dyr
    {
        public string navn;
        public int year;
        protected bool tam;

        public bool Tam
        {
            get { return tam; }
            set
            {
                if (tam == true) tam = true;
                if (tam == false) tam = value;
            }
        }
    }
}
