using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            // Implement ...
            Console.WriteLine(path);
        }
        public void Activate()
        {
            // Implement ...
        }

        public string ChooseLanguage(int language)
        {
            if (language == 1)
            {
                return "MenuSpecDK.txt";
            }
            else if(language == 2)
            {
                return "MenuSpecENG.txt";
            }

            return "Fejl";
        }
    }

}
