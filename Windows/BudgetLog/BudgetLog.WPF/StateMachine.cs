using System.Diagnostics;

namespace BudgetLog.WPF
{
	public class StateMachine
	{
		private State currentState;
		private StateMachine instance;
		public StateMachine()
		{
			if (instance == null)
			{
				instance = this;
			}
			else
			{
				Debug.Assert(false, "Instance is not null");
			}
			currentState = new MainMenu();
		}
	}
}
