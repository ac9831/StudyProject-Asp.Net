using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dul
{
    public class FileUtility
    {
        public static string GetFileNameWithNumbering(string dir, string name)
        {
            string strName = Path.GetFileNameWithoutExtension(name);
            string strExt = Path.GetExtension(name);
            int i = 0;
            bool blnExists = true;
            while(blnExists)
            {
                if(File.Exists(Path.Combine(dir, name)))
                {
                    name = strName + "(" + ++i + ")" + strExt;
                }
                else
                {
                    blnExists = false;
                }
            }

            return name;
        }
    }
}
