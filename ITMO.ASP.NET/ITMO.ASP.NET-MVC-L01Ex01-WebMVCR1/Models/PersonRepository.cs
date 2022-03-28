﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMO.ASP.NET_MVC_L01Ex01_WebMVCR1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();

        public int NumberOfPerson
        {
            get
            {
                return persons.Count();
            }
        }
        public IEnumerable<Person> GetAllResponses
        {
            get
            {
                return persons;
            }
        }

        public void AddResponse(Person pers)
        {
            persons.Add(pers); 
        }
    }
      
}
