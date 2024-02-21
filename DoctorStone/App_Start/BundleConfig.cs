using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DoctorStone.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Font Awesome style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                "~/Vendors/vendor/fontawesome/css/font-awesome.css", new CssRewriteUrlTransform()));

            //metisMenu style
            bundles.Add(new StyleBundle("~/bundles/metisMenu/css").Include(
                "~/Vendors/vendor/metisMenu/dist/metisMenu.css", new CssRewriteUrlTransform()));

            //animate style
            bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
                "~/Vendors/vendor/animate.css/animate.css", new CssRewriteUrlTransform()));

            //bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Vendors/vendor/bootstrap/dist/css/bootstrap.css", new CssRewriteUrlTransform()));

            //pe-icon-7-stroke style
            bundles.Add(new StyleBundle("~/bundles/pe-icon-7-stroke/css").Include(
                "~/Vendors/fonts/pe-icon-7-stroke/css/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

            //helper style
            bundles.Add(new StyleBundle("~/bundles/helper/css").Include(
                "~/Vendors/fonts/pe-icon-7-stroke/css/helper.css", new CssRewriteUrlTransform()));

            //style style
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                "~/Vendors/styles/style.css", new CssRewriteUrlTransform()));

            //Scripts

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                "~/Vendors/vendor/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui/js").Include(
                "~/Vendors/vendor/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-slimscroll/js").Include(
                "~/Vendors/vendor/slimScroll/jquery.slimscroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Vendors/vendor/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot/js").Include(
                "~/Vendors/vendor/jquery-flot/jquery.flot.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-resize/js").Include(
                "~/Vendors/vendor/jquery-flot/jquery.flot.resize.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-pie/js").Include(
                "~/Vendors/vendor/jquery-flot/jquery.flot.pie.js"));

            bundles.Add(new ScriptBundle("~/bundles/curvedLines/js").Include(
                "~/Vendors/vendor/flot.curvedlines/curvedLines.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-flot-spline/js").Include(
                "~/Vendors/vendor/jquery.flot.spline/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/metisMenu/js").Include(
                "~/Vendors/vendor/metisMenu/dist/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/iCheck/js").Include(
                "~/Vendors/vendor/iCheck/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/peity/js").Include(
                "~/Vendors/vendor/peity/jquery.peity.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sparkline/js").Include(
                "~/Vendors/vendor/sparkline/index.js"));

            //App scripts
            bundles.Add(new ScriptBundle("~/bundles/homer/js").Include(
                "~/Vendors/scripts/homer.js"));

            bundles.Add(new ScriptBundle("~/bundles/charts/js").Include(
                "~/Vendors/scripts/charts.js"));

        }
    }
}