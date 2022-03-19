using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }


        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}
