using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLog.WPF
{
	public class MainMenu : State
	{
		public MainMenu() 
		{
			window = new MainWindow();
			window.Show();
		}
	}
}
