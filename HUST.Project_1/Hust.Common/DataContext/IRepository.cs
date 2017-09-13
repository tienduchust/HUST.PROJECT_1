using System;
using System.Collections.Generic;
using System.Linq;

namespace SH.Core.Data
{
    /// <summary>
    ///     Repository
    /// </summary>
    public interface IRepository<T> where T : BaseEntity
    {
        string IdContext { get; }
        /// <summary>
        ///     Gets a table
        /// </summary>
        IQueryable<T> Table { get; }

        /// <summary>
        ///     Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only
        ///     operations
        /// </summary>
        IQueryable<T> TableNoTracking { get; }

        /// <summary>
        ///     Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        T GetById(object id);

        /// <summary>
        ///     Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(T entity);

        /// <summary>
        ///     Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Insert(IEnumerable<T> entities);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void InsertOrUpdate(T entity);

        /// <summary>
        ///     Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Update(T entity);

        /// <summary>
        ///     Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Update(IEnumerable<T> entities);

        /// <summary>
        ///     Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(T entity);

        /// <summary>
        ///     Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Delete(IEnumerable<T> entities);
    }
}