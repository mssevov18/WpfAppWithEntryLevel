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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Solutions;

namespace WpfAppWithEntryLevel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<IContainer> _exercises = new List<IContainer>();
        public MainWindow()
        {
            _exercises.Add(new _01());

            InitializeComponent();

            ExerciseContainer.ItemsSource = _exercises;
        }

        //REWORK!
        private void PickExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(sender.GetType().ToString() +"\n"+e.ToString()+"\n"+
            //    _exercises.Find(e => e.Title == (string)((Button)sender).Content).Title);

            IContainer container = _exercises.Find(e => e.Title == (string)((Button)sender).Content);
            TitleLabel.Content = container.Title;
            LinkLabel.Content = container.Link;
            SolutionBox.Text = container.Solution;
            ResultBox.Text = container.RunSolution();
        }
    }
}
