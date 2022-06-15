using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {

        public static void Top3Records(List<ProductReview> productReviewList)
        {


            var ProductData = (from ProductReview in productReviewList orderby ProductReview.Rating descending select ProductReview).Take(3);


            foreach (var list in ProductData)
            {
                Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
            }
        }


        /// Retrive all data from list whose rating greater than 3 from records 1,4,9

        public static void RetriveRecords(List<ProductReview> productreviewlist)
        {
            var ProductData = (from productReviews in productreviewlist
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews);

            foreach (var list in ProductData)
            {
                Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
            }
        }
        public void CountRecordsbyProductID(List<ProductReview> productreviewlist)
        {
            foreach (var line in productreviewlist.GroupBy(info => info.ProductID)
                           .Select(group => new
                           {
                               products = group.Key,
                               Count = group.Count()

                           }).OrderBy(x => x.products))

            {
                Console.WriteLine("Product Id:{0} => Count :{1}", line.products, line.Count);
            }
        }
        /// Skip top 5 records from List
        public void SkipTop5Records(List<ProductReview> productreviewlist)
        {
            foreach (var productData in (from productReviews in productreviewlist
                                         select productReviews).Skip(5))
            {
                Console.WriteLine("Product Id:{0},UserID:{1},Review:{2},Rating:{3},isLike:{4}",
                    productData.ProductID, productData.UserID, productData.Review, productData.Rating, productData.isLike);
            }
        }
    }
}