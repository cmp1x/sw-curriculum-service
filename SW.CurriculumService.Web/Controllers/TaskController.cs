namespace SW.CurriculumService.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using SW.CurriculumService.Repository.Repositories;
    using SW.CurriculumService.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class TaskController: ControllerBase
    {
        private readonly ITaskRepository taskRepository;
        private readonly IMapper mapper;

        public TaskController(ITaskRepository taskRepository, IMapper mapper)
        {
            this.taskRepository = taskRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
           
            var tasks = taskRepository.Get();
            var mappedTasks = this.mapper.Map<IEnumerable<TaskGetRequestResult>>(tasks);

            return Ok(mappedTasks);
        }
    }
}
