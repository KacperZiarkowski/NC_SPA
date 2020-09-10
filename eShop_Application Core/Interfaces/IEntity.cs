using System;

namespace eShop_ApplicationCore.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }

        string CreatedBy { get; set; }

        DateTime? CreatedDate { get; set; }

        DateTime? ModifiedDate { get; set; }

    }
}
