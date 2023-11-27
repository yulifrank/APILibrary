using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YaelFrankAPILibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Loans : ControllerBase
    {



        public static DataContext data;
        public Loans(DataContext l)
        {
            data = l;
        }


        // GET: api/<Loans>
        [HttpGet]
        public List<Loan> Get()
        {
            return data.loans;
        }
        // GET api/<Loans>/5
        [HttpGet("{id}")]
        public Loan Get(int id)
        {
            return data.loans[id];
        }

        // POST api/<Loans>
        [HttpPost]
        public void Post([FromBody] Loan value)
        {
            data.loans.Add(value);
        }

        // PUT api/<Loans>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Loan updatedLoan)
        {
            Loan loan = data.loans.Find(x => x.LoanId == id);
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
            data.loans.Remove(data.loans.Find(x => x.LoanId == id));
        }
    }
}
