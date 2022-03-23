namespace todo_app_aspnet.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Text { get; set; }
        public bool IsComplete { get; set; }

    }
}
