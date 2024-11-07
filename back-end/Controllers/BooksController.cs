using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public BooksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Books
    [HttpGet]
    // public List<Book> GetBooks()
    // {
    //     return _context.Books.ToList();
    // }
    public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks()
    {
        return await _context.Books
            .Select(x => BookToDTO(x))
            .ToListAsync();
    }

    private static BookDTO BookToDTO(Book book) =>
       new BookDTO
       {
           Id = book.Id,
           Name = book.Name,
           Text = book.Text,
           PurchasePrice = book.PurchasePrice,
       };
}
