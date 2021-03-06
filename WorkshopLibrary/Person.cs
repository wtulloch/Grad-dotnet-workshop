﻿using System;
using System.Collections.Generic;

namespace WorkshopLibrary
{
    public class Person
    {
        public const string unknownUser = "Unknown User";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public int Age
        {
            get { return CurrentAge(); }
        }
        public string DisplayName()
        {
            if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrEmpty(LastName))
            {
                return unknownUser;
            }

            var firstName = FirstName ?? "*****";
            return $"{firstName} {LastName}";
        }

        private int CurrentAge()
        {
            if (DoB.HasValue)
            {
                int age = 0;
                age = DateTime.Now.Year - DoB.Value.Year;
                if (DateTime.Now.DayOfYear < DoB.Value.DayOfYear)
                    age = age - 1;

                return age;
            }
            return 0;
        }
    }

   
    
}
