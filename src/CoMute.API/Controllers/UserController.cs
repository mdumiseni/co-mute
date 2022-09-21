using CoMuteDAL.Library.CoMuteEntities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

using System.Net;
using CoMuteDAL.Library.CoDbContext;

namespace CoMute.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly CoMuteDbContext _dbContext = new();
        [HttpPost(Name ="Users")]
        public User Post(Web.Models.Dto.RegistrationRequest registrationRequest)
        {
            var user = new User()
            {
                Name = registrationRequest.Name,
                Surname = registrationRequest.Surname,
                Email = registrationRequest.EmailAddress,
                Password = registrationRequest.Password,
                Phone =registrationRequest.PhoneNumber
            };

            _dbContext.User.Add(user);
            _dbContext.SaveChanges();

            return user;
        }
    }
}
