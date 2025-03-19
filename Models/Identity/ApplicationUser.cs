using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    // Additional common properties
    public string Name { get; set; } = string.Empty;
}