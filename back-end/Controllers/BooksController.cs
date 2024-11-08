using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers;
[Authorize]
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

    [AllowAnonymous]
    [HttpGet()]
    public async Task<ActionResult<List<BookResponse>>> GetAvailableBooks()
    {
        var books = new List<BookResponse>();

        if (HttpContext.User.Identity != null && HttpContext.User.Identity.IsAuthenticated)
        {
            var claimsPrincipal = HttpContext.User;
            var user = await _userManager.GetUserAsync(claimsPrincipal);
            if (user is not null)
            {
                books = await _context.Books
                    .Where(b => !b.Subscriptions.Any(s => s.UserId == user.Id))
                    .Select(x => BookResponse.BookToResponse(x))
                    .ToListAsync();
            }
        }
        else
        {
            books = await _context.Books
                .Select(x => BookResponse.BookToResponse(x))
                .ToListAsync();
        }

        return books;
    }
}
