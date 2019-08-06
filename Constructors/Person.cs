﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {

        public static string test = "TEST";
        public static int cont = 0;
        int id;
        string firstname;
        string lastname;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            cont++;
            firstname = "Marcin";
            lastname = "Kowalski";
            age = 14;

        }

        public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {
            
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.age = age;
            this.gender = gender;

        }

        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            address = "Katowice";
            age = 17;

        }

        public Person(int id, string firstname)
        {
            this.id = id;
            this.firstname = firstname;
        }




    }

   
}
