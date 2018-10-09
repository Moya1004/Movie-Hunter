using System.Web;
using System.Web.Optimization;

namespace odev3
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/AdminJS").Include(
                      "~/Areas/Admin/Content/js/bootstrap-editable.min.js",
                      "~/Areas/Admin/Content/js/bootstrap-timepicker.js",
                      "~/Areas/Admin/Content/js/jquery-ui-1.8.23.custom.min.js",
                      "~/Areas/Admin/Content/js/custom-index.js",
                      "~/Areas/Admin/Content/js/custom-tables.js",
                      "~/Areas/Admin/Content/js/custom.js",
                      "~/Areas/Admin/Content/js/fullcalendar.js",
                      "~/Areas/Admin/Content/js/html5-trunk.js",
                      "~/Areas/Admin/Content/js/jquery.dataTables.js",
                      "~/Areas/Admin/Content/js/jquery.sparkline.js",
                      "~/Areas/Admin/Content/js/moment.js",
                      "~/Areas/Admin/Content/js/select2.js",
                      "~/Areas/Admin/Content/js/tiny-scrollbar.js",
                      "~/Areas/Admin/Content/js/wysiwyg/bootstrap-wysihtml5.js",
                      "~/Areas/Admin/Content/js/wysiwyg/wysihtml5-0.3.0.js",
                      "~/Areas/Admin/Content/js/date-picker/date.js",
                      "~/Areas/Admin/Content/js/date-picker/daterangepicker.js"));
            bundles.Add(new StyleBundle("~/Content/AdminCss").Include(
                      "~/Areas/Admin/Content/css/bootstrap-editable.css",
                      "~/Areas/Admin/Content/css/fullcalendar.css",
                      "~/Areas/Admin/Content/css/main.css",
                      "~/Areas/Admin/Content/css/morris.css",
                      "~/Areas/Admin/Content/css/nvd-charts.css",
                      "~/Areas/Admin/Content/css/select2.css",
                      "~/Areas/Admin/Content/css/style.css",
                      "~/Areas/Admin/Content/css/timepicker.css",
                      "~/Areas/Admin/Content/css/wysiwyg/bootstrap-wysihtml5.css",
                      "~/Areas/Admin/Content/css/wysiwyg/wysiwyg-color.css"));
        }
    }
}
