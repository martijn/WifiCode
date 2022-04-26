using System.ComponentModel.DataAnnotations;

namespace WifiCode.Data;

public class WifiDetails
{
    [Required]
    public string? Ssid { get; set; }
    
    [Required]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string? Password { get; set; }

    public string Title { get; set; } = "Guest Wi-Fi details";

    public string Footer { get; set; } = "";
}
