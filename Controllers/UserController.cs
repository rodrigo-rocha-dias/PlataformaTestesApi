using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlataformaTestes.Data;
using PlataformaTestes.Models;
using System.Linq;

namespace PlataformaTestes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // 🔐 Protege todos os endpoints
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ Criar usuário (permitir sem autenticação)
        [HttpPost]
        [AllowAnonymous] // 🔓 Permite criar usuário sem token JWT
        public IActionResult CreateUser([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // ✅ Buscar usuário por ID
        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // ✅ Listar todos os usuários
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        // ✅ Atualizar usuário
        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] User updatedUser)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            user.Nome = updatedUser.Nome;
            user.Email = updatedUser.Email;
            user.Senha = updatedUser.Senha;
            user.TipoUsuario = updatedUser.TipoUsuario;

            _context.SaveChanges();
            return NoContent();
        }

        // ✅ Deletar usuário
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
