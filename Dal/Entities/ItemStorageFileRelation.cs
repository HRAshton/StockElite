using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entities
{
    /// <summary>
    ///     Связь предмета и файла (изображения).
    /// </summary>
    public class ItemStorageFileRelation
    {
        /// <summary>
        ///     Идентификатор (штрих-код) предмета.
        /// </summary>
        [Key, Column(Order = 0)]
        public uint ItemId { get; set; }

        /// <summary>
        ///     Идентификатор файла (изображения).
        /// </summary>
        [Key, Column(Order = 1)]
        public uint StorageFileId { get; set; }


        /// <summary>
        ///     Предмет.
        /// </summary>
        [ForeignKey(nameof(ItemId))]
        public ItemEntity Item { get; set; }

        /// <summary>
        ///     Файл (изображение).
        /// </summary>
        [ForeignKey(nameof(StorageFileId))]
        public StorageFileEntity StorageFile { get; set; }
    }
}