using BuilderPattern.Interfaces;
using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Classes.ProdutsOperation
{
    public class PartA : Part, IBuilder
    {
        //private Product _product = new Product();

        public void BuildPart()
        {
            //this._product.Add("PartC1");
            _product.Add("PartA1");

        }
        public PartA()
        {
            //this.Reset();
        }

        public void Reset()
        {
            //this._product = new Product();
            _product = new Product();

        }
        public Product GetProduct()
        {
            //Product result = this._product;
            Product result = _product;


            //this.Reset();

            return result;
        }
    }
}
