namespace SW.CurriculumService.Web
{
    using AutoMapper;
    using SW.CurriculumService.Repository.Models;
    using SW.CurriculumService.Web.Models;

    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskProgressDb, TaskGetRequestResult>().ReverseMap();
        }
    }
}
