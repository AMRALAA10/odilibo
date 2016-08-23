using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odilibo.Helpers
{
    public static class FileManager
    {

        public static void CreateFile(string path, string fileName)
        {
            CreateFile(path, fileName, "");
        }

        public static void CreateFile(string path, string fileName, string text)
        {
            var filePath = Path.Combine(path, fileName);
            File.Create(filePath).Close();
            File.WriteAllText(filePath, text);
        }
    }
}
