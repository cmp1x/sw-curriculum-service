namespace SW.CurriculumService.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using SW.CurriculumService.Repository.Repositories;
    using SW.CurriculumService.Web.Models;

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
            var userToken = HttpContext.Request.Headers.FirstOrDefault(h => h.Key == "Authorization").Value;

            if (string.IsNullOrWhiteSpace(userToken))
            {
                return BadRequest();
            }

            var httpClient = new HttpClient();

            var result = httpClient.GetAsync($"https://a5t.ru/token/{userToken}").Result;

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }

            var currentUser = JsonConvert.DeserializeObject<User>(result.Content.ReadAsStringAsync().Result);

            var tasks = taskRepository.GetForUser(currentUser.UserId);

            var mappedTasks = this.mapper.Map<IEnumerable<TaskGetRequestResult>>(tasks);

            return Ok(mappedTasks);
        }
    }
}
