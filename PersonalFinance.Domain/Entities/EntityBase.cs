using System;

namespace PersonalFinance.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; } 

        public EntityBase ()
        {
            this.InsertDate = DateTime.Now;
            this.UpdateDate = DateTime.Now;
        }
        public abstract bool Validate();                
    }
}