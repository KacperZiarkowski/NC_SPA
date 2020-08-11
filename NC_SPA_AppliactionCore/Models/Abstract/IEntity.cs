using System;
using System.Collections.Generic;
using System.Text;

namespace NC_SPA_AppliactionCore.Models.Abstract
{
    interface IEntity
    {
        long Id { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
