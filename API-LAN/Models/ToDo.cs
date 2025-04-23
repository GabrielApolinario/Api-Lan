namespace API_LAN.Models
{
    public class ToDo
    {
        public int Id { get; private set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; private set; }
        public List<ToDoItems> Items { get; set; } = new();
        private static int idCount;        
        public ToDo(string name, string description, List<ToDoItems> items)
        {
            idCount++;
            Id = idCount;

            Name = name;
            Description = description;
            Items = items;
            Items.ForEach(d => d.IdToDo = Id);
            CreatedOn = DateTime.Now;                    
        }

        public ToDo()
        {
            
        }
    }
}
