using EFCoreRelationShipsAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationShipsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        private readonly DataContext _context;

        public WeaponController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("create")]
        public async Task<ActionResult<Characters>> AddWeapon(AddWeaponDto request)
        {
            var charecter = _context.Characters.Find(request.CharacterId);
            if (charecter == null)
                return NotFound();

            var newWeapon = new Weapon
            {
                Name = request.Name,
                Damage = request.Damage,
                Character = charecter
            };

            _context.Weapons.Add(newWeapon);

            await _context.SaveChangesAsync();



            return charecter;
        }
    }
}
