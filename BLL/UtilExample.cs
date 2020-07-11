using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BLL
{
    public static class UtilExample
    {
        public static string ExampleLoadingFile(string fileName)
        {

            if (fileName.Length < 10)
            {
                // throw new FileNotFoundException();
                throw new ArgumentException("the file Name is too Short", "file");
            }
            return "The file was correctly loaded";
        }
    }
}
