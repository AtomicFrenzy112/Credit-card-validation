using System;
using System.Linq;

namespace Credit_Card_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Takes in a credit card number from a common 
             * credit card vendor (Visa, MasterCard,
             * American Express, Discoverer) and validates
             * it to make sure that it is a valid number 
             * (look into how credit cards use a checksum).*/

            /**/

            Console.WriteLine("Enter Credit Card number");
           
            string creditNum = Console.ReadLine();
            int arraySum = 0;
            

            char[] characters = creditNum.ToCharArray();
            int[] digitArray = characters.Select(i => Int32.Parse(i.ToString())).ToArray();
            
            for(int i = 14; i >= 0; i = i- 2)
            {
                digitArray[i] = digitArray[i] * 2;
                digitArray[i] = (digitArray[i] % 10) + (digitArray[i]-digitArray[i] % 10)/10;
                
            }
            
            for(int s = 0; s < 15; s++)
            {
                arraySum += digitArray[s];    
            }

            

            int num2 = arraySum * 9;
           
            int checkSum = num2 % 10;
        
            if(checkSum == digitArray[15])
            {
                Console.WriteLine("Credit card number is valid");

            }
            else
            {
                Console.WriteLine("Credit card number is invalid");
            }
        }
    }
}
