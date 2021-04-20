using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Cryptor.Desktop
{
    public sealed partial class MainPage : Page
    {
        public MainPage() => InitializeComponent();

        private void EncryptButton_Click(Object sender, RoutedEventArgs e)
        {
        }

        private void DecryptButton_Click(Object sender, RoutedEventArgs e)
        {
        }
        
        private void LanguagesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LanguagesList.Items?.Clear();
            var languages = new[] { "1", "2", "3" };
            foreach (var language in languages)
            {
                ComboBoxItem item = new ComboBoxItem { Content = languages, Tag = languages };
                LanguagesList.Items?.Add(item);
            }
        }
    }
}