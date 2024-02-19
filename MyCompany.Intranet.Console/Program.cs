using System;
using PRACTICA_3_ISR_CORE.Entities;
using PRACTICA_3_ISR_CORE.Managers;
using PRACTICA_3_ISR_CORE.Services;

// using MyCompany.Intranet.Core.Entities;
// using MyCompany.Intranet.Core.Enums;
// using MyCompany.Intranet.Core.Managers;
// using MyCompany.Intranet.Core.Services;

public static class Program {
    public static void Main(string[] args) {

        // float altura = 0;
        // float peso = 0;

        // System.Console.WriteLine("Please enter the Weight");
        // Single.TryParse(System.Console.ReadLine(), out peso);


        // System.Console.WriteLine("Please enter the Height");
        // Single.TryParse(System.Console.ReadLine(), out altura);


        // var Bmi = new Bmi();
        // var person = new Person{Weight = peso, Height = altura};

        // var service = new BmiService();
        // var managers = new BmiManager(service);

        // Bmi bmi = managers.GetBmi(person);

        // System.Console.WriteLine($"BMI {bmi.Index} Type {bmi.BmiType}");

        /*double sueldo = 0;
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

        System.Console.WriteLine("El empleado " + nombre + " trabajó " + horas_trabajadas + " horas y su sueldo es de " + sueldo + " pesos. MXN");*/
        
        
        
        
        float sueldo = 0;
        
        System.Console.WriteLine("Porfavor ingresa el sueldo: ");
        Single.TryParse(System.Console.ReadLine(), out sueldo);
        
        var person = new PersonISR {Sueldo = sueldo};

        var service = new SueldoService();
        var managers = new SueldoManager(service);

        Sueldo isr = managers.GetISR(person);
        
        System.Console.WriteLine($"Resultado = {isr.Resultado}, Base = {isr.Base}, Nivel = {isr.SueldoType},  ISR = {isr.ISR}");

        
    }
}