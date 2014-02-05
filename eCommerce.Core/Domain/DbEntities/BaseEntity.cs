using System;
namespace eCommerce.Core.Domain.DbEntities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
