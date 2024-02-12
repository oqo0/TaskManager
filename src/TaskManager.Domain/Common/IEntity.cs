using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Common
{
    public interface IEntity<TId> where TId : struct
    {
        public TId Id { get; set; }
    }
}
