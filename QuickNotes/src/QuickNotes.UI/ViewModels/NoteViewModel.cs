using QuickNotes.Core.Entities;
using System.Text.Json;

namespace QuickNotes.UI.ViewModels
{
    public class NoteViewModel : Note
    {
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static NoteViewModel From(Note note)
        {
            return new NoteViewModel
            {
                Id = note.Id,
                Title = note.Title,
                Content = note.Content,
                IsArchived = note.IsArchived,
                IsDeleted = note.IsDeleted,
            };
        }

        public static IEnumerable<NoteViewModel> From(IEnumerable<Note> notes)
        {
            return notes.Select(note => From(note));
        }
    }
}
