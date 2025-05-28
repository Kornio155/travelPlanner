using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace travelPlanner;

public partial class MainWindow : Window {
    private ObservableCollection<string> _items = new();

    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;
    }
    private void OnAddClicked(object sender, RoutedEventArgs e)
    {
        var inputBox = this.FindControl<TextBox>("InputBox");
        
    }

    private void OnShowPopupClicked(object sender, RoutedEventArgs e)
    {
        var popup = this.FindControl<Popup>("okienko");
        var popupContentTextBlock = this.FindControl<TextBlock>("tekstWOkienku");
        
        var dane = this.FindControl<TextBox>("dane").Text;
        
        var kraj = this.FindControl<ComboBox>("kraj");
        
        string selectedContent = (kraj.SelectedItem as ComboBoxItem)?.Content?.ToString();


        var muzea = this.FindControl<CheckBox>("muzea").IsChecked;
        var filharmonie = this.FindControl<CheckBox>("filharmonie").IsChecked;
        var kina =this.FindControl<CheckBox>("kina").IsChecked;
        var parki = this.FindControl<CheckBox>("parki").IsChecked;
        var zabytki = this.FindControl<CheckBox>("zabytki").IsChecked;
        var stadiony = this.FindControl<CheckBox>("stadiony").IsChecked;

        var m = "";
        var f = "";
        var k = "";
        var p = "";
        var z = "";
        var s = "";

        if (muzea == true)
        {
            m = "Muzea";
        }
        else
        {
            m = "";
        }

        if (filharmonie == true)
        {
            f = "Filharmonie";
        }
        else
        {
            f = "";
        }
        if (kina == true)
        {
            k = "Kina";
        }
        else
        {
            k = "";
        }
        if (parki == true)
        {
            p = "Parki";
        }
        else
        {
            p = "";
        }
        if (zabytki == true)
        {
            z = "Zabytki";
        }
        else
        {
            z = "";
        }
        if (stadiony == true)
        {
            s = "Stadiony";
        }
        else
        {
            s = "";
        }

        var selected = TransportPanel.Children
            .OfType<RadioButton>()
            .FirstOrDefault(r => r.IsChecked == true);

        var transport = selected?.Content?.ToString();


        
        


        
        
        if (popup != null)
        {
            if (popupContentTextBlock != null)
            {
                popupContentTextBlock.Text = $"Twoje imie i nazwisko to: {dane}.\nWybrany kraj docelowy to:  {selectedContent}.\nWybrane atrakcje to: {m} {f} {k} {p} {z} {s}.\nWybrany srodek transportu to: {transport}";
            }

            popup.IsOpen = true;
        }
    }

    private void OnClosePopupClicked(object sender, RoutedEventArgs e)
    {
        var popup = this.FindControl<Popup>("okienko");
        if (popup != null)
        {
            popup.IsOpen = false; 
        }
    }

}