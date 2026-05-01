using System.ComponentModel.DataAnnotations;

namespace TestRailExporter.Models.Client;


public class TestRailConfig
{
    [Required]
    public string Url { get; set; } = string.Empty;
    [Required]
    public string ProjectName { get; set; } = string.Empty;
    [Required]
    public string Login { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;

    [Range(1, int.MaxValue)]
    public int RequestTimeoutSeconds { get; set; } = 100;
}

public class AppConfig
{
    [Required]
    public string ResultPath { get; set; } = string.Empty;
    [Required]
    public TestRailConfig TestRail { get; set; } = new();
}
