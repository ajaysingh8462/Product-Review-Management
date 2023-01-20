using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    internal class Count
    {
        public static void CountOfProduct(List<Products> productsReviewList)
        {
            var res = from C in productsReviewList
                      group C by C.Review;

            foreach (var val in res)
            {

                Console.WriteLine("Group By Review: {0}", val.Key);             

                foreach (Products C in val)
                {
                    Console.WriteLine("ProductId: {0}",
                                               C.productID);
                }
            }

        }
    }
}
