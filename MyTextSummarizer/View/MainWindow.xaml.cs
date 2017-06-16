using MyTextSummarizer.View_Model;
using System;
using System.Windows;

namespace MyTextSummarizer.View
{
    /// <summary>
    /// Implemented by J. Daniel Worthington
    /// Code behind for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM ViewModel = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        private void SwitchUI_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SwitchUI();
        }

        private void SummarizeChapter_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Summarize();
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Documents|*.txt";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // User selected a file
            if (result == true)
            {
                FilePath.Text = dlg.FileName;
                ViewModel.UploadDocument(dlg.FileName);
            }
        }
    }
}
