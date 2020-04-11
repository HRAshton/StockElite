using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dal.Entities;

namespace BusinessLogic.Models
{
    /// <summary>
    ///     Связь предмета и ключевого слова.
    /// </summary>
    public class ItemKeywordRelation : IEntityBase
    {
        /// <summary>
        ///     Идентификатор.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     Идентификатор предмета.
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        ///     Идентификатор ключевого слова.
        /// </summary>
        public Guid KeyWordId { get; set; }


        /// <summary>
        ///     Предмет.
        /// </summary>
        [ForeignKey(nameof(ItemId))]
        public ItemEntity Item { get; set; }

        /// <summary>
        ///     Ключевое слово.
        /// </summary>
        [ForeignKey(nameof(KeyWordId))]
        public KeyWordEntity KeyWord { get; set; }
    }
}