using API_LAN.Models;
using System.Text.Json;
using System.Xml.Linq;

namespace API_LAN.Repositories
{
    public class ToDoRepository
    {
        private static List<ToDo> toDoList = new();

        public IEnumerable<ToDo> GetToDoList()
        {
            return toDoList;
        }

        public IEnumerable<ToDoItems>? GetToDoItems(int idToDo)
        {
            return toDoList.Where(d => d.Id == idToDo).FirstOrDefault()?.Items;
        }

        public ToDo CreateNewToDo(ToDo toDo)
        {
            //ToDo? newToDo = new();
            //try
            //{
            //    newToDo = JsonSerializer.Deserialize<ToDo>(toDo);
            //}
            //catch (Exception error)
            //{

            //    //return BadRequest(ModelState);
            //}

            var newToDo = new ToDo(toDo.Name, toDo.Description, toDo.Items);
            toDoList.Add(newToDo);

            return newToDo;
        }
    }
}
