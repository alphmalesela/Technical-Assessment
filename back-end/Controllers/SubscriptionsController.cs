using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscriptionsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;


    public SubscriptionsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // GET: api/Subscriptions
    [Authorize]
    [HttpGet()]
    public async Task<ActionResult<SubscriptionsResponse>> GetSubscriptions()
    {
        var claimsPrincipal = HttpContext.User;
        var user = await _userManager.GetUserAsync(claimsPrincipal);

        if (user == null)
        {
            return Unauthorized();
        }

        var books = await _context.Books.Where(b => b.Subscriptions.Any(s => s.UserId == user.Id)).Select(x => BookResponse.BookToResponse(x)).ToListAsync();
        return new SubscriptionsResponse()
        {
            Subscriptions = books
        };
    }

    [Authorize]
    [HttpPost("add")]
    public async Task<ActionResult> AddSubscription([FromBody] AddSubscriptionRequest request)
    {
        var claimsPrincipal = HttpContext.User;
        var user = await _userManager.GetUserAsync(claimsPrincipal);

        if (user == null)
        {
            return Unauthorized();
        }

        _context.Subscriptions.Add(new Subscription
        {
            BookId = request.BookId,
            UserId = user.Id
        });

        await _context.SaveChangesAsync();

        return Created();
    }

}