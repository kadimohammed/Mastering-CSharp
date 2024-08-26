using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZC__LinkedList_HashSet_SortedSet
{
    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public Video(int id, string url)
        {
            Id = id;
            Url = url;
        }

        public override string ToString()
        {
            return $"{Id} - {Url}";
        }
    }

    
}
