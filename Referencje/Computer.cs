using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencje
{
    class Computer
    { 
        public static int initCounter = 0;
        public string name = "";
        public float costNett = 0f;
        private float grossMultiplier = 1.23f;


        public Computer()
        {
            initCounter++;
        }

        public float CountGross(float nett)
        {
            float gross = nett * grossMultiplier;
            return gross;
        }

        
        

        

    }
}