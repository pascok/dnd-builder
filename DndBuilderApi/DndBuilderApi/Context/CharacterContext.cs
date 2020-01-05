using Microsoft.EntityFrameworkCore;
using DndBuilderApi.Entities;

namespace DndBuilderApi.Context
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        { }

        public DbSet<CharacterEntity> Characters { get; set; }
    }
}
