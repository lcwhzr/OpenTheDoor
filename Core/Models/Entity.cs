using System;

namespace Core.Models
{
    abstract public class Entity
    {
        public int Id { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }

        public Entity()
        {
            CreatedAt = new DateTime();
            UpdatedAt = new DateTime();
        }

        public DateTime GetCreatedAt()
        {
            return CreatedAt;
        }

        public DateTime GetUpdatedAt()
        {
            return UpdatedAt;
        }
    }
}