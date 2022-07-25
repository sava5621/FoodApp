using Android.Content;
using Android.Webkit;
using FoodApp.Controlers;
using FoodApp.Platforms.Android.CastomRender;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebView = Android.Webkit.WebView;

[assembly: ExportRenderer(typeof(WebViewer), typeof(WebViewRender))]
namespace FoodApp.Platforms.Android.CastomRender
{
    [Obsolete]
    public class WebViewRender : WebViewRenderer
    {
        public WebViewRender(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Microsoft.Maui.Controls.WebView> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {

                WebView webview = (WebView)Control;
                WebSettings settings = webview.Settings;


                settings.JavaScriptEnabled = true;

            }
            var webView = e.NewElement as WebViewer;

            if (webView != null)
                webView.EvaluateJavascript = async (js) =>
                {
                    var reset = new ManualResetEvent(false);
                    var response = string.Empty;
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Control?.EvaluateJavascript(js, new JavascriptCallback((r) => { response = r; reset.Set(); }));
                    });
                    await Task.Run(() => { reset.WaitOne(); });
                    return response;
                };

        }
        internal class JavascriptCallback : Java.Lang.Object, IValueCallback
        {
            public JavascriptCallback(Action<string> callback)
            {
                _callback = callback;
            }

            private Action<string> _callback;
            public void OnReceiveValue(Java.Lang.Object value)
            {
                _callback?.Invoke(Convert.ToString(value));
            }
        }



    }
}
