using System;
using HowTo;
using HowTo.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AppShell), typeof(CustomShellRenderer))]
namespace HowTo.iOS.Renderer
{
    public class CustomShellRenderer : ShellRenderer
    {
        protected override IShellFlyoutRenderer CreateFlyoutRenderer()
        {
            //return base.CreateFlyoutRenderer();
            return new CustomFlyoutRenderer();
        }
    }
}
