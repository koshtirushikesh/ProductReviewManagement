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

    }
}
