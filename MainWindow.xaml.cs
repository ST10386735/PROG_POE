using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static WpfApp3.MainWindow;


namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create an instance of the view
            var view = new inputWindow();

            // Add the view to the frame
            myFrame.Content = view;
        }
        private List<Recipe> recipe = new List<Recipe>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the input window
            inputWindow inputWindow = new inputWindow();

            // Show the input window as a dialog
            inputWindow.ShowDialog();
        }

        

       
        

        
    }


    public class Recipe
    {
        public string Name { get; set; }
        

        public string ingredients { get; set; }
    }
    
}
