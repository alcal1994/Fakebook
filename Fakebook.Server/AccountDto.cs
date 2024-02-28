using Fakebook.Server.Data;

namespace Fakebook.Server
{
    public record AccountDto(Guid id, string name, string email);
    public record CreateAccountDto(string name, string email, string password);
}
