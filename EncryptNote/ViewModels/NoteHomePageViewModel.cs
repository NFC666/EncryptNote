using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EncryptNote.Library.Models;
using EncryptNote.Views;
using Microsoft.Extensions.DependencyInjection;

namespace EncryptNote.ViewModels;

public partial class NoteHomePageViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _searchText;
    public ObservableCollection<string> SearchItems { get; set; } = new ObservableCollection<string>();
    public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();
    
    public NoteHomePageViewModel()
    {
        SearchItems.Add("Item 1");
        SearchItems.Add("Item 2");
        SearchItems.Add("Item 3");
        Notes.Add(new Note()
        {
            Title = "Note 1",
            Content = "This is note 1",
            CreatedDate = "2021-01-01",
            FilePaths = new List<string>()
            {
                "C:\\Users\\User\\Documents\\Note 1.txt"
            }
            
        });
        Notes.Add(new Note()
        {
            Title = "Note 2",
            Content = "This is note 2",
            CreatedDate = "2021-01-02",
            FilePaths = new List<string>()
            {
                "C:\\Users\\User\\Documents\\Note 2.txt"
            }
        });
        Notes.Add(new Note()
        {
            Title = "Note 3",
            Content = "This is note 3",
            CreatedDate = "2021-01-03",
            FilePaths = new List<string>()
            {
                "C:\\Users\\User\\Documents\\Note 3.txt"
            }
        });
    }
    
    [RelayCommand]
    public void OpenNote(Note note)
    {
        var noteCheckPage = new NoteCheckPage(note);
        noteCheckPage.Show();
    }
}