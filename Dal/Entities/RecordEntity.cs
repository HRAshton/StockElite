using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Enums;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность записи.
    /// </summary>
    public class RecordEntity : IEntityBase
    {
        /// <summary>
        ///     Идентификатор записи.
        /// </summary>
        [Key]
        public uint Id { get; set; }
        
        /// <summary>
        ///     Идентификатор (штрих-код) пользователя.
        /// </summary>
        [Required]
        public uint UserId { get; set; }

        /// <summary>
        ///     Идентификатор (штрих-код) предмета.
        /// </summary>
        [Required]
        public uint ItemId { get; set; }

        /// <summary>
        ///     Описание предмета.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string Comment { get; set; }

        /// <summary>
        ///     Дата и время события.
        /// </summary>
        [Required]
        [Timestamp]
        public DateTime Timestamp { get; set; }

        /// <summary>
        ///     Тип события.
        /// </summary>
        [Required]
        public RecordType Type { get; set; }


        /// <summary>
        ///     Пользователь.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public UserEntity User { get; set; }

        /// <summary>
        ///     Предмет.
        /// </summary>
        [ForeignKey(nameof(ItemId))]
        public ItemEntity Item { get; set; }
    }
}