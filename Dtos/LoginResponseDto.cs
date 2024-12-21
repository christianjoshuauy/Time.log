namespace AttendanceTracker.Dtos;

public class LoginResponseDto
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string FirstName { get; set; } = null!;
}