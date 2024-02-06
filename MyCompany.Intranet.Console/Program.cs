
public static class Program {
    public static void Main(string[] args) {
       double sueldo = 0;
       string nombre = "";
       int horas_trabajadas = 0;
       double sueldo_por_hora = 20;

        System.Console.WriteLine("Ingrese el nombre del empleado: ");
        nombre = System.Console.ReadLine();
        System.Console.WriteLine("Ingrese las horas trabajadas: ");
        horas_trabajadas = int.Parse(System.Console.ReadLine());

        if (horas_trabajadas > 40)
        {
            sueldo = (40 * sueldo_por_hora) + ((horas_trabajadas - 40) * (25));
        }
        else
        {
            sueldo = horas_trabajadas * sueldo_por_hora;
        }

        System.Console.WriteLine("El empleado " + nombre + " trabajó " + horas_trabajadas + " horas y su sueldo es de " + sueldo + " pesos. MXN");
    }
}