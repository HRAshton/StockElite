using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность предмета.
    /// </summary>
    public class ItemEntity
    {
        /// <summary>
        ///     Идентификатор (штрих-код) предмета.
        /// </summary>
        [Key]
        [Range(0, 2999999999)]
        public uint Id { get; set; }

        /// <summary>
        ///     Наименование предмета.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(128)]
        public string Name { get; set; }

        /// <summary>
        ///     Описание предмета.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string Description { get; set; }

        /// <summary>
        ///     Идентификатор (штрих-код) сектора.
        ///     Обязательное поле.
        /// </summary>
        [Required]
        public uint SectorId { get; set; }

        /// <summary>
        ///     Идентификатор (штрих-код) предмета-контейнера.
        ///     Необязательное поле.
        /// </summary>
        public uint? ContainerId { get; set; }


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
    }
}