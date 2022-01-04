using PoductReviewManagementApplication;
Console.WriteLine("\t--------Welcome to product review management---------");
List<ProductReview> ProductReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 3, Review = "Very Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 4, Rating = 3, Review = "Very Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 1, Review = "Ok", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 7, Rating = 1, Review = "Ok", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 3, Review = "Very Good", isLike = true }
            };
foreach (var item in ProductReviewlist)
{
    Console.WriteLine("ProductId:" + item.ProductID +" "+ "UserID:" + item.UserID + " " + "Rating:" + item.Rating + " " + "Review:" + item.Review + " " + "isLike:" + item.isLike);
}