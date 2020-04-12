using System.ComponentModel.DataAnnotations;
using Core.Enums;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность пользователя.
    /// </summary>
    public class UserEntity : IEntityBase
    {
        /// <summary>
        ///     Идентификатор (штрих-код) пользователя.
        /// </summary>
        [Key]
        [Range(4000000000, uint.MaxValue)]
        public uint Id { get; set; }

        /// <summary>
        ///     ФИО пользователя.
        ///     Обязательное поле.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(128)]
        public string Name { get; set; }

        /// <summary>
        ///     Идентификатор пользователя в корпоративном Active Directory.
        ///     Обязательное поле.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(32)]
        public string AdLogin { get; set; }

        /// <summary>
        ///     Роль пользователя.
        /// </summary>
        [Required]
        public UserRole Role { get; set; }

        /// <summary>
        ///     Хэш пин-кода пользователя.
        ///     Необязательное поле.
        /// </summary>
        [MinLength(32)] [MaxLength(32)]
        public byte[] PinHash { get; set; }
    }
}