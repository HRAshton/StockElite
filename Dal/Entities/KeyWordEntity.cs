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
        public uint Id { get; set; }

        /// <summary>
        ///     Ключевое слово.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string Value { get; set; }
    }
}