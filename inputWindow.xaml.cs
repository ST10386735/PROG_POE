using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for inputWindow.xaml
    /// </summary>
    public partial class inputWindow : Window
    {
        public inputWindow()
        {
            InitializeComponent();
        }
        private List<Recipe> recipe = new List<Recipe>();

        private void DisplayDataButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayData();
        }

        private void AddDataButton_Click(object sender, RoutedEventArgs e)
        {
            AddData();
        }
        string ingredient = "";
        String steps = "";
        private void AddData()
        {
            string rName = nameTextBox.Text;
            ingredient = ITextBox.Text;
            steps = ITextBox.Text;

            Recipe recipes = new Recipe { Name = rName, ingredients = ingredient };
            recipe.Add(recipes);
            nameTextBox.Clear();
            ITextBox.Clear();
            
        }
        private void DisplayData()
        {
            dataListBox.Items.Clear();
            string[] splitStrings = ingredient.Split(',');
            dataListBox.Items.Add("ingredients");
            foreach (string s in splitStrings)
            {
                dataListBox.Items.Add(s);
            }

            foreach (Recipe recipes in recipe)
            {
                dataListBox.Items.Add(recipes.Name);
            }
        }
        public class Recipe
        {
            public string Name { get; set; }


            public string ingredients { get; set; }
        }
    }
}
