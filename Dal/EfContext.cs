using Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    /// <summary>
    ///     Контекст.
    /// </summary>
    public class EfContext : DbContext
    {
        /// <summary>
        ///     Пользователи.
        /// </summary>
        public DbSet<UserEntity> UserEntities { get; set; }

        /// <summary>
        ///     Предметы.
        /// </summary>
        public DbSet<ItemEntity> ItemEntities { get; set; }

        /// <summary>
        ///     Записи.
        /// </summary>
        public DbSet<RecordEntity> RecordEntities { get; set; }

        /// <summary>
        ///     Сектора.
        /// </summary>
        public DbSet<SectorEntity> SectorEntities { get; set; }

        /// <summary>
        ///     Ключевые слова.
        /// </summary>
        public DbSet<KeyWordEntity> KeyWordEntities { get; set; }

        /// <summary>
        ///     Связи предметов и ключевых слов.
        /// </summary>
        public DbSet<ItemKeywordRelation> ItemKeywordRelationEntities { get; set; }

        /// <summary>
        ///     Связи предметов и файлов.
        /// </summary>
        public DbSet<ItemStorageFileRelation> ItemStorageFileRelations { get; set; }

        /// <summary>
        ///     Файлы.
        /// </summary>
        public DbSet<StorageFileEntity> StorageFileEntities { get; set; }

        /// <summary>
        /// ctor todo
        /// </summary>
        /// <param name="options"></param>
        public EfContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemKeywordRelation>().HasKey(rel => new { rel.ItemId, rel.KeyWordId });
            modelBuilder.Entity<ItemStorageFileRelation>().HasKey(rel => new {rel.ItemId, rel.StorageFileId});
        }
    }
}