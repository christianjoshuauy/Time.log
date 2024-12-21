using AttendanceTracker.Dtos;
using AttendanceTracker.Models;
namespace AttendanceTracker.Services;

public class ReportService : IReportService
{
    private readonly HttpClient _http;
    public ReportService(HttpClient http) => _http = http;

    public async Task<List<Report>> GetReports()
    {
        return await _http.GetFromJsonAsync<List<Report>>("reports") ?? new();
    }

    public async Task<Report> GetReport(int Id)
    {
        return await _http.GetFromJsonAsync<Report>($"reports/{Id}") ?? new();
    }

    public async Task<Report> CreateReport(ReportDto report, int AttendanceId)
    {
        var response = await _http.PostAsJsonAsync<ReportDto>($"reports/create/{AttendanceId}", report);
        return await response.Content.ReadFromJsonAsync<Report>() ?? new();
    }
}