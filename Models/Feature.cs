using System.ComponentModel.DataAnnotations;

namespace Vega.net;

public class Feature
{
    public int Id { get; set; }
    [Required]
    [StringLength(250)]
    public  string Name { get; set; }

}
