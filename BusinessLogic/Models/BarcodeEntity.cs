using System;
using System.ComponentModel.DataAnnotations;
using Dal.Entities;

namespace BusinessLogic.Models
{
    /// <summary>
    ///     Штрих-код.
    /// </summary>
    public class BarcodeEntity
    {
        /// <summary>
        ///     Идентификатор штрих-кода.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     Значение штрих-кода.
        /// </summary>
        [Range(0, 99999999999)]
        [StringLength(11)]
        public ulong Value { get; set; }
    }
}