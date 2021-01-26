using System;

namespace SyantaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converting the code to string interoplation
            int answer = 4; 
            string response = (answer<9) ? $"{answer} is less than nine": $"{answer} is greater than or equal nine";
            Console.WriteLine(response);


            // Learnig Inline/Ternary Operator 
            var myName = "Hossain";
            var printMyName = (myName == "Hossain") ? $"My name is {myName}" : $"This is not your name";
            Console.WriteLine(printMyName);

          
            // Learning Composite Formating
            var dogName = "Jack";
            var dogAge = 8;
            var runTime = 10;
            Console.WriteLine("My dog name is {0}, and jack is  {1} year olds." +
                " Everyday Jack run at least {2} miles.", dogName, dogAge, runTime );





        }
    }
}
