using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication7;

public partial class Win : Window
{

    public Win()
    {
        InitializeComponent();
    }
    public Win(string Name, string Email)
    {
        InitializeComponent();
        NameWin.Text = Name;
        EmailWin.Text = Email;
    }
}