using System;
using System.Text;
namespace AdrenoServices
{
    class Program

    {
        static void Main(string[] args)
        {
			
            Console.Title = "Adreno Services";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
         
            Console.WriteLine("Adreno Services starting...");
            Console.WriteLine();
          
            hostsystem.scann.start();
           
            configsys.check_up();
      
            management.controller.start();
      
            management.module.start();
            Console.ReadLine();

        }
    }
}
