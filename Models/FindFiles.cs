using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRF.Models
{
    internal class FindFiles
    {
        public List<string> Run(string pathDir)
        {
            List<string> result = new List<string>();

            var bufFiles = Directory.GetFiles(pathDir);


            foreach (var file in bufFiles)
            {
                var exten = Path.GetExtension(file);
                var extenFind = ".txt";

                var compareExten = string.Compare(exten, extenFind);
                if (compareExten == 0)
                {
                    result.Add(file);
                }
            }

            return result;
        }
    }
}
