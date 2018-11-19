using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace APIcaller
{
    class UserName
    {
        private string _userName;
        //private string _passWord;
        private List<string> _userDetails = new List<string>();

        public void SetName(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                _userName = userName;
            }
            else
            {
                Console.WriteLine("please enter a valid User Name!");
            }
        }

        public string GetName(string userName)
        {
            return userName;
        }




        public List<string> UserInput()
        {

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            Console.WriteLine("Please type your desired user name");
            var userInputName = Console.ReadLine().Trim();

            while (userInputName.Length <= 5 || (regexItem.IsMatch(userInputName) == true))
            {

                Console.WriteLine(userInputName.Length <= 5);
                //this

                Console.WriteLine(regexItem.IsMatch(userInputName));


                Console.WriteLine("Please make your user name longer than 5 characters and contains a special character");

                userInputName = Console.ReadLine();
            }


            Console.WriteLine("Please type your desired password");
            var userInputPass = Console.ReadLine().Trim();

            while (userInputPass.Length <= 5 || (regexItem.IsMatch(userInputPass) == true))
            {
                Console.WriteLine("Please make your password longer than 5 characters");
                userInputPass = Console.ReadLine();
            }
            
            _userDetails.Add(userInputName);
            _userDetails.Add(userInputPass);

            Console.WriteLine("Username: {0} Password:{1}", _userDetails[0], _userDetails[1]);

            return _userDetails;

        }



    }
}
