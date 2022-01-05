using PoductReviewManagementApplication;
Console.WriteLine("\t--------Welcome to product review management---------");
List<ProductReview> ProductReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Very Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 4, Rating = 3, Review = "Very Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 1, Review = "Ok", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 7, Rating = 1, Review = "Ok", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 5, Review = "Very Good", isLike = true }
            };
foreach (var item in ProductReviewlist)
{
    Console.WriteLine("ProductId:" + item.ProductID +" "+ "UserID:" + item.UserID + " " + "Rating:" + item.Rating + " " + "Review:" + item.Review + " " + "isLike:" + item.isLike);
}
//manage is object of management class
Management manage = new Management();
Console.WriteLine("Top 3 records according to rating");
manage.SelectTopThreeRecords(ProductReviewlist);
Console.WriteLine("All record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 ");
manage.RetrieveRecordsUsingRatingAndProductId(ProductReviewlist);
Console.WriteLine("count of review present for each productID");
manage.RetrieveCountOfRecords(ProductReviewlist);
Console.WriteLine("Retrive only product Id");
manage.RetrieveProductIdAndReview(ProductReviewlist);
Console.WriteLine("All records except top 5 records");
manage.SkipTopFiveRecords(ProductReviewlist);
//Console.WriteLine("Product review data table");
//manage.ProductReviewDataTable(ProductReviewlist);
Console.WriteLine("All records whose is like is true");
manage.RetrieveRecordsWhereIslikeTrue(ProductReviewlist);
Console.WriteLine("Average rating of productId");
manage.AverageProductId(ProductReviewlist);

