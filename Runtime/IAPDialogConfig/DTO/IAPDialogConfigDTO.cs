
/// <summary>
/// {"id":"app_open_ad_close","enable":1,"restrictMinutes":30}
/// </summary>
/// 
[System.Serializable]
public class IAPDialogConfigDTO
{
    private string id;

    private bool enable;

    private int restrictMinutes;

    public string Id { get => id; set => id = value; }
    public bool Enable { get => enable; set => enable = value; }
    public int RestrictMinutes { get => restrictMinutes; set => restrictMinutes = value; }

    public override string ToString()
    {
        return string.Format("[IAPDialogConfigDTO - id:{0} enable:{1} restrictMinutes:{2}]", id, enable, restrictMinutes);
    }
}
