
using EFCoreRelationShipsAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationShipsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;
        public CharacterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Characters>>> Get(int UserId)
        {
            var characters = await _context.Characters
                .Where(c => c.UserId == UserId)
                .Include(c => c.Weapon)
                .Include(c => c.Skills)
                .ToListAsync();

            return characters;
        }
        [HttpPost]
        public async Task<ActionResult<List<Characters>>> Create(CreateWeaponDto request)
        {
            var user = _context.Users.Find(request.UserId);
            if(user == null)
                return NotFound();

            var newCharacter = new Characters
            {
                Name = request.Name,
                RpgClass = request.RpgClass,
                UserId = request.UserId
            };

            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync(); 

            

            return await Get(newCharacter.UserId);
        }
    }
}
