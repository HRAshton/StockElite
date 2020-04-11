using System;
using System.ComponentModel.DataAnnotations;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность ключевого слова.
    /// </summary>
    public class KeyWordEntity : IEntityBase
    {
        /// <summary>
        ///     Идентификатор ключевого слова.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     Ключевое слово.
        /// </summary>
        public string Value { get; set; }
    }
}