using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Interfeces
{
    public interface INotesDbContext
    {
        DbSet<Note> Note { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
