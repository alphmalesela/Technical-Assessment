public class BookResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }
    public bool? Subscribed { get; set; }
    public decimal PurchasePrice { get; set; }

    public static BookResponse BookToResponse(Book book) =>
       new BookResponse
       {
           Id = book.Id,
           Name = book.Name,
           PurchasePrice = book.PurchasePrice,
       };

    public static BookResponse BookToFullResponse(Book book) =>
       new BookResponse
       {
           Id = book.Id,
           Name = book.Name,
           Text = book.Text,
           PurchasePrice = book.PurchasePrice,
           Subscribed = false
       };

    public static BookResponse BookToFullSubscribedResponse(Book book) =>
       new BookResponse
       {
           Id = book.Id,
           Name = book.Name,
           Text = book.Text,
           PurchasePrice = book.PurchasePrice,
           Subscribed = true
       };
}