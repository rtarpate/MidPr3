using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declares vairble for user input
            string userinput;

            //decalres varible for revesre string
            string Ruserinput;

            //decalres varible for count vowels
            int vcount = 0;

            //decalres varibale for palindrome
            string palinuserinptu;

            //promt user input
            Console.WriteLine("enter a string");

            //collects user input
            userinput = Console.ReadLine();

            //set Ruserinput = the reverser sting
            Ruserinput = RevesreString(userinput);

            //sets vcount = the total vowel count
            vcount = CountVowels(userinput);

            //checks for palindrome
            
            palinuserinptu = CheckPalindrome(userinput);
            

            //displays results
            Console.WriteLine("the orginal user input " + userinput + "\n" +
                "reverse string " + Ruserinput + "\n" +
                "vowel count " + vcount + "\n" +
                "check of palindrom " + palinuserinptu );




        }
        //method to revesre string
        static string RevesreString(string userinput)
        {
            //decavlers varible for reveser string
            string revesrestring;





            //creates a new array using user input
            // Char[] UserArray = new Char[userinput.Length];


            //revesers array
            // Array.Reverse(UserArray);

            /*
            Convert.ToInt32(userinput);

            Math.Abs(userinput.Length);

            revesrestring = Convert.ToString(userinput);

            return revesrestring;
            */

            Convert.ToByte(userinput, 16);

            Math.Abs

            
            foreach (char c in userinput)
            {

                c = 

     
            }
            revesrestring = userinput;
            


            /*
        revesrestring = userinput;

        return revesrestring;
        /*
        //array and sets it = reversstring 
        return new string(UserArray);

        //retruns the revessstring
        return revesrestring;
        */

            return revesrestring;
                

        }

        //method to count vowels
        static int CountVowels(string userinput)
        {
            //declares varibel for vowel count
            int vowelcount = 0;

            //decalvers varibel for vowels
            string vowels = "aeiouAEIOU";

            //foreach loop to count vowels
            foreach (char c in userinput)
            {
                //checks if vowel is found and adds 1 to vowelcount
                if (vowels.Contains(c))
                {
                    vowelcount++;
                }
            }

            //retruns the vowel count
            return vowelcount;
        }

        //method to check palindrome
        static string CheckPalindrome(string userinput)
        {

            //decavlers varible for reveser string
            string revesrestring;
            /*
            //creates a new array using user input
            Char[] UserArray = new Char[userinput.Length];

            //revesers array
            Array.Reverse(UserArray);

            //array and sets it = reversstring 
            revesrestring = new string(UserArray);
            */


            Convert.ToInt32(userinput);

            Math.Abs(userinput.Length);

            revesrestring = Convert.ToString(userinput);

            return revesrestring;

            //uses if statment to check it palindrome 

            if (userinput.ToLower() == revesrestring.ToLower())
            {
                return "the user input is a palindrome\n" +
                      userinput + " = " + revesrestring;
            }
            else
            {
                return " the user input is not a palindrome \n " +
                    userinput + " does not equal " + revesrestring;
            }
            
           


        }


    }

    
}
