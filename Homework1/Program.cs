// See https://aka.ms/new-console-template for more information
namespace HelloName
{ 
    public class Program 
    { 
        public static void Main() 
        { 
           SayHello(); 
        } 
 
        public static void SayHello () 
        { 
            Console.WriteLine ("Write your name here: "); 
            var name = Console.ReadLine (); 
            Console.WriteLine (name + ", Hello!"); 
        } 
    } 
}