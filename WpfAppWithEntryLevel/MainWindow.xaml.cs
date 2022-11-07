using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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
using Solutions.Solutions;

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
			_exercises.Add(new Info());
			_exercises.Add(new _01());
			_exercises.Add(new _02());
			_exercises.Add(new _03());
			_exercises.Add(new _04());
			_exercises.Add(new _05());
			_exercises.Add(new _06());
			_exercises.Add(new _07());
			_exercises.Add(new _08());
			_exercises.Add(new _09());
			_exercises.Add(new _10());
			_exercises.Add(new _11());

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
			HyperlinkLabel.NavigateUri = new Uri(_container.Link);
			LinkLabel.Content = _container.Link;

			StatementBox.Text = _container.Statement;
			if (_container.Statement == String.Empty)
				StatementBox.Visibility = Visibility.Hidden;
			else
				StatementBox.Visibility = Visibility.Visible;

			SolutionBox.Text = _container.Solution;
			if (_container.Solution == String.Empty)
			{
				SolutionBox.Visibility = Visibility.Hidden;
				ResultBox.Visibility = Visibility.Hidden;
			}
			else
			{
				SolutionBox.Visibility = Visibility.Visible;
				ResultBox.Visibility = Visibility.Visible;
			}

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

				//Add Names, Types to Arguments Label/TextBox
				foreach (ArgumentCode code in _container.Arguments)
				{
					LabelBuilder.Append(
$"{code.Name}({code.Type}), ");
					_currentArgs.Add(TypeCodeEx.GetDefaultValue(code.Type));
					BoxBuilder.Append(TypeCodeEx.GetDefaultValue(code.Type) + ", ");
				}
				LabelBuilder.Remove(LabelBuilder.Length - 2, 2);
				BoxBuilder.Remove(BoxBuilder.Length - 2, 2);

				TypesLabel.Content = LabelBuilder.ToString();

				ArgumentsBox.Text = BoxBuilder.ToString();
				ArgumentsBox.IsEnabled = true;
				SendArgumentsButton.IsEnabled = true;
				ArgumentsBox.Visibility = Visibility.Visible;
				SendArgumentsButton.Visibility = Visibility.Visible;
			}

			SolutionContainer.Visibility = Visibility.Visible;
			if (_container.Solution != String.Empty)
				ResultBox.Text = _container.RunSolution(_currentArgs.ToArray());
			e.Handled = true;
		}

		private void SendArgumentsButton_Click(object sender, RoutedEventArgs e)
		{
			//Check data
			try
			{
				_currentArgs.Clear();

				string rawargs = ArgumentsBox.Text;
				int index = 0;

				_container = _exercises
								.Find(e =>
									e.Title == (string)(_exerciseButton)
													.Content);

				//_currentArgs = ArgumentsBox.Text
				//	.Trim()
				//	.Split(",")
				//	.Select(a => Convert.ChangeType(a.Trim(), _container.Arguments[index++].Type))
				//	.ToList<object>();

				//while (rawargs.Contains('{') &&
				//	   rawargs.Contains('}') &&
				//	   _container.Arguments.Select(arg => arg.IsArray == true).Count() >= 1)
				//{
				//	int temp1, temp2;
				//	_currentArgs.Add(rawargs.Substring(temp1 = rawargs.IndexOf('{'),
				//								   temp2 = rawargs.IndexOf('}', temp1))
				//					 .Replace('{', ' ')
				//					 .Replace('}', ' ')
				//					 .Trim()
				//					 .Split(',')
				//					 .Select(a =>
				//						Convert
				//						.ChangeType(a.Trim(),
				//									_container
				//										.Arguments[index]
				//										.Type))
				//					 .ToArray());
				//	index++;
				//	rawargs = rawargs.Substring(temp2 + 1);
				//	if (rawargs.Length == 0)
				//		break;
				//}

				//if (rawargs.Length != 0)
				//	_currentArgs.Add(rawargs
				//		.Trim()
				//		.Split(",")
				//		.Select(a =>
				//			Convert
				//			.ChangeType(a.Trim(),
				//						_container
				//							.Arguments[index++]
				//							.Type))
				//		.ToList<object>());
				if (rawargs.Length != 0)
					foreach (var item in rawargs
						.Trim()
						.Split(",")
						.Select(a =>
							Convert
							.ChangeType(a.Trim(),
										_container
											.Arguments[index++]
											.Type)))
						_currentArgs.Add(item);

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
				e.Handled = true;
			}
			catch (Exception ex)
			{
				e.Handled = false;
				MessageBox.Show($"{ex.Message}\n\n{ex.StackTrace}");
			}
		}

		private void ArgumentsBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
				SendArgumentsButton_Click(sender, e);
			//e.Handled = true;
		}

		private void HyperlinkLabel_Click(object sender, RoutedEventArgs e)
		{
			Process process = new Process();
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.FileName = HyperlinkLabel.NavigateUri.AbsoluteUri;
			process.Start();
		}
	}
}
