using System.ComponentModel.DataAnnotations;

namespace WifiCode.Data;

public class WifiDetails
{
    [Required]
    public string? Ssid { get; set; }
    
    [Required]
    public string? Password { get; set; }

    public string Title { get; set; } = "Guest Wi-Fi details";

    public string Footer { get; set; } = "";
}
