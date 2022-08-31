using System.Net.NetworkInformation;
using System;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {   
           //Program.QuestionTwo();
           try
           {
                Console.WriteLine("Enter number of hour(s) worked per day :");
                int numOfHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Payrol.PayRoll(numOfHours));
           }
           catch (Exception ex)
           {
                Console.WriteLine(ex.Message);
           }
            
        } 
    }
}

