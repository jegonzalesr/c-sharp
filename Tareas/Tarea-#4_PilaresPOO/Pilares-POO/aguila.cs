public class aguila : ClaseBaseAves

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

    public aguila()
    {
        SetColorPlumas(GetColorPlumas());
    }
}