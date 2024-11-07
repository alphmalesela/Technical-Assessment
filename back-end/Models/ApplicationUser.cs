using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();

}