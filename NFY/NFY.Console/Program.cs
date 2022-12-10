namespace NFY.Console
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"{args[0]} {args[1]}");
            // Console.BackgroundColor= ConsoleColor.Green;
            // Console.ForegroundColor= ConsoleColor.Yellow;

            /* asdfasdfşsahş asjdfşaskdfsad
             * asdfasdfasdfdsf
             */

            //int a = 5;
            //bool flag = true;
            //Person pAlper = new Person();

            //Console.WriteLine("Adınızı Giriniz : ");
            //string? ad = Console.ReadLine();

            //Console.WriteLine(ad[0]);

            //Console.WriteLine("Hello, World! - {0}-{1}", ad, 555);


            short shrt = 15;
            int intV = 15;
            shrt = 10;

            Console.WriteLine(shrt);
            
            intV = shrt;

            shrt = (short)intV;

            var deger = 15;
            var deger4 = 15.5;
            var deger2 = "alper";
            var deger3 = true;

            var deger5 = 1215L;
            var deger6 = 1_215.85M;

        }
    }
}