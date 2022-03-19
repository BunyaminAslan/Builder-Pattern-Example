using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        //void BuildPartA();
        //void BuildPartB();
        //void BuildPartC();


        void BuildPart();

        public Product GetProduct();
    }
}
