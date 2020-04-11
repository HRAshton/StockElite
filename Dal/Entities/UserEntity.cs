using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Enums;

namespace Dal.Entities
{
    /// <summary>
    ///     Сущность пользователя.
    /// </summary>
    public class UserEntity
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
        ///     Пин-код пользователя.
        ///     Необязательное поле.
        /// </summary>
        [StringLength(6)]
        public string Pin { get; set; }
    }
}