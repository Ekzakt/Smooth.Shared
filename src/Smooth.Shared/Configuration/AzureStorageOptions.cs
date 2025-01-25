namespace Smooth.Shared.Configuration;

#nullable disable

public class AzureStorageOptions
{
    public const string SectionName = "Azure:Storage";

    public string ServiceUri { get; set; }
}