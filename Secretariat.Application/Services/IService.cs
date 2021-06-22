﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Secretariat.Presentation.Services
{
    public interface IService <TKey, TEntity>
    {
        /// <summary>
        /// Fetch objects by id from database asynchronously.
        /// </summary>
        Task<TEntity> GetByIdAsync(TKey id);

        /// <summary>
        /// Fetch all objects from database.
        /// </summary>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Preserve objects in database (just for test to remouve later).
        /// </summary>
        //void Save(params TEntity[] objs);

        /// <summary>
        /// Preserve objects in database asynchronously.
        /// </summary>
        Task SaveAsync(params TEntity[] objs);

        /// <summary>
        /// Update objects in database asynchronously.
        /// </summary>
        Task UpdateAsync(params TEntity[] objs);

        /// <summary>
        /// Delete collection of objects from database asynchronously.
        /// </summary>
        Task DeleteAsync(params TEntity[] objs);

    }
}
