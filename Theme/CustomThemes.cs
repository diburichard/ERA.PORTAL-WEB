using MudBlazor;

namespace ERA.PORTAL_WEB.Theme
{
    public class CustomThemes
    {
        public static MudTheme CiberITTheme = new MudTheme()
        {
            PaletteLight = new PaletteLight() // Use the derived class PaletteLight instead of the abstract class Palette
            {
                Primary = "#1e88e5",    
                Secondary = "#43a047",
                Background = "#f4faff",
                AppbarBackground = "#1565c0",
                DrawerBackground = "#e3f2fd"
            }
        };

        public static MudTheme DlpTheme = new MudTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#9c27b0",
                Secondary = "#ff9800",
                Background = "#f3e5f5",
                AppbarBackground = "#6a1b9a",
                DrawerBackground = "#ffe0b2"
            }
        };

    }
}
