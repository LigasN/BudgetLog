using System;

public class Program
{
    public static void Main()
    {
        var application = new App();
        var graphics = new BudgetLog.WPF.App();
        graphics.InitializeComponent();
        graphics.Run();
    }
}
