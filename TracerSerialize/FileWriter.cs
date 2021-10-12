using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TracerSerialize
{
    class FileWriter : IWriter
    {
        string path;

        public FileWriter(string path)
        {
            this.path = path;
        }

        public void Write(string text)
        {
            File.WriteAllText(path, text);
        }
    }
}
