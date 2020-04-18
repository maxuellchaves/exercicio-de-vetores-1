using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_vect_1
{
    class Aluguel
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public int  Quartos { get; set; }

        public Aluguel(string name, string email, int quartos)
        {
            Name = name;
            Email = email;
            Quartos = quartos;
        }


        public override string ToString()
        {
            StringBuilder os = new StringBuilder();
            os.Append(Quartos+": ");
            os.Append(Name + ", ");
            os.Append(Email);

            return os.ToString();


        }
    }
}
