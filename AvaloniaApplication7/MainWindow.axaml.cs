using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Controls.Notifications;

namespace AvaloniaApplication7;

public partial class MainWindow : Window
{
    private const string CorrectPassword = "12345678"; 

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnSignIn_Click(object? sender, RoutedEventArgs e)
    {
        string enteredPassword = TextBoxPass.Text;

        if (enteredPassword == CorrectPassword)
        {
            OpenWin();
        }
        else
        {
            ShowErrorMessage();
        }
    }

    private void OpenWin()
    {
        string name = TextBoxName.Text;
        string email = TextBoxEmail.Text;
        new Win("Ваше имя: " + name, "Ваша почта: " + email).Show();
        this.Close();
    }

    private void ShowErrorMessage()
    {
        var notificationManager = new WindowNotificationManager(this)
        {
            Position = NotificationPosition.TopRight
        };
        notificationManager.Show(new Notification("Ошибка", "Неверный пароль", NotificationType.Error));
    }
}
