namespace AttendanceTracker.Models;

public class Employee
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string? DiscordAuthToken { get; set; }
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}