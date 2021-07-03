using System.Collections.Generic;
public interface IIAPDialogConfigService : IService
{
    IAPDialogConfigDTO Get(string key);

    List<IAPDialogConfigDTO> GetAll();
}
