using System;
namespace OpenTheDoor.Models
{
    abstract public class Entity
    {

        public int Id { get; set; }
        private DateTime CreatedAt;
        private DateTime UpdatedAt;

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