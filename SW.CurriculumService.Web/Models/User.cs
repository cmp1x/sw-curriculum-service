namespace SW.CurriculumService.Web.Models
{
    using System;

    public class User
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime TokenCreated { get; set; }

        public string AuthorizationToken { get; set; }
    }
}
