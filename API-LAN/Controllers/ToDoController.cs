using API_LAN.Models;
using API_LAN.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace API_LAN.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly ToDoRepository _repository;

        public ToDoController(ILogger<ToDoController> logger, ToDoRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        /// <summary>
        /// Lista todos os TODO criados.
        /// </summary>
        [HttpGet(Name = "GetToDoList")]
        public IEnumerable<ToDo> GetToDoList()
        {
            return _repository.GetToDoList();
        }

        /// <summary>
        /// Lista todos os itens de um TODO especificado por ID.
        /// </summary>
        [HttpGet(Name = "GetToDoItems")]
        public IEnumerable<ToDoItems>? GetToDoItems(int idToDo)
        {
            return _repository.GetToDoItems(idToDo);
        }

        /// <summary>
        /// Cria um novo TODO.
        /// </summary>
        [HttpPost(Name = "CreateNewToDo")]
        public IActionResult CreateNewToDo([FromBody]ToDo toDo)
        {           
            var newToDo = _repository.CreateNewToDo(toDo);

            return CreatedAtRoute(nameof(CreateNewToDo), new { newToDo });
        }
    }
}
