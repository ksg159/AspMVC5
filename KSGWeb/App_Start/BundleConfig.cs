using System.Web;
using System.Web.Optimization;

namespace KSGWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Component/jquery/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
           /* bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));*/

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Component/Bootstrap/js/bootstrap.js",
                      "~/Component/Bootstrap/js/poper.js"
                      ));

            bundles.Add(new StyleBundle("~/Compoent/css").Include(
                      "~/Component/Bootstrap/css/bootstrap.css",
                      "~/Component/Site/site.css"
                      ));

            
        }
    }
}
