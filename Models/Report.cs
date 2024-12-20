namespace AttendanceTracker.Models;

public class Report
{
    public int Id { get; set; }
    public int AttendanceId { get; set; }
    public Attendance Attendance { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
}