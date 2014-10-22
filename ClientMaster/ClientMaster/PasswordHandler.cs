using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMaster
{
    class PasswordHandler
    {
        public static string[] ReadPasswordFile(String filename)
        {

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(":".ToCharArray());
                    
                    return parts;
                }
                
            }
        }
    }
}
