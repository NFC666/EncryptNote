using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using EncryptNote.Library.Messages;
using EncryptNote.Library.Models;
using EncryptNote.ViewModels;

namespace EncryptNote.Views;

public partial class NoteCheckPage : Window
{

    public NoteCheckPage(Note note)
    {
        InitializeComponent();
        DataContext = Program.Services?.GetService(typeof(NoteCheckPageViewModel));
        WeakReferenceMessenger.Default.Send(new NoteTransMessage(note));
        TopImage.PointerPressed += TopImageOnPointerPressed;
    }

    private void TopImageOnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        this.BeginMoveDrag(e);
    }
}