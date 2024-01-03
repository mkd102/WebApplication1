using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TokenWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        // GET: api/<TokenController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TokenController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var securityKey= new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Megha@123456789Feb2024"));
            var algo=new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var claims= new[] { new Claim("Issuer","Megha"), new Claim(JwtRegisteredClaimNames.UniqueName,id )};

            var token = new JwtSecurityToken("Megha", null, claims, DateTime.Now, DateTime.Now.AddMinutes(50), algo);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // POST api/<TokenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TokenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TokenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
