using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    internal class FileManager
    {
        public void Save(string filePath, string content)
        { 
            using var sw = new StreamWriter(filePath);
            sw.Write(content);
        }


    }
}
