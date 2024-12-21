namespace AttendanceTracker.Services;
using AttendanceTracker.Dtos;

public interface IAuthService
{
    Task Signup(SignupDto signupDto);
    Task Login(LoginDto loginDto);
}