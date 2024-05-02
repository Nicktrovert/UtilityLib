namespace UtilityLib.UAttributes;

[AttributeUsage(AttributeTargets.Class)]
public class UInfoAttribute : Attribute
{
    public string Description { get; }

    public UInfoAttribute(string description)
    {
        Description = description;
    }
}
