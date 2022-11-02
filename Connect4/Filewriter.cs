using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Filewriter
    {

        public Filewriter() { }

        public static async Task Write(string[] results, string file)
        {

            await File.WriteAllLinesAsync(file , results);

        }
    }
}
