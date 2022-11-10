namespace tp_final;
using csvfiles; 
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
        
    }    
}