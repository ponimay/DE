using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DE.AppData
{
    public class CalculateMaterial
    {
        public static int Cal(int prodTypeID, int materialTypeID, int counted, int storage, decimal a, decimal b)
        {
            if(!Connect.con.MaterialType.Any(x=> x.MaterialTypeID == materialTypeID) || 
                !Connect.con.ProductType.Any(x => x.ProductTypeID == prodTypeID) || 
                !Connect.con.Product.Any(x=>x.ProductCount == counted) || a<= 0 || b <= 0 || 
                storage <=0 || counted <=0)
            {
                return -1;
            }

            int toProduce = Math.Min(counted, storage);

            decimal perUnit = a * b * Connect.con.ProductType.FirstOrDefault(x=>x.ProductTypeID==prodTypeID).ProductTypeK;

            decimal total = perUnit * toProduce * 
                (1 + Connect.con.MaterialType.FirstOrDefault(x => x.MaterialTypeID == materialTypeID)
                .MaterialTypeDefectPercent / 100m);

            return (int)Math.Ceiling(total);
        }
    }
}
