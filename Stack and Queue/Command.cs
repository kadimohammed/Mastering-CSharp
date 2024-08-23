using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class Command
    {
        public int Id { get; set; }
        public string Url { get; set; }
        private static int _cmp = 1;

        public Command(string url)
        {
            this.Id = _cmp++;
            this.Url = url;
        }

        public override string ToString()
        {
            return $"{Id} - {Url}";
        }


    }
}
