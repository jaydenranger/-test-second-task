using System;

namespace NumberOne
{
    class Program
    {
        static void Main(string[] args)
        {
           var number = 0; 
           var counter = 10;

            for( var i = 0; i< counter; i++)
            {
            
            Console.WriteLine("Give me a number");
            var isNumber = int.TryParse(Console.ReadLine(), out int input);
            number += input; 

            }

            Console.WriteLine($"Your total = {number}");
            Console.WriteLine($" The Average = {(double)number / counter}");
            
              
        
        
        }


    }
}
