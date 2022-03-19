using BuilderPattern.Classes;
using BuilderPattern.Classes.ProdutsOperation;
using BuilderPattern.Interfaces;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            IBuilder builder = new PartC();
            director.Builder = builder;

            director.BuildViableProduct();

            Console.WriteLine(builder.GetProduct().ListParts());

            builder = new PartA();
            director.Builder = builder;

            director.BuildViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            builder = new PartB();
            director.Builder = builder;

            director.BuildViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.ReadKey();
        }
    }
}
