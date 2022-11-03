using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
		List<object> _currentArgs = new List<object>();
		IContainer _container = null;
		Button _exerciseButton = null;

		public MainWindow()
		{
			_exercises.Add(new _01());
			_exercises.Add(new _02());
			_exercises.Add(new _03());
			_exercises.Add(new _04());

			InitializeComponent();

			SolutionContainer.Visibility = Visibility.Hidden;
			TypesLabel.Content = "No Arguments";
			ArgumentsBox.Text = "No Arguments";
			ArgumentsBox.IsEnabled = false;
			SendArgumentsButton.IsEnabled = false;

			ExerciseContainer.ItemsSource = _exercises;
		}

		//REWORK?
		private void PickExerciseButton_Click(object sender, RoutedEventArgs e)
		{
			//MessageBox.Show(sender.GetType().ToString() +"\n"+e.ToString()+"\n"+
			//    _exercises.Find(e => e.Title == (string)((Button)sender).Content).Title);

			_currentArgs.Clear();
			_exerciseButton = (Button)sender;
			IContainer _container = _exercises.Find(e => e.Title == (string)_exerciseButton.Content);

			TitleLabel.Content = _container.Title;
			LinkLabel.Content = _container.Link;
			StatementBox.Text = _container.Statement;
			SolutionBox.Text = _container.Solution;

			if (_container.Arguments == null)
			{
				TypesLabel.Content = "No Arguments";
				ArgumentsBox.Text = "No Arguments";
				ArgumentsBox.IsEnabled = false;
				SendArgumentsButton.IsEnabled = false;
			}
			else
			{
				StringBuilder LabelBuilder = new StringBuilder(), BoxBuilder = new StringBuilder();

				foreach (TypeCode code in _container.Arguments)
				{
					LabelBuilder.Append(code.ToString() + ", ");
					_currentArgs.Add(TypeCodeEx.GetDefaultValue(code));
					BoxBuilder.Append(TypeCodeEx.GetDefaultValue(code) + ", ");
				}
				LabelBuilder.Remove(LabelBuilder.Length - 2, 2);
				BoxBuilder.Remove(BoxBuilder.Length - 2, 2);

				TypesLabel.Content = LabelBuilder.ToString();

				ArgumentsBox.Text = BoxBuilder.ToString();
				ArgumentsBox.IsEnabled = true;
				SendArgumentsButton.IsEnabled = true;
			}

			SolutionContainer.Visibility = Visibility.Visible;
			ResultBox.Text = _container.RunSolution(_currentArgs.ToArray());
		}

		private void SendArgumentsButton_Click(object sender, RoutedEventArgs e)
		{
			//Check data
			_container = _exercises
				.Find(e => e.Title == (string)(_exerciseButton).Content);
			int index = 0;
			_currentArgs = ArgumentsBox.Text
				.Trim()
				.Split(",")
				.Select(a => Convert.ChangeType(a.Trim(), _container.Arguments[index++]))
				.ToList<object>();

			//StringBuilder @string = new StringBuilder();
			//index = 1;
			//foreach (object item in _currentArgs)
			//{
			//	if (index > _container.Arguments.Length)
			//		break;
			//	@string.Append(item.ToString() + "\n");
			//	index++;
			//}
			//MessageBox.Show(@string.ToString());

			ResultBox.Text = _container.RunSolution(_currentArgs.ToArray());
		}

		private void ArgumentsBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
				SendArgumentsButton_Click(sender, e);
		}
	}
}
