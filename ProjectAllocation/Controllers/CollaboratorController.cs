using Microsoft.AspNetCore.Mvc;
using ProjectAllocation.Domain.Interfaces.Service;

namespace ProjectAllocation.API.Controllers
{
    [Route("[controller]")]
    public class CollaboratorController : ControllerBase
    {
        private readonly ICollaboratorService _collaboratorService;

        public CollaboratorController(ICollaboratorService collaboratorService)
        {
            _collaboratorService = collaboratorService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var collaborator = await _collaboratorService.GetByIdAsync(id);

            if (collaborator == null)
            {
                return NotFound();
            }

            return Ok(collaborator);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Collaborator collaborator)
        {
            var newCollaborator = await _collaboratorService.AddAsync(collaborator);

            return CreatedAtAction(nameof(Get), new { id = newCollaborator.Id }, newCollaborator);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Collaborator collaborator)
        {
            if (id != collaborator.Id)
            {
                return BadRequest();
            }

            await _collaboratorService.UpdateAsync(collaborator);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var collaborator = await _collaboratorService.GetByIdAsync(id);

            if (collaborator == null)
            {
                return NotFound();
            }

            await _collaboratorService.DeleteAsync(collaborator);

            return NoContent();
        }
    }
}
