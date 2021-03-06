﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencje
{
    class Computer
    { 
        public static int initCounter = 0;

        private string _name;

        

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangerEventArgs args = new NameChangerEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }

                    _name = value;
                } else
                {
                    _name = "Default name";
                }
            }
        }


        public event NameChangerDelegate NameChanged;


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