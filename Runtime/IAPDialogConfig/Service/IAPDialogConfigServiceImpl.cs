
using System.Collections.Generic;

public class IAPDialogConfigServiceImpl : IIAPDialogConfigService
{
    private LocalIAPDialogConfigRepository localRepository = new LocalIAPDialogConfigRepository("iap_dialog");
    
    public IAPDialogConfigDTO Get(string key)
    {
        IAPDialogConfigEntity entity = localRepository.FindById(key);
        IAPDialogConfigDTO dto = IAPDialogConfigDTOConvertor.From(entity);

        return dto;
    }

    public List<IAPDialogConfigDTO> GetAll()
    {
        List<IAPDialogConfigEntity> entities = localRepository.FindAll();
        List<IAPDialogConfigDTO> dtos = IAPDialogConfigDTOConvertor.From(entities);
        
        return dtos;
    }

    public void init()
    {
        localRepository.init();
    }

    public void lazyInit()
    {
        localRepository.lazyInit();
    }

    public void refresh()
    {
        localRepository.refresh();
    }

}
