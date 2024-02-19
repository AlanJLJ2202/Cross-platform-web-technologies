using PRACTICA_3_ISR_CORE.Entities;
using PRACTICA_3_ISR_CORE.Enums;
using PRACTICA_3_ISR_CORE.Services.Interfaces;

namespace PRACTICA_3_ISR_CORE.Services;

public class SueldoService : ISueldoService
{
    public Sueldo ProcessISR(PersonISR personIsr)
    {
        Sueldo ObjetoSueldo = new Sueldo();

        float sueldo = personIsr.Sueldo;
        float cuota_fija = 0;
        float sobre_excedente = 0;
        float monto_limite_inferior = 0;

        if (sueldo > 0.01 && sueldo < 7735)
        {
            cuota_fija = 0;
            sobre_excedente = 1.92f;
            monto_limite_inferior = 0.01f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_1;
        }
        if (sueldo >= 7735.01 && sueldo < 65651.07)
        {
            cuota_fija = 148.51f;
            sobre_excedente = 6.40f;
            monto_limite_inferior = 7735.01f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_2;
        }
        if (sueldo >= 65651.08 && sueldo < 115375.90)
        {
            cuota_fija = 3855.14f;
            sobre_excedente = 10.88f;
            monto_limite_inferior = 65651.08f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_3;
        }
        if (sueldo >= 115375.91 && sueldo < 134119.41)
        {
            cuota_fija = 9265.20f;
            sobre_excedente = 16.00f;
            monto_limite_inferior = 115375.91f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_4;
        }
        if (sueldo >= 134119.42 && sueldo < 160577.65)
        {
            cuota_fija = 12264.16f;
            sobre_excedente = 17.92f;
            monto_limite_inferior = 134119.42f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_5;
        }
        if (sueldo >= 160577.66 && sueldo < 323862.00)
        {
            cuota_fija = 17005.47f;
            sobre_excedente = 21.36f;
            monto_limite_inferior = 160577.66f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_6;
        }
        if (sueldo >= 323862.01 && sueldo < 510451.00)
        {
            cuota_fija = 51883.01f;
            sobre_excedente = 23.52f;
            monto_limite_inferior = 323862.01f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_7;
        }
        if (sueldo >= 510451.01 && sueldo < 974535.03)
        {
            cuota_fija = 95768.74f;
            sobre_excedente = 30.00f;
            monto_limite_inferior = 510451.01f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_8;
        }
        if (sueldo >= 974535.04 && sueldo < 1299380.04)
        {
            cuota_fija = 234993.95f;
            sobre_excedente = 33.00f;
            monto_limite_inferior = 974535.04f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_9;
        }
        if (sueldo >= 1299380.05 && sueldo < 3898140.12)
        {
            cuota_fija = 338944.34f;
            sobre_excedente = 34.00f;
            monto_limite_inferior = 1299380.05f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_10;
        }
        if (sueldo >= 3898140.13)
        {
            cuota_fija = 1222522.76f;
            sobre_excedente = 35.00f;
            monto_limite_inferior = 3898140.13f;
            ObjetoSueldo.SueldoType = SueldoType.Nivel_11;
        }
        
        
        ObjetoSueldo.Base = sueldo - monto_limite_inferior;
        ObjetoSueldo.Resultado = ObjetoSueldo.Base * (sobre_excedente / 100);
        ObjetoSueldo.ISR = ObjetoSueldo.Resultado + cuota_fija;
        
        


        return ObjetoSueldo;

        /*weigthMarte.Weight = (person.Weight/9.81f * 0.37f)*10;

        if (weigthMarte.Weight < 18.5)
        {
            weigthMarte.BmiType = WeigthType.Low;
        }
        else if (weigthMarte.Weight >= 18.5)
        {
            weigthMarte.BmiType = WeigthType.Normal;
        }
        else if (weigthMarte.Weight >= 24.9)
        {
            weigthMarte.BmiType = WeigthType.Overweigth;
        }
        else
        {
            weigthMarte.BmiType = WeigthType.Obesity;
        }

        return weigthMarte;*/
    }
}