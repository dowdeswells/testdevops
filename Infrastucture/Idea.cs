using System.Collections.Generic;

namespace Infrastucture
{
    public class Idea
    {
        public int Id { get; set; }
        public string Text { get; set; }
        
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}