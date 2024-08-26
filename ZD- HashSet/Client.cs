using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD__HashSet
{
    internal class Client : IComparable<Client>
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public Client(string name, string telephone)
        {
            Name = name;
            Telephone = telephone;
        }

        public override bool Equals(object? obj)
        {
            return obj is Client client
                && Telephone == client.Telephone;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Telephone);
        }


        public override string ToString()
        {
            return $"{Name} - {Telephone}";
        }

        public int CompareTo(Client? other)
        {
            if(object.Equals(this, other)) 
                return 0 ;
            if(other == null)
                return -1;

            return this.Telephone.CompareTo(other.Telephone);
        }
    }
}
