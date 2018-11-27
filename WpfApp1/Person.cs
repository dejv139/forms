using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Person
    {
        public string Name;
        public string Surname;
        public string Email;

        public void AddName(string name)
        {
            this.Name = name;
        }

        public void AddSurname(string surname)
        {
            this.Surname = surname;
        }

        public void AddEmail(string email)
        {
            this.Email = email;
        }
    }

}
