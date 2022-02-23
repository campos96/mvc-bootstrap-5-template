using System.Web;
using System.Web.Optimization;

namespace mvc_bootstrap_5_template
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.bundle.js",
                "~/Scripts/modernizr-*",
                "~/Scripts/jquery.validate*",
                "~/Scripts/DataTables/jquery.dataTables.js",
                "~/Scripts/DataTables/dataTables.bootstrap5.min.js"));

            bundles.Add(new Bundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/DataTables/css/jquery.dataTables.css",
                "~/Content/DataTables/css/dataTables.bootstrap5.css",
                "~/Content/font-awesome.css"));
        }
    }
}
