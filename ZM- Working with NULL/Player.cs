#nullable enable  // taf3il nullable fichier wa7ed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZM__Working_with_NULL
{
    internal class Player
    {
        public string? Name { get; set; }

        public Player(string? name)
        {
            if (name is null)
            {
                Name = "kadi mohammed";
            }
            else
            {
                Name = name;
            }
        }
    }
}
#nullable restore