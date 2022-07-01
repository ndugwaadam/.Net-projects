using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a simple Quiz...

            Console.WriteLine("\t \t \tWelcome to the Program test 1\n");
            Console.Write("Enter your Name : ");
            String a = Console.ReadLine();
            Console.Write("Enter your class : ");
            String a1 = Console.ReadLine();


            //Writing the questions
            Console.WriteLine("\n\t\t\t The Math Quiz For Primay 2\n");
            Console.WriteLine("\n(select the letter with the correct answer)\n\n ");


            //Question 1
            Console.WriteLine("Qn 1: what is the sum of 3 boys in P.2a and 4 boys in P.2b ?");
            Console.WriteLine("a). 5 boys \t b). 2 boys \t c). 7 boys\n");
            Console.Write("Enter the letter with the correct answer : ");
            char b1 =Convert.ToChar(Console.ReadLine());
            if(b1 == 'c')
            {
                
            }


            //showing the results
            Console.Write("\n\nName  : "+a);
            Console.Write("\t\tClass : " +a1);
            Console.WriteLine("\n\n Answers\n .......");

            //question

            if (b1 == 'c')
            {
                Console.WriteLine("\nCorrect answer");
            }
            else
             {
                Console.WriteLine("\nWrong answer");
            }



            Console.ReadKey();
        

     } 
    }
}
