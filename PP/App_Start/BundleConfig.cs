using System.Web;
using System.Web.Optimization;

namespace PP
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/custom.js",
                        "~/Scripts/datatables/datatables.bootstrap.js",
                        "~/Content/select2/dist/js/select2.min.js",
                        "~/Content/tinymce/js/tinymce/tinymce.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/chart/dist/Chart.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-sandstone.css",
                      "~/Content/custom.min.css",
                      "~/Content/datatables/css/datatables.bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/select2/dist/css/select2.min.css",
                      "~/Content/site.css"));
        }
    }
}
