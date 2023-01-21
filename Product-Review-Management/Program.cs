using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    internal class program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>()
            {

                 new Products{productID=1,UserId=1,Rating=5,Review="Very Good",IsLike=true},
                 new Products{productID=2,UserId=2,Rating=4,Review="Very Good",IsLike=true},
                 new Products{productID=3,UserId=3,Rating=3,Review=" Good",IsLike=true},
                 new Products{productID=4,UserId=4,Rating=1,Review="Very Bad",IsLike=false},
                 new Products{productID=5,UserId=5,Rating=1,Review="Very Bad",IsLike=false},
                 new Products{productID=6,UserId=6,Rating=1,Review="avrag",IsLike=true},
                 new Products{productID=7,UserId=7,Rating=2,Review="Not Good",IsLike=false},
                 new Products{productID=8,UserId=8,Rating=5,Review="Very Good",IsLike=true},
                 new Products{productID=9,UserId=9,Rating=4,Review="Very Good",IsLike=true},
                 new Products{productID=10,UserId=10,Rating=3,Review=" Good",IsLike=true},
                 new Products{productID=11,UserId=11,Rating=1,Review="Very Bad",IsLike=false},
                 new Products{productID=12,UserId=12,Rating=1,Review="avrag",IsLike=true},
                 new Products{productID=13,UserId=13,Rating=2,Review="Not Good",IsLike=false},
                 new Products{productID=14,UserId=14,Rating=5,Review="Very Good",IsLike=true},
                 new Products{productID=15,UserId=15,Rating=4,Review="Very Good",IsLike=true},
                 new Products{productID=16,UserId=16,Rating=3,Review=" Good",IsLike=true},
                 new Products{productID=17,UserId=17,Rating=1,Review="Very Bad",IsLike=false},
                 new Products{productID=18,UserId=18,Rating=1,Review="avrag",IsLike=true},
                 new Products{productID=19,UserId=19,Rating=2,Review="Not Good",IsLike=false},
                 new Products{productID=20,UserId=20,Rating=5,Review="Very Good",IsLike=true},
                 new Products{productID=21,UserId=21,Rating=4,Review="Very Good",IsLike=true},
                 new Products{productID=22,UserId=22,Rating=3,Review=" Good",IsLike=true},
                 new Products{productID=23,UserId=23,Rating=1,Review="Very Bad",IsLike=false},
                 new Products{productID=24,UserId=24,Rating=1,Review="Very Bad",IsLike=false},
                 new Products{productID=25,UserId=25,Rating=1,Review="avrag",IsLike=true}


            };
            Console.WriteLine("Enter Option\n1.Top3 data with high rating\n2.Retrive data from list\n3.Count of review present for each id\n4.Retreive prodectid and review\n5.Skip Top 5 ");
            int op=Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    ProductManagement.Top3Records(products);
                    break;
                case 2:
                    Console.WriteLine("Enter Option\n1.All data with greater then 3 rating\n2.From productId 1,4,9");
                    int ops = Convert.ToInt16(Console.ReadLine());
                    switch(ops)
                    {
                        case 1:
                            ProductManagement.AllRecord(products);
                            break;
                        case 2:
                            ProductManagement.RetriveFromProductId(products);
                            break;
                    }
                    break;
                case 3:
                    Count.CountOfProduct(products);
                    break;
                case 4:
                    ProductManagement.RetriveProductIdAndReview(products);
                    break;
                    case 5:
                    ProductManagement.SkipTop5(products);
                    break;
                   
            }
            
        }
    }
}