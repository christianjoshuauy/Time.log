using AttendanceTracker.Dtos;
using AttendanceTracker.Models;

namespace AttendanceTracker.Services;

public interface IReportService
{
    Task<List<Report>> GetReports();
    Task<Report> GetReport(int Id);
    Task<Report> CreateReport(ReportDto report, int AttendanceId);
}