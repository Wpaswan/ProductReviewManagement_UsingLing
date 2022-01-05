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
            //ToList() converts the collection to List by using Linq
            var records = (from product in ProductReviewlist orderby product.Rating descending select product).Take(3).ToList();
            Display(records);
        }
        // Retrive All record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using linq
        public void RetrieveRecordsUsingRatingAndProductId(List<ProductReview> ProductReviewlist)
        {
            var records = (from Product in ProductReviewlist where (Product.ProductID == 1 || Product.ProductID == 4 || Product.ProductID == 9) && Product.Rating > 3 select Product).ToList();
            Display(records);
        }
        public void RetrieveCountOfRecords(List<ProductReview> ProductReviewlist)
        {
            var records = ProductReviewlist.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("Product Id" + "-----"+"their numbers");
            foreach (var item in records)
            {
                Console.WriteLine(item.ProductID + "-----"+ item.Count);
            }
        }
        //Method below is for retrive only product Id
        public void RetrieveProductIdAndReview(List<ProductReview> ProductReviewlist)
        {
            var records = from productReview in ProductReviewlist
                          select new { productReview.ProductID, productReview.Review };
            foreach (var list in records)
            {
                Console.WriteLine("ProductId :"+ list.ProductID + " " + "Review :" + list.Review);
            }
        }
        //Method below is for skipping top 5 records
        public void SkipTopFiveRecords(List<ProductReview> ProductReviewlist)
        {
            var records = (from product in ProductReviewlist orderby product.Rating descending select product).Skip(5).ToList();
            Display(records);
        }
    }
}
