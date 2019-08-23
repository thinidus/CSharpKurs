using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Obiekt
    {

    public Obiekt()
        {
            wystapienia += 1;
        }

        public int wystapienia;

        public string nazwa = "Stara nazwa";

        

        public void Zeruj() {
            nazwa = "";
        }


        
    }
}
