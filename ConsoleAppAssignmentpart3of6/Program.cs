using System;
//CONSOLE APP PART THREE ASSIGNMENT

//Add the following to your console app and perform these actions:

//A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

//Save and execute your code.

//Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
namespace ConsoleAppAssignmentpart3of6
{
    class Program
    {
        static void Main(string[] args)
        {//A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            //this is a for loop inititalizing int i with value zero. it says that as long as i is less than 11, to add one to it incrementally. 
            //the result is to print numbers 0-10 to the console in order; one by one.
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            //Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            //this for loop will start at 20 and then count off by 20's until it reaches 100. 
            for (int x = 20; x <= 100; x = x + 20)
            {
                Console.WriteLine(x);
            }
        }
    }
}


