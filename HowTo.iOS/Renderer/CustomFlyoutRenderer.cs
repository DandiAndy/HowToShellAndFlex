using System;
using Xamarin.Forms.Platform.iOS;

namespace HowTo.iOS.Renderer
{
    public class CustomFlyoutRenderer : TabletShellFlyoutRenderer
    {
        private nfloat _flyoutWidth = 115;
        public override nfloat MaximumPrimaryColumnWidth { get => _flyoutWidth; }
        public override nfloat MinimumPrimaryColumnWidth { get => _flyoutWidth; }
    }
}
