using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMaster
{
    public class Filehandler
    {

        public void OpenDictionary()
        {
            string[] userInfos = PasswordHandler.ReadPasswordFile("passwords.txt");
            using (FileStream fs = new FileStream("webster-dictionary.txt", FileMode.Open, FileAccess.Read))
        }
        
        


    }
}
