using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YaelFrankAPILibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Members : ControllerBase
    {
        public static List<Member> members= new List<Member>
    {
        new Member { Name = "John Doe", Age = 25 },
        new Member { Name = "Jane Smith", Age = 30 },
        new Member { Name = "Michael Johnson", Age = 35 },
        new Member { Name = "Emily Davis", Age = 28 }
    };
        // GET: api/<Member>
        [HttpGet]
        public List<Member> Get()
        {
            return members;
        }

        // GET api/<Member>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return members[id];
        }

        // POST api/<Member>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            members.Add(value);
        }

        // PUT api/<Member>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member ? updatedMember)
        {
            Member member = members.Find(x => x.MemberId == id);
            if (member != null)
            {
                if (!string.IsNullOrEmpty(updatedMember.Name))
                {
                    member.Name = updatedMember.Name;
                }

                if (updatedMember.Age != 0)
                {
                    member.Age = updatedMember.Age;
                }
            }
        }
        // DELETE api/<Member>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            members.Remove(members.Find(x => x.MemberId == id));
        }
    }
}
