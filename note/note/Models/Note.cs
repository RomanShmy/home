using System;
namespace note.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsPerform { get; set; } = false;
    }
}
