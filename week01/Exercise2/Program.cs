using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello student,what is your grade percentage? ");
        string letter_grade = Console.ReadLine();
        int grade = int.Parse(letter_grade); 
        
         char letter =' ';
         string sign = ""; 

        if (grade >= 90)
        {
            letter = 'A'; 
        }

        else if (grade >= 80 && grade < 90)
        {
            letter = 'B'; 
        }
        
        else if (grade >= 70 && grade < 80)
        {
             letter = 'C';
        }
           
        
        else if (grade >= 60 && grade < 70)
        {
             letter = 'D';
        }
        
        else 
        {
            letter = 'F'; 
        }

         
        if (letter != 'A' && letter != 'F') 
        {
            int lastDigit = grade % 10; 

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");   

        if ( grade >= 70 ) 
        {
            Console.Write("Congratulations you passed the class: "); 
        }
        else 
        {
           Console.Write("Remember fail just means:  "); 
           Console.Write("First attemp in learning" );  
           
           
        }


        Console.Clear(); 
    }

}