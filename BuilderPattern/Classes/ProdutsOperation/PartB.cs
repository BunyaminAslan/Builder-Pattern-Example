using BuilderPattern.Interfaces;
using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Classes.ProdutsOperation
{
    public class PartB : Part, IBuilder
    {
        //private Product _product = new Product();

        public void BuildPart()
        {
            /*this.*/_product.Add("PartB1");
        }
        public PartB()
        {
            ///*this.*/Reset();
        }

        public void Reset()
        {
            /*this.*/_product = new Product();
        }
        public Product GetProduct()
        {
            Product result = /*this.*/_product;

            ///*this.*/Reset();

            return result;
        }
    }
}
