using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using EncryptNote.Library.Messages;
using EncryptNote.Library.Models;

namespace EncryptNote.ViewModels;

public partial class NoteCheckPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private Note _noteToShow;
    
    public NoteCheckPageViewModel()
    {
        WeakReferenceMessenger.Default.Register<NoteTransMessage>(this, ReceiveMessageHandle);
    }
    private void ReceiveMessageHandle(object recipient, NoteTransMessage message)
    {
        NoteToShow = message.Note;
    }
}