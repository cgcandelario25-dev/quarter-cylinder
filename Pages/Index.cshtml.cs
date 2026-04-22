using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty] public double Radius { get; set; }
    [BindProperty] public double Height { get; set; }

    [BindProperty] public double CutLength { get; set; }
    [BindProperty] public double CutWidth { get; set; }
    [BindProperty] public double CutHeight { get; set; }

    public double Result { get; set; }
    public bool HasResult { get; set; }

    public void OnPost()
    {
        double quarterCylinder = 0.25 * Math.PI * Radius * Radius * Height;
        double cutout = CutLength * CutWidth * CutHeight;

        Result = Math.Max(0, quarterCylinder - cutout);

        HasResult = true;
    }
}