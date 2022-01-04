using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoductReviewManagementApplication
{
    public class Management
    {
        public void Display(List<ProductReview> ProductReviewlist)
        {

            foreach (var item in ProductReviewlist)
            {
                Console.WriteLine("ProductId:" + item.ProductID + " " + "UserID:" + item.UserID + " " + "Rating:" + item.Rating + " " + "Review:" + item.Review + " " + "isLike:" + item.isLike);
            }
        }
        public void SelectTopThreeRecords(List<ProductReview> ProductReviewlist)
        {
            var records = (from product in ProductReviewlist orderby product.Rating descending select product).Take(3).ToList();
            Display(records);
        }
    }
}
