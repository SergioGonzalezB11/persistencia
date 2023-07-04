using persistencia.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Controladores  controller = new Controladores();
        bool isActive = false;
        int opc = 0;
        do{
            Console.WriteLine("1.Crear Registro\n2.Editar dato\n3.Salir");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc){
                case 1:
                    controller.AddInfo();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el codigo del equipo a modificar";);
                    controller.EditDataFile(Console.ReadLine() ?? String.Empty);
                    break;
                case 3:
                    isActive = false;
                    break;
                default:
                    break;
        }
        }
        while(isActive);
    }
}