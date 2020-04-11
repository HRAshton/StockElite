using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Enums;
using Dal.Entities;

namespace BusinessLogic.Models
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
        public Guid Id { get; set; }

        /// <summary>
        ///     Идентификатор пользователя.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        ///     Идентификатор предмета.
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        ///     Описание предмета.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string Comment { get; set; }

        /// <summary>
        ///     Дата и время события.
        /// </summary>
        [Required]
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