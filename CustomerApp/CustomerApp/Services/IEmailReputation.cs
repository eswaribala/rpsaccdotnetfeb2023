namespace CustomerApp.Services
{
    public interface IEmailReputation
    {
        bool IsRisky(string Email);
    }
}
