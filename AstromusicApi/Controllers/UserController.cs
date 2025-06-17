using Microsoft.AspNetCore.Mvc;
using AstromusicApi.Data;
using AstromusicApi.models;
using AstromusicApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace AstromusicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserSignResponse>> Register(UserRegistrationRequest request)
        {
            
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (existingUser != null)
            {
                return BadRequest("E-mail já cadastrado, bicha!");
            }


            var birth = request.BirthDate;
            var zodiacSign = await _context.ZodiacSigns
                .FirstOrDefaultAsync(sign =>
                    (sign.StartMonth < sign.EndMonth && // signo "normal" (ex: Áries)
                        ((birth.Month == sign.StartMonth && birth.Day >= sign.StartDay) ||
                         (birth.Month == sign.EndMonth && birth.Day <= sign.EndDay) ||
                         (birth.Month > sign.StartMonth && birth.Month < sign.EndMonth)))
                    ||
                    (sign.StartMonth > sign.EndMonth && // signo que vira o ano (ex: Capricórnio)
                        ((birth.Month == sign.StartMonth && birth.Day >= sign.StartDay) ||
                         (birth.Month == sign.EndMonth && birth.Day <= sign.EndDay) ||
                         (birth.Month > sign.StartMonth || birth.Month < sign.EndMonth)))
                );

            if (zodiacSign == null)
            {
                return BadRequest("Não foi possível determinar o signo. Checa se a data tá certa, mana!");
            }


            var newUser = new User
            {
                FullName = request.FullName,
                Email = request.Email,
                BirthDate = request.BirthDate,
                ZodiacSignId = zodiacSign.Id
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();


            var response = new UserSignResponse
            {
                FullName = newUser.FullName,
                Email = newUser.Email,
                BirthDate = newUser.BirthDate,
                SignName = zodiacSign.Name,
                Description = zodiacSign.Description,
                ThemeSong = zodiacSign.ThemeSong,
                SongArtist = zodiacSign.SongArtist,
                SongLink = zodiacSign.SongLink,
                ImageUrl = zodiacSign.ImageUrl
            };

            return Ok(response);
        }
    }
}
