using QuickNotes.Core.Entities;

namespace QuickNotes.Core.Interfaces
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetAllAsync();
        Task<IEnumerable<Note>> GetCurrentNotesAsync();
        Task<IEnumerable<Note>> GetArchivedNotesAsync();
        Task<IEnumerable<Note>> GetDeletedNotesAsync();
        Task<Note> GetByIdAsync(int id);
        Task AddAsync(Note note);
        Task UpdateAsync(Note note);
        Task DeleteAsync(int id);
        Task EmptyTrashAsync();
    }
}
