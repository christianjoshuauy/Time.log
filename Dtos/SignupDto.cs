namespace AttendanceTracker.Dtos;

public class SignupDto
{
    public string Username { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string DiscordAuthToken { get; set; } = null!;
}