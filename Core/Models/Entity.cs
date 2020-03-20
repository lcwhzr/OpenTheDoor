using System;

namespace Core.Models
{
    abstract public class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; internal set; }
        public DateTime UpdatedAt { get; internal set; }

        public Entity()
        {
            //Id = Guid.NewGuid();
            CreatedAt = new DateTime();
            UpdatedAt = new DateTime();
        }

        //public Guid GetId()
        //{
        //    return Id;
        //}

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