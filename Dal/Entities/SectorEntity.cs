using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность сектора.
    /// </summary>
    public class SectorEntity : IEntityBase
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
        ///     Описание сектора.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string Description { get; set; }


        /// <summary>
        ///     Штрих-код.
        /// </summary>
        [ForeignKey(nameof(Id))]
        public BarcodeEntity Barcode { get; set; }
    }
}