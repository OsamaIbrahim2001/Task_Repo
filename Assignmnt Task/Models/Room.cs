using Assignmnt_Task.Models.Enums;

namespace Assignmnt_Task.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public RoomType RoomType { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildern { get; set; }
    }
}
