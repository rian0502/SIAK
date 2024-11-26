using System.ComponentModel.DataAnnotations;

namespace DAHAR.ViewModels.SubUnit;

public class EditSubUnitViewModel
{
    [Required(ErrorMessage = "Missing Attribute Field")]
    public int SubUnitId { get; set; }
    [Required(ErrorMessage = "SubUnit Code is required")]
    public required string SubUnitCode { get; set; }
    [Required(ErrorMessage = "SubUnit Name is required")]
    public required string SubUnitName { get; set; }
    [Required(ErrorMessage = "SubUnit Address is required")]
    public required string SubUnitAddress { get; set; }
    [Required(ErrorMessage = "Location is required")]
    public required int LocationId { get; set; }
    [Required(ErrorMessage = "Unit is required")]
    public required int UnitId { get; set; }
}