using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationShipsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly DataContext _context;
        public SkillController(DataContext context)
        {
            _context = context;
        }


        [HttpPost("CharacterSkills")]
        public async Task<ActionResult<Characters>> AddCharacterSkills(AddCharacterSkillsDto request)
        {
            var charecter = _context.Characters
                .Where(c => c.Id == request.CharacterId)
                .Include(c => c.Skills)
                .FirstOrDefault();

            if (charecter == null)
                return NotFound();

            var skill = await _context.Skills.FindAsync(request.SkillId);
            if (skill == null)
                return NotFound();

            charecter.Skills.Add(skill);
            await _context.SaveChangesAsync();

            return charecter;
        }
    }
}
