using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            try
            {
            string[] fileData = File.ReadAllLines(filename);
            //Console.WriteLine(fileData[0]);
            return fileData;
        }
            catch(FileNotFoundException ex) { 

        }
        }
    }
}