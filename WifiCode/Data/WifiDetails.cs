using System.ComponentModel.DataAnnotations;

namespace WifiCode.Data;

public class WifiDetails
{
    [Required, MinLength(1)]
    public string? Ssid { get; set; }
    
    [Required, MinLength(1)]
    public string? Password { get; set; }
    
    public string? Title { get; set; }
    
    public string? Footer { get; set; }
}
