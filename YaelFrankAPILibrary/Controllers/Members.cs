using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.DataContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YaelFrankAPILibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Members : ControllerBase
    {
        public static DataContext data;
        public Members(DataContext d)
        {
            data = d;
        }
        // GET: api/<Member>
        [HttpGet]
        public List<Member> Get()
        {
            return data.members;
        }

        // GET api/<Member>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return data.members[id];
        }

        // POST api/<Member>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            data.members.Add(value);
        }

        // PUT api/<Member>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member ? updatedMember)
        {
            Member member = data.members.Find(x => x.MemberId == id);
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
            data.members.Remove(data.members.Find(x => x.MemberId == id));
        }
    }
}
