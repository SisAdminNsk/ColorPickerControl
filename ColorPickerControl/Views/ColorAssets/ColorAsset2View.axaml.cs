using Avalonia.Controls;
using Avalonia.Controls.Shapes;

namespace ColorPickerControl.Views.ColorAssets
{
    public partial class ColorAsset2View : UserControl
    {
        public ColorAsset2View()
        {
            InitializeComponent();
        }

        private void RectangleTappedHandler(object? sender, Avalonia.Input.TappedEventArgs e)
        {
            if (sender is Rectangle rect && rect.DataContext is ViewModels.ColorAssets.BaseColorAssetViewModel vm)
            {
                vm.ChooseColor(rect);
            }
        }
    }
}

