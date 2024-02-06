using MyCompany.Intranet.Core.Entities;


namespace MyCompany.Intranet.Core.Services.Interfaces;
//namespace MyCompany.Intranet.Core.Managers.Interfaces;



public interface IBmiService {
    Bmi ProcessBmi (Person person);
}