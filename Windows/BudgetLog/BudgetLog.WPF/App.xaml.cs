using System;
using System.Windows;

namespace BudgetLog.WPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private StateMachine stateMachine;
		private App()
		{
			stateMachine = new StateMachine();
		}

		[STAThread]
		private static void Main()
		{
			App app = new App();
			app.Run();
		}
	}
}
