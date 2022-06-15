using System;
using System.Data;
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
        //Retrive ProductID and Review using SELECT operator
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReviews)
        {
            //lambda syntax
            var recordData = listProductReviews.Select(x => new { ProductId = x.ProductID, Review = x.Review });
            Console.WriteLine("\nProduct id and review = ");
            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Review);
            }
        }
        ///create DataTable
        public void Datatables()
        {
            //created datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Review");
            dt.Columns.Add("Islike");
            //created row
            dt.Rows.Add("1", "1", "1", "Bad", "False");
            dt.Rows.Add("2", "1", "2", "BelowAverage", "False");
            dt.Rows.Add("3", "1", "3", "Average", "False");
            dt.Rows.Add("4", "1", "4", "Good", "True");
            dt.Rows.Add("5", "1", "5", "Excellent", "True");

            dt.Rows.Add("6", "2", "1", "Bad", "False");
            dt.Rows.Add("7", "2", "2", "BelowAverage", "False");
            dt.Rows.Add("8", "2", "3", "Average", "False");
            dt.Rows.Add("9", "2", "4", "Good", "True");
            dt.Rows.Add("10", "2", "5", "Excellent", "True");

            dt.Rows.Add("11", "3", "1", "Bad", "False");
            dt.Rows.Add("12", "3", "2", "BelowAverage", "False");
            dt.Rows.Add("13", "3", "3", "Average", "False");
            dt.Rows.Add("14", "3", "4", "Good", "True");
            dt.Rows.Add("15", "3", "5", "Excellent", "True");

            dt.Rows.Add("16", "4", "1", "Bad", "False");
            dt.Rows.Add("17", "4", "2", "BelowAverage", "False");
            dt.Rows.Add("18", "4", "3", "Average", "False");
            dt.Rows.Add("19", "4", "4", "Good", "True");
            dt.Rows.Add("20", "4", "5", "Excellent", "True");

            dt.Rows.Add("21", "10", "1", "Bad", "False");
            dt.Rows.Add("22", "10", "2", "BelowAverage", "False");
            dt.Rows.Add("23", "10", "3", "Average", "False");
            dt.Rows.Add("24", "10", "4", "Good", "True");
            dt.Rows.Add("25", "10", "5", "Excellent", "True");



            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Rating"]}\t|{row["Review"]}\t|{row["Islike"]}");
            }
        }

    }
}