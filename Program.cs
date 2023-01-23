
namespace ProductReviewManagment
{
    public class Program    
    {
        public static void Main(string[] args)
        {
            List<ProductReview> productReview = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 2, Rating = 4, Review = "good", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 2, Rating = 3, Review = "good", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 3, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 3, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 2, UserId = 4, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 5, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 1, UserId = 5, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 6, Rating = 4, Review = "good", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 6, Rating = 3, Review = "good", isLike = true },
            };

            //foreach (var list in productReview)
            //{
            //    Console.WriteLine("Product id: " + list.ProductId + " User id: " + list.UserId + " rating : " + list.Rating + " Review: " + list.Review + " isLike " + list.isLike);
            //}

            Mangement mangement = new Mangement();
            // mangement.TopRecords(productReview);
            //mangement.SelectRecordes(productReview);
            mangement.RetriveCountOfRecords(productReview);


        }

    }
}