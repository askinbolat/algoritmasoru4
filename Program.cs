using System;

namespace algoritma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle yazınız:");
            string cümle = Console.ReadLine();

            string[] kelime = cümle.Split();
            Console.WriteLine(kelime.Length);

            string bosluksuzcumle = cümle.Replace(" ","");
            Console.WriteLine(bosluksuzcumle.Length);

            

        }
    }
}