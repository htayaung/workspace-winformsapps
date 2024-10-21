using Microsoft.EntityFrameworkCore;
using QuickNotes.Core.Entities;
using QuickNotes.Core.Interfaces;
using System.Linq.Expressions;

namespace QuickNotes.Data.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly ApplicationDbContext context;

        public NoteRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Note entity)
        {
            await context.Notes.AddAsync(entity);
            await context.SaveChangesAsync();
            context.Entry(entity).State = EntityState.Detached;
        }

        public async Task DeleteAsync(int id)
        {
            var note = await GetByIdAsync(id);
            if (note != null)
            {
                context.Notes.Remove(note);
                await context.SaveChangesAsync();
                context.Entry(note).State = EntityState.Detached;
            }
        }

        public async Task EmptyTrashAsync()
        {
            var notes = await GetManyAsync(note => note.IsDeleted);
            context.Notes.RemoveRange(notes);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            return await context.Notes.AsNoTracking().ToListAsync();
        }

        public async Task<Note> GetByIdAsync(int id)
        {
            return await context.Notes.FirstOrDefaultAsync(note => note.Id == id);
        }

        public async Task<IEnumerable<Note>> GetManyAsync(Expression<Func<Note, bool>> expression)
        {
            return await context.Notes.AsNoTracking().Where(expression).ToListAsync();
        }

        public async Task UpdateAsync(Note entity)
        {
            context.Notes.Update(entity);
            await context.SaveChangesAsync();
            context.Entry(entity).State = EntityState.Detached;
        }
    }
}
