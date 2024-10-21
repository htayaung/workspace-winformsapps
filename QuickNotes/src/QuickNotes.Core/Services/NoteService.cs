using QuickNotes.Core.Entities;
using QuickNotes.Core.Interfaces;

namespace QuickNotes.Core.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository repository;

        public NoteService(INoteRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(Note note)
        {
            await repository.AddAsync(note);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task EmptyTrashAsync()
        {
            await repository.EmptyTrashAsync();
        }

        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<IEnumerable<Note>> GetArchivedNotesAsync()
        {
            return await repository.GetManyAsync(note => note.IsArchived);
        }

        public async Task<Note> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Note>> GetCurrentNotesAsync()
        {
            return await repository.GetManyAsync(note => !note.IsArchived && !note.IsDeleted);
        }

        public async Task<IEnumerable<Note>> GetDeletedNotesAsync()
        {
            return await repository.GetManyAsync(note => note.IsDeleted);
        }

        public async Task UpdateAsync(Note note)
        {
            await repository.UpdateAsync(note);
        }
    }
}
