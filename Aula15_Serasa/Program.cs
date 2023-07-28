namespace Aula15_Serasa
{
    internal class Program
    {
        public static List<Cliente> cliente = new List<Cliente>();
       // fazer a lista no program faz com que todos consigam ver
       // static = cliente parado, nunca vai mudar

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}