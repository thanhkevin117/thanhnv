using System.Web;
using System.Web.Optimization;

namespace QLShopTT
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/vendor/fontawesome-free/css/all.min.css",
                "~/Content/css/sb-admin-2.min.css",
                      "~/Content/themes/base/jquery-ui.css",
                      //"~/datepicker/css/datepicker.css",
                      "~/Content/themes/base/datepicker.css",
                      "~/Content/mysite.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/css/sb-admin-2.min.css",
                      "~/Content/vendor/datatables/dataTables.bootstrap4.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/jQuery").Include(
                    "~/Scripts/jquery-3.3.1.min.js",
                    "~/Scripts/jquery-ui-1.12.1.min.js",
                    //"~/datepicker/js/bootstrap-datepicker.js",
                    "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                    "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                    "~/Content/vendor/datatables/jquery.dataTables.min.js",
                    "~/Content/vendor/datatables/dataTables.bootstrap4.min.js",
                    "~/Content/js/demo/datatables-demo.js"
                ));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                    "~/Content/js/sb-admin-2.min.js",
                    "~/Content/vendor/chart.js/Chart.min.js",
                    "~/Content/js/demo/chart-area-demo.js",
                    "~/Content/js/demo/chart-pie-demo.js",
                    "~/Content/js/custom-js/nhan_vien.js"
                ));
        }
    }
}
