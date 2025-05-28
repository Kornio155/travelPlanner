using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace travelPlanner;

public partial class MainWindow : Window {
    private ObservableCollection<string> _items = new();

    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;
    }
    private void ShowMessageBoxButton_Click(object? sender, RoutedEventArgs e)
    {

    }
}