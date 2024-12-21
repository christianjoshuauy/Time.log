namespace AttendanceTracker.Services;

using AttendanceTracker.Dtos;
using AttendanceTracker.Models;

public class AttendanceService : IAttendanceService
{
    private readonly HttpClient _http;
    public AttendanceService(HttpClient http) => _http = http;
    public async Task<List<EmployeeAttendanceDto>> GetAttendances()
    {
        return await _http.GetFromJsonAsync<List<EmployeeAttendanceDto>>("employees") ?? new();
    }
    public async Task<EmployeeAttendanceDto> GetAttendanceByEmployee(int Id)
    {
        return await _http.GetFromJsonAsync<EmployeeAttendanceDto>($"employees/{Id}") ?? new(0, "", "", new());
    }
    public async Task<Attendance> EmployeeTimeIn(int Id)
    {
        var response = await _http.PostAsJsonAsync<Object>($"attendance/{Id}/timeIn", new());
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Attendance>() ?? new();
    }
    public async Task EmployeeTimeOut(int Id)
    {
        var response = await _http.PutAsJsonAsync<Object>($"attendance/{Id}/timeOut", new());
        response.EnsureSuccessStatusCode();
    }
}