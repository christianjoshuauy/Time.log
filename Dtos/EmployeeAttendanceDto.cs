using AttendanceTracker.Models;

namespace AttendanceTracker.Dtos;

public record EmployeeAttendanceDto(int Id, string Username, string FirstName, List<Attendance> Attendances);
