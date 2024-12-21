namespace AttendanceTracker.Services;

using AttendanceTracker.Dtos;
using AttendanceTracker.Models;

public interface IAttendanceService
{
    Task<List<EmployeeAttendanceDto>> GetAttendances();
    Task<EmployeeAttendanceDto> GetAttendanceByEmployee(int Id);
    Task<Attendance> EmployeeTimeIn(int Id);
    Task EmployeeTimeOut(int Id);
}