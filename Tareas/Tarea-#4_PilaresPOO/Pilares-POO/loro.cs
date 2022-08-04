public class loro : ClaseBaseAves
{
    private string colorPlumas;

    public string GetColorPlumas()
    {
        return colorPlumas;
    }

    public void SetColorPlumas(string value)
    {
        colorPlumas = value;
    }

    public loro()
    {
        SetColorPlumas(GetColorPlumas());
    }
}
