using System;

namespace decimal_a_binario
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int n;
            string binario = "";
            int i;

            Console.WriteLine("ingrese el valor decimal");
            n = Int32.Parse(Console.ReadLine());

            if (n != 1)
            {
                for (i = n; i != 0 && i != 1; i = i / 2) ;
                {
                    binario = (i % 2) + binario;
                }
                if (i == 0)
                {
                    Console.WriteLine("El valor binario es 0");
                    Console.ReadLine();
                }
                else
                {
                    binario = 1 + binario;
                    Console.WriteLine("El valor binario es :{0}" , binario);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("El valor binario es 1");
                Console.ReadLine();

            }
        }    
    }
}
