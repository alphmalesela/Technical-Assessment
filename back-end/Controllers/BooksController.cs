using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public BooksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // GET: api/Books
    [HttpGet]
    public async Task<ActionResult<GetBooksResponse>> GetBooks()
    {
        var books = await _context.Books
            .Select(x => BookResponse.BookToResponse(x))
            .ToListAsync();

        return new GetBooksResponse()
        {
            Books = books
        };
    }

    [Authorize]
    [HttpGet("available")]
    public async Task<ActionResult<GetAvailableBooksResponse>> GetAvailableBooks()
    {
        var claimsPrincipal = HttpContext.User;
        var user = await _userManager.GetUserAsync(claimsPrincipal);

        if (user == null)
        {
            return Unauthorized();
        }

        var books = await _context.Books.Where(b => !b.Subscriptions.Any(s => s.UserId == user.Id)).Select(x => BookResponse.BookToResponse(x)).ToListAsync();
        return new GetAvailableBooksResponse()
        {
            Books = books
        };
    }

}
