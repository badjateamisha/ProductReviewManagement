// See https://aka.ms/new-console-template for more information
using ProductReviewManagement;

Console.WriteLine("Welcome to Product Review Management !");
/*
 * Rating 1 = Bad
 * Rating 2 = BelowAverage
 * Rating 3 = Average
 * Rating 4 = Good
 * Rating 5 = Excellent
 */


List<ProductReview> productReviewList = new List<ProductReview>();

productReviewList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "Bad", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 2, UserID = 1, Rating = 2, Review = "BelowAverage", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 3, UserID = 1, Rating = 3, Review = "Average", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 4, UserID = 1, Rating = 4, Review = "Good", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 5, UserID = 1, Rating = 5, Review = "Excellent", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 6, UserID = 2, Rating = 1, Review = "Bad", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 7, UserID = 2, Rating = 2, Review = "BelowAverage", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 8, UserID = 2, Rating = 3, Review = "Average", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 9, UserID = 2, Rating = 4, Review = "Good", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 10, UserID = 2, Rating = 5, Review = "Excellent", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 11, UserID = 3, Rating = 1, Review = "Bad", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 12, UserID = 3, Rating = 2, Review = "BelowAverage", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 13, UserID = 3, Rating = 3, Review = "Average", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 14, UserID = 3, Rating = 4, Review = "Good", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 15, UserID = 3, Rating = 5, Review = "Excellent", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 16, UserID = 4, Rating = 1, Review = "Bad", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 17, UserID = 4, Rating = 2, Review = "BelowAverage", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 18, UserID = 4, Rating = 3, Review = "Average", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 19, UserID = 4, Rating = 4, Review = "Good", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 20, UserID = 4, Rating = 5, Review = "Excellent", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 21, UserID = 10, Rating = 1, Review = "Bad", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 22, UserID = 10, Rating = 2, Review = "BelowAverage", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 23, UserID = 10, Rating = 3, Review = "Average", isLike = false });
productReviewList.Add(new ProductReview() { ProductID = 24, UserID = 10, Rating = 4, Review = "Good", isLike = true });
productReviewList.Add(new ProductReview() { ProductID = 25, UserID = 10, Rating = 5, Review = "Excellent", isLike = true });

//Display list
Console.WriteLine("Select \n1)Create Product Review List with 25 Default values\n2)Retrive Top 3 Records with high rating\n3)Details from Records(1,4,9) with rating > 3 \n4)Count By ProductID\n5)Retreive ProductID and ProductReview\n6)Skip top 5 records from the list");
int option = Convert.ToInt16(Console.ReadLine());
switch (option)
{
    case 1:
        foreach (var list in productReviewList)
        {
            Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.isLike);
        }
        break;
    case 2:
        ProductManagement.Top3Records(productReviewList);
        break;
    case 3:
        ProductManagement.RetriveRecords(productReviewList);
        break;
    case 4:
        ProductManagement UC4 = new ProductManagement();
        UC4.CountRecordsbyProductID(productReviewList);
        break;
    case 5:
        foreach (var list in productReviewList)
        {
            Console.WriteLine("ProductID :" + list.ProductID + "  " + "Review :" + list.Review);
        }
        break;
    case 6:
        ProductManagement UC6 = new ProductManagement();
        UC6.SkipTop5Records(productReviewList);
        break;
    default:
        Console.WriteLine("Please choose the correct option!");
        break;
}