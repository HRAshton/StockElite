using System;
using System.ComponentModel.DataAnnotations;

namespace Dal.Entities
{
    /// <summary>
    ///     Базовый интерфейс сущности.
    /// </summary>
    public interface IEntityBase
    {
        /// <summary>
        ///     Идентификатор сущности.
        /// </summary>
        [Key]
        Guid Id { get; set; }
    }
}