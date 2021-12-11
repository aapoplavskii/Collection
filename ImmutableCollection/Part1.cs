using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableCollection
{
    public class Part1
    {
        public ImmutableList<string> Poem { get; set; }

        string _part;
        public Part1(string part)
        {
            _part = part;   
            ImmutableList<string> poem = ImmutableList.Create<string>();         
        }

        public ImmutableList<string> AddPart(ImmutableList<string> previouslist)
        {
            return Poem = previouslist.Add(_part);
                
        }
    }
}
