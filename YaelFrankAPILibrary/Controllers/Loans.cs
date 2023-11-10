using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YaelFrankAPILibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Loans : ControllerBase
    {

        public static List<Loan> loans  = new List<Loan>
    {
        new Loan { Name = "John Doe", Date = DateTime.Now },
        new Loan { Name = "Jane Smith", Date = DateTime.Now.AddDays(-5) },
        new Loan { Name = "Michael Johnson", Date = DateTime.Now.AddDays(-2) }
    };



        // GET: api/<Loans>
        [HttpGet]
        public List<Loan> Get()
        {
            return loans;
        }
        // GET api/<Loans>/5
        [HttpGet("{id}")]
        public Loan Get(int id)
        {
            return loans[id];
        }

        // POST api/<Loans>
        [HttpPost]
        public void Post([FromBody] Loan value)
        {
              loans.Add(value);
        }

        // PUT api/<Loans>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Loan updatedLoan)
        {
            Loan loan = loans.Find(x => x.LoanId == id);
            if (loan != null)
            {
                loan.Name = updatedLoan.Name;
                loan.Date = updatedLoan.Date;
            }
        }

        // DELETE api/<Loans>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            loans.Remove(loans.Find(x => x.LoanId == id));
        }
    }
}
