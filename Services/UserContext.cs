using AttendanceTracker.Models;
using Blazored.LocalStorage;

namespace AttendanceTracker.Services;

public class UserContext
{
    private readonly ILocalStorageService _localStorage;
    private const string Key = "currentUser";
    public UserContext(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }
    public Employee? CurrentEmployee { get; private set; }
    public bool IsLoading { get; private set; } = true;

    public async Task LoadUserAsync()
    {
        CurrentEmployee = await _localStorage.GetItemAsync<Employee>(Key);
        IsLoading = false;
    }
    public async Task SaveUserContextAsync(Employee employee)
    {
        CurrentEmployee = employee;
        await _localStorage.SetItemAsync(Key, employee);
    }
    public async Task ClearUserContextAsync()
    {
        CurrentEmployee = null;
        await _localStorage.RemoveItemAsync(Key);
    }
    public bool IsAuthenticated => CurrentEmployee != null;
}