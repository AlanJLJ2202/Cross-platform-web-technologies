using PRACTICA_3_ISR_CORE.Entities;
using PRACTICA_3_ISR_CORE.Services.Interfaces;

namespace PRACTICA_3_ISR_CORE.Managers;

public class SueldoManager : ISueldoManager
{
    
    private readonly ISueldoService _sueldoService;

    public SueldoManager(ISueldoService sueldoService)
    {
        _sueldoService = sueldoService;
    }
    
    public Sueldo GetISR(PersonISR personIsr)
    {
        return _sueldoService.ProcessISR(personIsr);
    }
}
