using Microsoft.EntityFrameworkCore;
using System;

namespace Fakebook.Server.Data
{
    public class AccountRepository: GenericRepository<Account>, IAccountRepository
    {
        private readonly FakebookContext _context;
        public AccountRepository(FakebookContext context): base(context)
        {
            _context = context;
        }

        public Account GetByEmail(string email)
        {
            return _context.Accounts.Where(a => a.email == email).FirstOrDefault();
        }
    }
}
