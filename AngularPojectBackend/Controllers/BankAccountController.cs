using AngularPojectBackend.Intreface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularPojectBackend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BankAccountController : ControllerBase
	{
		private readonly IBankAccount _bankAccountRepo;
        public BankAccountController(IBankAccount bankAccountrepo)
        {
				_bankAccountRepo = bankAccountrepo;
        }
        [HttpGet]
		public async Task<ActionResult<IEnumerable<BankAccount>>> GetBankAccounts()
		{
			try
			{
				var bankAccounts = await _bankAccountRepo.GetBankAccounts();


				if (bankAccounts == null)
				{
					return NotFound();
				}
				else
				{
	
					return Ok(bankAccounts);
				}

			}
			catch(Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
								"Error retrieving data from the database");
			}
			
		}

		// GET api/<BankAccountController>/5
		[HttpGet("{accountId}")]
		public async Task<BankAccount> Get(int accountId)
		{
			var acct =  await _bankAccountRepo.GetBankAccountById(accountId);
			return acct;
		}

		// POST api/<BankAccountController>
		[HttpPost]
		public void Post([FromBody] BankAccount bankAccount)
		{
			_bankAccountRepo.AddBankAccoun(bankAccount);
		}

		// PUT api/<BankAccountController>/5
		[HttpPut("{accountId}")]
		public void Put(int accountId, [FromBody] BankAccount bankAccount)
		{
			_bankAccountRepo.UpdateBankAccount(bankAccount);
		}

		// DELETE api/<BankAccountController>/5
		[HttpDelete("{accountId}")]
		public void Delete(int accountId)
		{
			_bankAccountRepo?.DeleteBankAccount(accountId);
		}
	}
}
