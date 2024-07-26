using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRF.Models
{
    internal class SpaceCount
    {
        public int CountSp(string text)
        {
            var space = text.Count(x => x == ' ');

            return space;
        }
    }
}
