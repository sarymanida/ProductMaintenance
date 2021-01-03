using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Product
    {
        // Public fields
        public string Code;
        public string Description;
        public decimal Price;

        public Product()
        {
        }

        public Product(string code, string description,
            decimal price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        internal object GetDisplayText(string v)
        {
            throw new NotImplementedException();
        }


        public string code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public decimal price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string getDisplayText(string sep)
        {
            return code + sep + price.ToString("c") + sep
                + description;
        }
    }
}




