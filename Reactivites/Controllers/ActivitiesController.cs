using Microsoft.AspNetCore.Mvc;
using Reactivities.Models;
using Reactivities.Models.DTO;
using Reactivities.Repository;

namespace Reactivities.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IActivitiesRepository activitiesRepository;

        public ActivitiesController(IActivitiesRepository activitiesRepository)
        {
            this.activitiesRepository = activitiesRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Activity>> GetActivities()
        {
            return Ok(activitiesRepository.GetActivities());
        }

        [HttpGet("{id}")]
        public ActionResult<Activity> GetActivity(Guid id)
        {
            var activity = activitiesRepository.GetActivity(id);

            if (activity == null)
                return NotFound($"Activity with Id = {id} not found");

            return Ok(activity);
        }

        [HttpPost]
        public ActionResult<Activity> CreateActivity([FromBody] ActivityDto activityDto)
        {
            if (activityDto == null) return BadRequest();

            var createdActivity = activitiesRepository.CreateActivity(activityDto);

            return CreatedAtAction(nameof(GetActivity), new { id = createdActivity.Id }, createdActivity);
        }

        [HttpPut("{id}")]
        public ActionResult<Activity> EditActivity(Guid id, [FromBody] ActivityDto activityDto)
        {
            var activityToUpdate = activitiesRepository.EditActivity(id, activityDto);

            if (activityToUpdate == null)
                return NotFound($"Activity with Id = {id} not found");

            return Ok(activityToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActivity(Guid id)
        {
            var activityToDelete = activitiesRepository.GetActivity(id);

            if (activityToDelete == null)
                return NotFound($"Activity with Id = {id} not found");

            activitiesRepository.DeleteActivity(id);

            return Ok("Activity Deleted Successfully...");
        }
    }
}
