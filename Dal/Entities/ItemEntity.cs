using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность предмета.
    /// </summary>
    public class ItemEntity : IEntityBase
    {
        /// <summary>
        ///     Идентификатор предмета.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     Наименование предмета.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(128)]
        public string Name { get; set; }

        /// <summary>
        ///     Описание предмета.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        ///     Идентификатор сектора.
        ///     Обязательное поле.
        /// </summary>
        public Guid SectorId { get; set; }

        /// <summary>
        ///     Идентификатор предмета-контейнера.
        ///     Необязательное поле.
        /// </summary>
        public Guid? ContainerId { get; set; }


        /// <summary>
        ///     Контейнер, предмет, в котором находится данный.
        /// </summary>
        [ForeignKey(nameof(ContainerId))]
        public ItemEntity Container { get; set; }

        /// <summary>
        ///     Сектор.
        /// </summary>
        [ForeignKey(nameof(SectorId))]
        public SectorEntity Sector { get; set; }

        /// <summary>
        ///     Штрих-код.
        /// </summary>
        [ForeignKey(nameof(Id))]
        public BarcodeEntity Barcode { get; set; }
    }
}