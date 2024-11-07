public class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }
    public decimal PurchasePrice { get; set; }
    public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();

}