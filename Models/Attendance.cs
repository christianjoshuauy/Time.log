namespace AttendanceTracker.Models;

public class Attendance
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public DateTime TimeIn { get; set; }
    public DateTime? TimeOut { get; set; }
}