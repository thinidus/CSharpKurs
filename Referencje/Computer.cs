using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencje
{
    class Computer
    {


        public ComputerType computerType;
        public Elements computerElements;


        public enum ComputerType
        {
            Desctop,
            Laptop,
            Server,
            Mobile
        }

        public struct Elements
        {
            public string cpu;
            public string gpu;
            public string ram;
            public string hdd;
            public string sdd;
            public string motherboard;


        }



    }
}