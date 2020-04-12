using System.ComponentModel.DataAnnotations;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность файла.
    /// </summary>
    public class StorageFileEntity
    {
        /// <summary>
        ///     Идентификатор файла.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        ///     Название предмета.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Описание файла.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string Description { get; set; }

        /// <summary>
        ///     Хэш-сумма файла.
        /// </summary>
        [Required]
        [MinLength(32)] [MaxLength(32)]
        public byte[] Hashsum { get; set; }
    }
}