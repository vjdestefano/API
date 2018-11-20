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
           var userDetails = new UserName();
           var user = userDetails.UserInput();

           var stateSelection = new SelectOption();
           var state = stateSelection.SetState("main menu", user);
           while((state == "main menu" || state == "mainmenu") || (state == "options" || state == "option"))
            {
                stateSelection.SetState(stateSelection.InputState(user), user);
                
            }



        }
    }
}
