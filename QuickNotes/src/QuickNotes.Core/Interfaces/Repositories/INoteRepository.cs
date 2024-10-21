using QuickNotes.Core.Entities;

namespace QuickNotes.Core.Interfaces
{
    public interface INoteRepository : IRepository<Note>
    {
        Task EmptyTrashAsync();
    }
}
