using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DE.AppData
{
    internal class Nav
    {
        public static Frame frame;
        public static TextBlock textBlock;
    }
    
    public partial class Partner
    {
        public decimal ProductCost
        {
            get
            {
                return RequestProduct.Sum(x => decimal.Ceiling(x.Product.ProductMinPrice * x.Quantity));
            }


        }

    }
}
