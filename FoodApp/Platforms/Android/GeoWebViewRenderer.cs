using Android.Content;
using Android.Webkit;
using FoodApp.Platforms.Android;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: ExportRenderer(typeof(Microsoft.Maui.Controls.WebView), typeof(GeoWebViewRenderer))]
namespace FoodApp.Platforms.Android
{
    public class GeoWebViewRenderer : WebViewRenderer
    {
        public GeoWebViewRenderer(Context context) : base(context)
        {
        }
        
        protected override void OnElementChanged(ElementChangedEventArgs<Microsoft.Maui.Controls.WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.JavaScriptEnabled = true;
            Control.SetWebChromeClient(new MyWebClient());
        }
    }

    public class MyWebClient : WebChromeClient
    {
        public override void OnGeolocationPermissionsShowPrompt(string origin, GeolocationPermissions.ICallback callback)
        {
            callback.Invoke(origin, true, false);
        }
    }

}
