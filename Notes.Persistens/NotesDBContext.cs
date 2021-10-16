using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfeces;
using Notes.Domain;
using Notes.Persistens.EntityTypeConfiguration;

namespace Notes.Persistens
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Note { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
