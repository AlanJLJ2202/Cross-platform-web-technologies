using PRACTICA_3_ISR_CORE.Enums;
namespace PRACTICA_3_ISR_CORE.Entities;

public class Sueldo
{
    public float Base {get; set;}
    public float Resultado {get; set;}
    public float ISR {get; set;}
    public SueldoType SueldoType {get; set;}
}