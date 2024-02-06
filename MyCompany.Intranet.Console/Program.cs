using System;
using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Managers;
using MyCompany.Intranet.Core.Services;

public static class Program {
    public static void Main(string[] args) {

        float altura = 0;
        float peso = 0;

        System.Console.WriteLine("Please enter the Weight");
        Single.TryParse(System.Console.ReadLine(), out peso);


        System.Console.WriteLine("Please enter the Height");
        Single.TryParse(System.Console.ReadLine(), out altura);


        var Bmi = new Bmi();
        var person = new Person{Weight = peso, Height = altura};

        var service = new BmiService();
        var managers = new BmiManager(service);

        Bmi bmi = managers.GetBmi(person);

        System.Console.WriteLine($"BMI {bmi.Index} Type {bmi.BmiType}");

        
    }
}