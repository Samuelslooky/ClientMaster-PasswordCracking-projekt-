﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientMaster
{
    class PasswordHandler
    {
        public static string ReadPasswordFile(String filename)
        {

            string result = null;

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {

                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    String[] parts = line.Split(":".ToCharArray());
                    string userinfo = new UserInfo(parts[0], parts[1]);
                    result.Add(userInfo);
                }
                return result;
            }
        }
    }
}