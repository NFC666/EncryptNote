using EncryptNote.Library.Models;

namespace EncryptNote.Services.Services;

public class NoteStorage : INoteStorage
{
    public Task<List<Note>> GetAllNotes()
    {
        throw new NotImplementedException();
    }

    public Task<Note> AddNote(Note note)
    {
        throw new NotImplementedException();
    }

    public Task<Note> UpdateNote(Note note)
    {
        throw new NotImplementedException();
    }

    public Task<Note> DeleteNote(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Note> GetNote(int id)
    {
        throw new NotImplementedException();
    }
}