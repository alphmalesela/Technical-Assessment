public class SubscriptionResponse
{
    public int Id { get; set; }
    public string? BookName { get; set; }
    public string? BookText { get; set; }
    public decimal BookPurchasePrice { get; set; }

    public static SubscriptionResponse SubToResponse(Subscription subscription) =>
       new SubscriptionResponse
       {
           Id = subscription.Id,
           BookName = subscription.Book!.Name,
           BookPurchasePrice = subscription.Book.PurchasePrice,
       };

    public static SubscriptionResponse SubToResponseFull(Subscription subscription) =>
           new SubscriptionResponse
           {
               Id = subscription.Id,
               BookName = subscription.Book!.Name,
               BookPurchasePrice = subscription.Book.PurchasePrice,
               BookText = subscription.Book!.Text
           };
}