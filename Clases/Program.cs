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
        List<Pedido> lista=aux.read_csv();
        List<Pedido> lista_express=new List<Pedido>();
        List<Pedido> lista_normal = new List<Pedido>();
        List<Pedido> lista_diferido = new List<Pedido>();

       
        for (int i=0; i<lista.Count; i++)
        {
            
            Pedido aux3 = lista[i];

            if (aux3.prioridad.Equals("normal"))
                lista_normal.Add(aux3);
            if (aux3.prioridad.Equals("diferido"))
                lista_diferido.Add(aux3);
            if (aux3.prioridad.Equals("express"))
                lista_express.Add(aux3);

        }

        System.Diagnostics.Debug.WriteLine("Test");
        ApplicationConfiguration.Initialize();
       /*
        Form1 aux2 = new Form1();
        aux2.label1.Text=("Lei el archivo.");
        Application.Run(aux2);*/
        int[] val = new int[] { 60, 100, 120 };
        int[] wt = new int[] { 10, 20, 30 };
        int W = 50;
        int n = val.Length;

        //Console.WriteLine(Algoritmo_Mochila1());

    }    
}