namespace Fakebook.Server.Data
{
    public interface IAccountRepository: IGenericRepository<Account>
    {
        Account GetByEmail(string email);
    }
}
