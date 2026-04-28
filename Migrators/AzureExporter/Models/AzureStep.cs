using System.Xml.Serialization;

namespace AzureExporter.Models;

[XmlRoot("steps")]
public class AzureSteps
{
    [XmlElement("step")]
    public List<AzureStep> Steps { get; set; }

    [XmlElement("compref")]
    public List<AzureSharedStep> SharedSteps { get; set; }
}

public class AzureStep
{
    [XmlElement("parameterizedString")]
    public List<AzureParameterizedString> Values { get; set; }
}

public class AzureSharedStep
{
    [XmlAttribute("ref")]
    public int Id { get; set; }

    [XmlElement("step")]
    public List<AzureStep> Steps { get; set; }
}

public class AzureParameterizedString
{
    // plain text
    [XmlText]
    public string TextValue { get; set; } = string.Empty;

    // <text> tag
    [XmlElement("text")]
    public string WrappedTextValue { get; set; } = string.Empty;

    public string GetValue()
    {
        return string.IsNullOrEmpty(WrappedTextValue) ? TextValue : WrappedTextValue;
    }
}
