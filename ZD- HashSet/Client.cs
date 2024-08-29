using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD__HashSet
{
    // had linterface mli7a fles structure plus performance 7it kat3tek lojet men naw3 Client bla mat7awlo ou katray7ek men lcast
    // bnisba les class b7al b7al 7it makt7awelch l value type katkhdem ghi breferences types
    internal class Client : IComparable<Client> , IEquatable<Client> 
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

        public bool Equals(Client? other)
        {
            return Telephone == other?.Telephone;
        }
    }
}
