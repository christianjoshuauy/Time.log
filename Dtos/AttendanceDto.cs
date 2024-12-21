namespace AttendanceTracker.Dtos;

public class AttendanceDto
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime TimeIn { get; set; }
    public DateTime? TimeOut { get; set; }
}