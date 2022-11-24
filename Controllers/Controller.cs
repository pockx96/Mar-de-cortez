using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDeCortezDsk.Controllers
{
    public class Controller
    {
        public string connectionString = "Server=localhost;Database=mdc; Uid=root;Pwd=root;";
        public string stringToDb(string word)
        {
            int lenght = 50 - word.Length;
            string StringDb = word;
            for (int i = 0; i < lenght; i++)
            {
                StringDb = StringDb + " ";
            }
            return StringDb;
        }
    }
   
}
