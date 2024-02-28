using Fakebook.Server.Data;
using Fakebook.Server.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fakebook.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountRepository _accountRepository;

        public AccountController(ILogger<AccountController> logger,
            IAccountRepository genericRepository)
        {
            _logger = logger;
            _accountRepository = genericRepository;
        }

        [HttpGet(Name = "GetAccounts")]
        public IEnumerable<AccountDto> Get()
        {
            var account = new List<AccountDto>();
            return account;
        }

        [HttpGet(Name = "GetAccountById/{id}")]
        public IActionResult GetById(Guid id)
        {
            Account account = _accountRepository.GetById(id);

            if(account == null)
            {
                return NotFound();
            }

            var accountDto = new AccountDto(account.id, account.email, account.name);

            return Ok(accountDto);
        }

        [HttpPost(Name = "RegisterAccount")]
        public IActionResult Register([FromBodyAttribute] CreateAccountDto account)
        {
            var dbAccount = _accountRepository.GetByEmail(account.email);

            if (dbAccount != null)
            {
                return BadRequest("This email has already been registered.");
            }

            //encrypt the users password
            var password = Password.hashPassword(account.password);

            //create a new account if no account with the specified email can be found
            var createAccount = new Account
            { 
                email = account.email,
                name = account.name,
                password = password,
            };

            _accountRepository.Add(createAccount);

            return StatusCode(StatusCodes.Status201Created, createAccount);
        }
    }
}
