using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using Projeto_WTDNWYTK.Repositories;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Projeto_WTDNWYTK.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public LoginController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost("Login")]
        public IActionResult Login(Usuario login)
        {
            Usuario usuarioBuscado = _UsuarioRepository.Login(login.Email, login.Senha);

            if (usuarioBuscado == null)
            {
                return NotFound("E-mail ou senha inválidos.");
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("wtdnwytk-chave-autenticacao"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "wtdnwytk",
                audience: "wtdnwytk",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );
            return Ok(new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}
