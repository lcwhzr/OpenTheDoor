using System;
namespace OpenTheDoor.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}