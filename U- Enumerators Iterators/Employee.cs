using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U__Enumerators_Iterators
{
    internal class Employee
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public double salaire { get; set; }



        public Employee()
        {
            
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   nom == employee.nom &&
                   prenom == employee.prenom &&
                   salaire == employee.salaire;
        }
        /*
        public override int GetHashCode()
        {
            return HashCode.Combine(nom, prenom, salaire);
        }*/

        public override int GetHashCode()
        {
            int hash = 17;
       
            hash = (hash * 31) + (nom != null ? nom.GetHashCode() : 0);
            hash = (hash * 31) + (prenom != null ? prenom.GetHashCode() : 0);
            hash = (hash * 31) + salaire.GetHashCode();

            return hash;
        }


        public static bool operator ==(Employee a, Employee b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Employee a, Employee b) => !a.Equals(b);
    }
}
