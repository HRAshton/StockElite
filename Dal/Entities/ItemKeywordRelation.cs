using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entities
{
    /// <summary>
    ///     Связь предмета и ключевого слова.
    /// </summary>
    public class ItemKeywordRelation
    {
        /// <summary>
        ///     Идентификатор (штрих-код) предмета.
        /// </summary>
        [Key, Column(Order = 0)]
        public uint ItemId { get; set; }

        /// <summary>
        ///     Идентификатор ключевого слова.
        /// </summary>
        [Key, Column(Order = 1)]
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