using System;
using System.Collections.Generic;
using System.Text;

namespace NC_SPA_AppliactionCore.Models.Abstract
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
