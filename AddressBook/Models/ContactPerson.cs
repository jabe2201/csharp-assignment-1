﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    internal class ContactPerson
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
