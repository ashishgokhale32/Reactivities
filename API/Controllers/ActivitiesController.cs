using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext m_context;
        public ActivitiesController(DataContext context)
        {
            m_context = context;
        }

        [HttpGet]  // api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await m_context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]  // api/activities
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await m_context.Activities.FindAsync(id);
        }
    }
}