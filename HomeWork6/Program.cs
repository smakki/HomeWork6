﻿namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var copter = new Quadcopter();
            Console.WriteLine( copter.GetInfo());
            Console.WriteLine(String.Join(',',copter.GetComponents()));
            copter.Charge();

            //Потребовался ~Час
        }
    }
}
