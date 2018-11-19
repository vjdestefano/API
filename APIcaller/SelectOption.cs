using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIcaller
{
    class SelectOption
    {
        //sets the state that can determine what the program shows for the main menu 
        private string _state;

        
        public void SetState(string state, List<string> user)
        {

            if (state == "main menu" || state == "mainmenu")
            {  
                 Console.WriteLine("_____________Main Menu____________");
                 //Console.WriteLine("Edit Inventory");
                 //Console.WriteLine("Browse Inventory");
                 Console.WriteLine("options");
                 Console.WriteLine("*EXIT*");

                 _state = state;
                 InputState(user);

            }
            if (state == "options" || state == "option")
            {
                Console.WriteLine("_____________Options____________");

                Console.WriteLine("Username: {0} Password:{1}",user[0], user[1]);

                Console.WriteLine("Main Menu");
                //Console.WriteLine("Edit Inventory");
                //Console.WriteLine("Browse Inventory");
                Console.WriteLine("*EXIT*");

                _state = state;
                InputState(user);


            }
            else{
                Console.WriteLine("Please Select a Vaild option");
                InputState(user);
            }

        }

        public void InputState(List<string> user)
        {
            Console.WriteLine("Please Enter your state");
            string state = Console.ReadLine().ToLower();
            SetState(state, user);

        }

        public string GetState()
        {
            return _state;
        }













    }
}
