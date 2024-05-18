namespace UtilityLib.UAttributes;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class UInfoAttribute : Attribute
{
    public string Description { get; }

    public UInfoAttribute(string description)
    {
        Description = description;
    }
}