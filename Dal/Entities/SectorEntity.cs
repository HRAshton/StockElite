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
        ///     Идентификатор (штрих-код) сектора.
        /// </summary>
        [Key]
        [Range(3000000000, 3999999999)]
        public uint Id { get; set; }

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
        ///     Идентификатор изображения сектора.
        /// </summary>
        public uint? ImageFileId { get; set; }


        /// <summary>
        ///     Изображение сектора.
        /// </summary>
        [ForeignKey(nameof(ImageFileId))]
        public StorageFileEntity ImageFile { get; set; }
    }
}