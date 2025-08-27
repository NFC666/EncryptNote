using System;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using EncryptNote.Library.Enums;
using EncryptNote.Library.Models;


namespace EncryptNote.Views.Components;

public partial class NoteCard : UserControl
{
    // 声明一个 AvaloniaProperty，这样可以支持绑定、XAML 设置等
    public static readonly StyledProperty<Note> NoteProperty =
        AvaloniaProperty.Register<NoteCard, Note>(nameof(Note));
    
    // 包装属性，方便使用
    public Note Note
    {
        get => GetValue(NoteProperty);
        set => SetValue(NoteProperty, value);
    }


    public NoteCard()
    {
        InitializeComponent();

    }

}