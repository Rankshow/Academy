using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Core.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string CreatedBy { set; get; }  = string.Empty;
        public DateTime DateCreated { set; get; }
        public string ModifiedBy { set; get; } = string.Empty;
        public DateTime DateModified { set; get; }
    }
}