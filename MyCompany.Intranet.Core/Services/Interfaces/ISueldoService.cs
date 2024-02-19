using PRACTICA_3_ISR_CORE.Entities;

namespace PRACTICA_3_ISR_CORE.Services.Interfaces;

public interface ISueldoService
{
    Sueldo ProcessISR(PersonISR personIsr);
}