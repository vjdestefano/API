using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIcaller
{
    class Program
    {
        static void Main(string[] args)
        {
           var userDetials = new UserName();
           var user = userDetials.UserInput();

           var stateSelection = new SelectOption();
           stateSelection.SetState("main menu", user);
            
        }
    }
}
