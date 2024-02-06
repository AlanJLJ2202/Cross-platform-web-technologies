using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Core.Managers.Interfaces;


//namespace MyCompany.Intranet.Core.Managers.Interfaces;
//namespace MyCompany.Intranet.Core.Services.Interfaces;


public interface IBmiManager {

    Bmi GetBmi (Person person);

}