using System;

namespace eShop_ApplicationCore.Model.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }

        IEntity UpdateFromEntity(IEntity source);
    }
}
