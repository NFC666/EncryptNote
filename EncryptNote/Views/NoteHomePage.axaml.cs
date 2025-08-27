using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using EncryptNote.ViewModels;

namespace EncryptNote.Views;

public partial class NoteHomePage : Window
{
    public NoteHomePage()
    {
        InitializeComponent();
        DataContext = Program.Services?.GetService(typeof(NoteHomePageViewModel));
    }
}