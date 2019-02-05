using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Author(string name, string email)
        {
            Name = name;
            Email = email;

            if (email.Contains("@gmail.com"))
            {
                this.Email = email;
            }
            else
            {
                Console.WriteLine("Email invaild");
                
            }


        }

        public void Print()
        {
            Console.WriteLine($"Autorul {Name} are emailul {Email}");
        }

        
    }
}
