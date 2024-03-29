﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Common
{
    public interface IRepository<TEntity, TId>
        where TId : struct
        where TEntity : IEntity<TId>
    {
        public TEntity GetById(TId id);
    }
}
