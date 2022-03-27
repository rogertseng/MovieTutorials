using Serenity.Services;

namespace MovieTutorials.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}