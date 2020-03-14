using System.Windows;

namespace BudgetLog.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() { InitializeComponent(); }

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			// TODO: Save system with SQL
		}

		private void NewRecordButton_Click(object sender, RoutedEventArgs e) 
		{
			// TODO: Create newRecordState
			// TODO: Changing state to newRecordState
		}

		private void CurrentStateButton_Click(object sender, RoutedEventArgs e)
		{
			// TODO: Create CurrentState State
			// TODO: Changing state to CurrentState State
		}

		private void PlannerButton_Click(object sender, RoutedEventArgs e) 
		{
			// TODO: Create PlannerState
			// TODO: Changing state to PlannerState
		}

		private void SettingsButton_Click(object sender, RoutedEventArgs e) 
		{
			// TODO: Create SettingsState
			// TODO: Changing state to SettingsState
		}
	}
}
