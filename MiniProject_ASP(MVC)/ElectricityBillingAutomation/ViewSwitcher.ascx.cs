using System;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace ElectricityBillingAutomation
{
    public partial class ViewSwitcher : UserControl
    {
        public string CurrentView { get; private set; }
        public string AlternateView { get; private set; }
        public string SwitchUrl { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var isMobile = WebFormsFriendlyUrlResolver.IsMobileView(new HttpContextWrapper(Context));
            CurrentView = isMobile ? "Mobile" : "Desktop";
            AlternateView = isMobile ? "Desktop" : "Mobile";

            var switchViewRouteName = "AspNet.FriendlyUrls.SwitchView";
            var switchViewRoute = RouteTable.Routes[switchViewRouteName];
            if (switchViewRoute == null)
            {
                this.Visible = false;
                return;
            }

            var url = GetRouteUrl(switchViewRouteName, new { view = AlternateView, __FriendlyUrls_SwitchViews = true });
            url += "?ReturnUrl=" + HttpUtility.UrlEncode(Request.RawUrl);
            SwitchUrl = url;
        }
    }
}
