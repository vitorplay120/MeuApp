using Treinamento_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Treinamento_App.Droid;
using Treinamento_App;
using Android.Content;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Treinamento_App
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}
