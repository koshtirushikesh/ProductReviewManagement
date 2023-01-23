using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagment
{
    public class Mangement
    {
        public void TopRecords(List<ProductReview> review) 
        {
            var recordData= (from productReview in review
                             orderby productReview.Rating descending
                             select productReview).Take(3);

            foreach(var list in recordData) 
            {
                Console.WriteLine("Product id: " + list.ProductId + " User id: " + list.UserId + " rating : " + list.Rating + " Review: " + list.Review + " isLike " + list.isLike);
            }
        }
        public void SelectRecordes(List<ProductReview> review)
        {
            var recordData = from product in review
                             where (product.ProductId == 1 && product.Rating > 3) ||
                             (product.ProductId == 4 && product.Rating > 3) ||
                             (product.ProductId == 9 && product.Rating > 3)
                             select product;

            foreach (var list in recordData)
            {
                Console.WriteLine("Product id: " + list.ProductId + " User id: " + list.UserId + " rating : " + list.Rating + " Review: " + list.Review + " isLike " + list.isLike);
            }
        }
        public void RetriveCountOfRecords(List<ProductReview> reviews)
        {
            var records = reviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, count = x.Count() });

            foreach (var record in records)
            {
                Console.WriteLine(record.ProductId + "------------" + record.count);
            }

        }

    }
}
