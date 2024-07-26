using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRF.Models
{
    internal class ReadingThree
    {
        public async Task<int> ReadFile(string path)
        {
            string readText = string.Empty;
            readText = File.ReadAllText(path);

            SpaceCount spaceCount = new SpaceCount();

            var spaceC = spaceCount.CountSp(readText);

            return spaceC;
        }
    }
}
