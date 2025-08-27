using EncryptNote.Library.Models;

namespace EncryptNote.Services.Services;

public interface INoteStorage
{
    //增删改查接口
    Task<List<Note>> GetAllNotes();
    Task<Note> AddNote(Note note);
    Task<Note> UpdateNote(Note note);
    Task<Note> DeleteNote(int id);
    Task<Note> GetNote(int id);
}