namespace API_LAN.Models
{
    public class ToDoItems
    {
        public int Id { get; private set; }
        public int IdToDo { get; set; }
        public string? Item { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn { get;private set; }
        private static int idCount;

        public ToDoItems(int idToDo, string item, bool done = false)
        {
            idCount++;
            Id = idCount;

            IdToDo = idToDo;
            Item = item;
            Done = done;
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }
    }
}
