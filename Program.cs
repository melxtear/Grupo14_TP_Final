namespace tp_final;
using csvfiles;
using static tp_final.Mochila;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        _csv aux = new _csv();
        aux.read_csv();
        Console.WriteLine("Lei archivo.");
        ApplicationConfiguration.Initialize();
       
        Form1 aux2 = new Form1();
        aux2.label1.Text=("Lei el archivo.");
        Application.Run(aux2);
        int[] val = new int[] { 60, 100, 120 };
        int[] wt = new int[] { 10, 20, 30 };
        int W = 50;
        int n = val.Length;

        Console.WriteLine(knapSack(W, wt, val, n));

    }    
}