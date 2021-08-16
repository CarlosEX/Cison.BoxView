
namespace Cison.BoxView {
    public class BoxViewFactory {
        public static void Show(
            IconBox iconBox, 
            ThemeBox themeBox = ThemeBox.Light,
            BoxViewBorderStyle borderStyle = BoxViewBorderStyle.SizeDialog) {
            
            new BoxView().Show(iconBox, themeBox, borderStyle);
        }
        public static void Show(
            IconBox iconBox, 
            string message, 
            ThemeBox themeBox = ThemeBox.Light,
            BoxViewBorderStyle borderStyle = BoxViewBorderStyle.SizeDialog) {
            
            new BoxView().Show(iconBox, message, themeBox, borderStyle);
        }
    }
}
