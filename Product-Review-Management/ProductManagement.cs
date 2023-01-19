﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    internal class ProductManagement
    {
        public static void Top3Records(List<Products> productsReviewList)
        {
            var productdata = (from reviewlist in productsReviewList
                               where reviewlist.Rating == 5
                               select reviewlist).Take(3);
            foreach (var list in productdata)
            {
                Console.WriteLine("ProdcutID " + list.productID + " UserId " + list.UserId + " Rating "
                    + list.Rating + " Review " + list.Review + " IsLike " + list.IsLike);
            }
        }
    }
}
