using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers;

[Authorize]
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

    [HttpGet("{id}")]
    public async Task<ActionResult<SubscriptionResponse>> GetSubscription(int id)
    {

        var sub = await _context.Subscriptions.Where(s => s.Id == id).Include(s => s.Book).ToListAsync();

        if (sub == null)
        {
            return NotFound();
        }

        return SubscriptionResponse.SubToResponseFull(sub.First());
    }

    [HttpGet()]
    public async Task<ActionResult<List<SubscriptionResponse>>> GetSubscriptions()
    {
        var claimsPrincipal = HttpContext.User;
        var user = await _userManager.GetUserAsync(claimsPrincipal);

        if (user == null)
        {
            return Unauthorized();
        }

        var subs = await _context.Subscriptions.Where(s => s.UserId == user.Id).Include(s => s.Book).Select(x => SubscriptionResponse.SubToResponse(x)).ToListAsync();
        return subs;
    }

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