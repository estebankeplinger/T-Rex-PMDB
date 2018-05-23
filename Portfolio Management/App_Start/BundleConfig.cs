using System;
using System.Web;
using System.Web.Optimization;

namespace Portfolio_Management
{
    public class BundleConfig
    {

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
       

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

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

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/vendors/font-awesome/css/font-awesome.min.css",
                      "~/vendors/nprogress/nprogress.css",
                      "~/vendors/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.min.css",
                      "~/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/vendors/iCheck/skins/flat/green.css",
                      "~/vendors/bootstrap-daterangepicker/daterangepicker.css",
                      "~/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                      "~/build/css/custom.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/vendors/jquery/dist/jquery.min.js",
                      "~/vendors/bootstrap/dist/js/bootstrap.min.js",
                      "~/vendors/fastclick/lib/fastclick.js",
                      "~/vendors/nprogress/nprogress.js",
                      "~/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/build/js/custom.min.js",
                      "~/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                      "~/vendors/moment/min/moment.min.js",
                      "~/vendors/bootstrap-daterangepicker/daterangepicker.js",
                      "~/vendors/Chart.js/dist/Chart.min.js",
                      "~/vendors/gauge.js/dist/gauge.min.js",
                      "~/vendors/iCheck/icheck.min.js",
                      "~/vendors/skycons/skycons.js",
                      "~/vendors/Flot/jquery.flot.js",
                      "~/vendors/Flot/jquery.flot.pie.js",
                      "~/vendors/Flot/jquery.flot.time.js",
                      "~/vendors/Flot/jquery.flot.stack.js",
                      "~/vendors/Flot/jquery.flot.resize.js",
                      "~/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                      "~/vendors/flot-spline/js/jquery.flot.spline.min.js",
                      "~/vendors/flot.curvedlines/curvedLines.js",
                      "~/vendors/DateJS/build/date.js",
                      "~/vendors/moment/min/moment.min.js",
                      "~/vendors/bootstrap-daterangepicker/daterangepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(

                        //datatables.net
                        "~/vendors/datatables.net/js/jquery.dataTables.js",
                        "~/vendors/datatables.net/js/jquery.dataTables.min.js",

                        //datatables.net-bs
                        "~/vendors/datatables.net-bs/js/dataTables.bootstrap.js",
                        "~/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",

                        //datatables.net-buttons
        /*
                        "~/vendors/datatables.net-buttons/js/buttons.colVis.js",
                        "~/vendors/datatables.net-buttons/js/buttons.colVis.min.js",
                        "~/vendors/datatables.net-buttons/js/buttons.flash.js",
                        "~/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                        "~/vendors/datatables.net-buttons/js/buttons.html5.js",
                        "~/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                        "~/vendors/datatables.net-buttons/js/buttons.print.js",
                        "~/vendors/datatables.net-buttons/js/buttons.print.min.js",
                        "~/vendors/datatables.net-buttons/js/dataTables.buttons.js",
                        "~/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",

                        //datatables.net-buttons-bs
                        "~/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.js",
                        "~/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
       */

                        //datatables.net-fixedheader
                        "~/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.js",
                        "~/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",

                         //datatables.net-keytable
                         "~/vendors/datatables.net-keytable/js/dataTables.keyTable.js",
                        "~/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",

                        //datatables.net-responsive
                         "~/vendors/datatables.net-responsive/js/dataTables.responsive.js",
                        "~/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",

                        //datatables.net-responsive-bs
                         "~/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",

                         //datatables.net-scroller
                         "~/vendors/datatables.net-scroller/js/dataTables.scroller.js",
                         "~/vendors/datatables.net-scroller/js/dataTables.scroller.min.js"

                        ));

            bundles.Add(new StyleBundle("~/Content/dataTables").Include(

                    //datatables.net-bs
                    "~/vendors/datatables.net-bs/css/dataTables.bootstrap.css",
                    "~/vendors/datatables.net-bs/css/dataTables.bootstrap.min.css",

                    /*
                    //datatables.net-buttons-bs
                    "~/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.css",
                    "~/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
                    */
                    //datatables.net-fixedheader-bs
                    "~/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.css",
                    "~/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",

                    //datatables.net-responsive-bs
                    "~/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.css",
                    "~/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",

                    //datatables.net-scroller-bs
                    "~/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.css",
                    "~/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"
                      ));
        }
    }
}
