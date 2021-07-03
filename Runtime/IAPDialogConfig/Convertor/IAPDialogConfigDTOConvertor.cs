using System.Collections.Generic;
public class IAPDialogConfigDTOConvertor
{
    public static IAPDialogConfigDTO From(IAPDialogConfigEntity entity)
    {
        IAPDialogConfigDTO dto = new IAPDialogConfigDTO();

        dto.Id = entity.id;
        dto.Enable = entity.enable > 0;
        dto.RestrictMinutes = entity.restrictMinutes;

        return dto;
    }

    public static List<IAPDialogConfigDTO> From(List<IAPDialogConfigEntity> entities)
    {
        List<IAPDialogConfigDTO> dtos = new List<IAPDialogConfigDTO>();
        foreach (var item in entities)
        {
            dtos.Add(From(item));
        }
        return dtos;
    }
}
