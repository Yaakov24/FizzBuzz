using System;

namespace Fizzbuzz
{
    public class Program
    {
     
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int num = int.Parse(Console.ReadLine());
              var num1 =  FizzBuzz(num);
            Console.WriteLine(num1);

        }

        public static string FizzBuzz( int num)
        {
            var answer = "";

            if (num % 3 == 0)
            {   
                answer = "Fizz";
            }
              
            if (num % 5 == 0)
            {

                answer += "Buzz";
            }
           
            return answer;
        }

    }



}




