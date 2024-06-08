using Reactivities.Models;
using Reactivities.Models.DTO;

namespace Reactivities.Repository
{
    public interface IActivitiesRepository
    {
        IEnumerable<Activity> GetActivities();
        Activity GetActivity(Guid id);
        Activity CreateActivity(ActivityDto activityDto);
        Activity EditActivity(Guid id, ActivityDto activityDto);
        void DeleteActivity(Guid id);

    }
}
