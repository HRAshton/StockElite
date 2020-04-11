﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Enums;
using Dal.Entities;

namespace BusinessLogic.Models
{
    /// <summary>
    ///     Сущность пользователя.
    /// </summary>
    public class UserEntity : IEntityBase
    {
        /// <summary>
        ///     Идентификатор пользователя.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

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
        [StringLength(4)]
        public string Pin { get; set; }


        /// <summary>
        ///     Штрих-код.
        /// </summary>
        [ForeignKey(nameof(Id))]
        public BarcodeEntity Barcode { get; set; }
    }
}