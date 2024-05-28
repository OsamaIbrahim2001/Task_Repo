using System.ComponentModel.DataAnnotations;

namespace Assignmnt_Task.Models
{
    public class CustomerBookProperty
    {
        [Key]
        public int  CustomerId { get; set; }
        public bool IsAlreadyBooked { get; set; }
    }
}
