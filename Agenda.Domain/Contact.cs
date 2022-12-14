using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Domain.Core;
using Agenda.Domain.Domain;

namespace Agenda.Domain
{
    public class Contact: Register
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
    }
}