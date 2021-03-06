using GryGiereczki.Data;
using GryGiereczki.Models;
using GryGiereczki.Services;
using GryGiereczki.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GryGiereczki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly JwtService _jwtService;
        private readonly IEmailService _emailService;
        public AuthController(IUserRepository repository, JwtService jwtService, IEmailService emailService)
        {
            _repository = repository;
            _jwtService = jwtService;
            _emailService = emailService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterVM user)
        {
            var email = _repository.GetByEmail(user.Email);

            if (email != null) return BadRequest(new { message = "User with this email already exists" });

            var nick = _repository.GetByNick(user.Nick);

            if (nick != null) return BadRequest(new { message = "User with this nick already exists" });

            var _user = new User
            {
                Nick = user.Nick,
                Password = BCrypt.Net.BCrypt.HashPassword(user.Password),
                Email = user.Email,
                Name = user.Name,
                Lastname = user.Lastname,
                DateOfBirth = user.DateOfBirth,
                Avatar = "test.jpg",
                IsEmailConfirmed = false
                
            };

            _repository.Create(_user);

            var emailConfirmToken = _jwtService.Generate(_user.Id); //token do wysyłania potwierdzenia na maila
            _repository.SendEmailConfirmationEmail(_user, emailConfirmToken);

            return Ok(); //można zwrócić usera
            //return Created("success", _repository.Create(_user));
        }

        [HttpPost("login")]
        public IActionResult Login(LoginVM loginVM)
        {
            //Index();


            var user = _repository.GetByEmail(loginVM.Email);
            if (user == null)
            {
                user = _repository.GetByNick(loginVM.Nick);
                if (user == null) return BadRequest(new { message = "No user with this email or nick" });
            }

            if (!BCrypt.Net.BCrypt.Verify(loginVM.Password, user.Password))
            {
                return BadRequest(new { message = "Invalid password" });
            }

            if(!user.IsEmailConfirmed)
            {
                return BadRequest(new { message = "Email not confirmed" });
            }

            var jwt = _jwtService.Generate(user.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true
            });

            return Ok(jwt);

            /* return Ok(new
             {
                 message = "success login"
             });
            */
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];

                var token = _jwtService.Verify(jwt);

                int userId = int.Parse(token.Issuer);

                var user = _repository.GetById(userId);

                return Ok(user);
            }
            catch (Exception _)
            {
                return Unauthorized();
            }
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");

            return Ok(new
            {
                message = "success logout"
            });
        }

        /*
        public async void Index()
        {
            UserEmailOptions options = new UserEmailOptions
            {
                ToEmails = new List<string>() { "grygiereczki.net@gmail.com" },
                PlaceHolders = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("{{UserName}}", "Rafał")
                }
            };

            await _emailService.SendTestEmail(options);
        } */



        //XDDDD
        /*
        [HttpGet("confirm-email")]
        public async Task ConfirmEmail(int id, string token)
        {
            if(!string.IsNullOrEmpty(token))
            {
                //await _repository.ConfirmEmail(id, token);
                _repository.GetById(id).IsEmailConfirmed = true;
            }
        }*/


        //2d
        [HttpGet("confirm-email")]
        public IActionResult ConnfirmEmail(int uid, string token)
        {
            var emailConfirmToken = _jwtService.Generate(uid);
            if (token == emailConfirmToken)
            {
                _repository.ConfirmEmailInDataBase(uid);
                return Ok();
            }
            else
            {
                return BadRequest(new { message = "Token is unactive" });
            }
        }

    }
}
