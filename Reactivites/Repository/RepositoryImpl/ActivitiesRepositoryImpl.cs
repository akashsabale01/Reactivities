using AutoMapper;
using Reactivities.Data;
using Reactivities.Models;
using Reactivities.Models.DTO;

namespace Reactivities.Repository.RepositoryImpl
{
    public class ActivitiesRepositoryImpl : IActivitiesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public ActivitiesRepositoryImpl(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public IEnumerable<Activity> GetActivities()
        {
            return dataContext.Activities.ToList();
        }

        public Activity GetActivity(Guid id)
        {
            return dataContext.Activities.Find(id);
        }

        public Activity CreateActivity(ActivityDto activityDto)
        {

            Activity activity = mapper.Map<Activity>(activityDto);
            var newActivity = dataContext.Activities.Add(activity);
            dataContext.SaveChanges();
            return newActivity.Entity;
        }

        public Activity EditActivity(Guid id, ActivityDto activityDto)
        {
            var oldActivity = dataContext.Activities.Find(id);

            if (oldActivity != null)
            {
                /*oldActivity.Title = activity.Title;
                oldActivity.Description = activity.Description;
                oldActivity.City = activity.City;
                oldActivity.Venue = activity.Venue;
                oldActivity.Category = activity.Category;
                oldActivity.Date = activity.Date;*/


                mapper.Map(activityDto, oldActivity);

                dataContext.SaveChanges();

                return oldActivity;
            }

            return null;
        }

        public void DeleteActivity(Guid id)
        {
            var activityToDelete = dataContext.Activities.Find(id);

            if (activityToDelete != null)
            {
                dataContext.Activities.Remove(activityToDelete);
                dataContext.SaveChanges();

            }
        }
    }
}
