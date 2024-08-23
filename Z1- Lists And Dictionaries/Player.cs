using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1__Lists_And_Dictionaries
{
    internal class Player
    {
        public int Id { get; set; }
        public string   Name { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public override string ToString()
        {
            return $"{Id} - {Name}.";
        }

    }
}
