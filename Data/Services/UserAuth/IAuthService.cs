namespace FinanceApp.Data.Services.UserAuth
{
    public interface IAuthService
    {
        Task<bool> UserExists(string username);
        Task Register(string username, string password);
        Task<string> Login(string username, string password);
    }
}
