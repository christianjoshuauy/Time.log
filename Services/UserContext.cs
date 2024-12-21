using AttendanceTracker.Models;

namespace AttendanceTracker.Services;

public class UserContext
{

    public Employee CurrentEmployee { get; set; } = null!;
}