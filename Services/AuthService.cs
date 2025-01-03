namespace AttendanceTracker.Services;
using AttendanceTracker.Dtos;
using AttendanceTracker.Models;

public class AuthService : IAuthService
{
    private readonly HttpClient _http;
    private readonly UserContext _userContext;

    public AuthService(HttpClient http, UserContext userContext)
    {
        _http = http;
        _userContext = userContext;
    }
    public async Task Signup(SignupDto signupDto)
    {
        try
        {
            var response = await _http.PostAsJsonAsync<SignupDto>("register", signupDto);
            response.EnsureSuccessStatusCode();
        }
        catch (Exception)
        {
            throw new Exception("Username already exists");
        }
    }

    public async Task Login(LoginDto loginDto)
    {
        try
        {
            var response = await _http.PostAsJsonAsync<LoginDto>("login", loginDto);
            response.EnsureSuccessStatusCode();
            var employee = await response.Content.ReadFromJsonAsync<Employee>();
            if (employee == null) throw new Exception("Invalid username or password");
            var response2 = await _http.GetFromJsonAsync<string>($"employees/{employee.Id}/discordAuth");
            employee.DiscordAuthToken = response2 ?? "";
            await _userContext.SaveUserContextAsync(employee);
        }
        catch (Exception)
        {
            throw new Exception("Invalid username or password");
        }
    }
}