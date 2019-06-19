using System.Web;
using System.Web.Optimization;

namespace Investis.Web
{
    public class BundleConfig
    {
       

            public static void RegisterBundles(BundleCollection bundles)
            {

                var scriptBundle = new ScriptBundle("~/Scripts/bundle");
                var styleBundle = new StyleBundle("~/Content/bundle");

                // jQuery
                scriptBundle
                    .Include("~/Scripts/jquery-2.2.3.js");

                // Bootstrap
                scriptBundle
                    .Include("~/Scripts/bootstrap.js");

                // Bootstrap
                styleBundle
                    .Include("~/Content/bootstrap.css");

                // Custom site styles
                styleBundle
                    .Include("~/Content/Site.css");



                //Template bundling
                //Scripts
                scriptBundle
                  .Include("~/assets/vendors/jquery/dist/jquery.min.js");
                scriptBundle
               .Include("~/assets/vendors/popper.js/dist/umd/popper.min.js");
                scriptBundle
               .Include("~/assets/vendors/bootstrap/dist/js/bootstrap.min.js");
                scriptBundle
               .Include("~/assets/vendors/metisMenu/dist/metisMenu.min.js");
                scriptBundle
               .Include("~/assets/vendors/jquery-slimscroll/jquery.slimscroll.min.js");
                scriptBundle
               .Include("~/assets/vendors/jquery-idletimer/dist/idle-timer.min.js");
                scriptBundle
               .Include("~/assets/vendors/toastr/toastr.min.js");
                scriptBundle
               .Include("~/assets/vendors/jquery-validation/dist/jquery.validate.min.js");
                scriptBundle
               .Include("~/assets/vendors/bootstrap-select/dist/js/bootstrap-select.min.js");
                scriptBundle
               .Include("~/assets/vendors/chart.js/dist/Chart.min.js");
                scriptBundle
          .Include("~/assets/vendors/jquery.easy-pie-chart/dist/jquery.easypiechart.min.js");
                scriptBundle
               .Include("~/assets/vendors/jvectormap/jquery-jvectormap-2.0.3.min.js");
                scriptBundle
               .Include("~/assets/vendors/jvectormap/jquery-jvectormap-world-mill-en.js");
                scriptBundle
               .Include("~/assets/js/app.min.js");
                scriptBundle
               .Include("~/assets/js/scripts/dashboard_ecommerce.js");

                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");
                // scriptBundle
                //.Include("");


                //Stles
                styleBundle
                .Include("~/assets/vendors/bootstrap/dist/css/bootstrap.min.css");

                styleBundle
               .Include("~/assets/vendors/font-awesome/css/font-awesome.min.css");
                styleBundle
               .Include("~/assets/vendors/line-awesome/css/line-awesome.min.css");
                styleBundle
               .Include("~/assets/vendors/themify-icons/css/themify-icons.css");
                styleBundle
               .Include("~/assets/vendors/animate.css/animate.min.css");
                styleBundle
               .Include("~/assets/vendors/toastr/toastr.min.css");
                styleBundle
               .Include("~/assets/vendors/bootstrap-select/dist/css/bootstrap-select.min.css");
                styleBundle
               .Include("~/assets/vendors/jvectormap/jquery-jvectormap-2.0.3.css");
                styleBundle
               .Include("~/assets/css/main.min.css");
                //  styleBundle
                // .Include("");
                //  styleBundle
                // .Include("");
                //  styleBundle
                //.Include("");
                //  styleBundle
                // .Include("");
                //  styleBundle
                // .Include("");
                //  styleBundle
                //.Include("");
                //  styleBundle
                // .Include("");
                //  styleBundle
                // .Include("");
                //  styleBundle
                //.Include("");
                //  styleBundle
                // .Include("");
                //  styleBundle
                // .Include("");






                bundles.Add(scriptBundle);
                bundles.Add(styleBundle);


                //OR this
                //Template bundling
                //styles

                //bundles.Add(new ScriptBundle("~/assets/vendors/bootstrap/dist/css/bootstrap.min.css").Include("", "", ""));
                //bundles.Add(new ScriptBundle("").Include("", "", ""));




                ////Scripts
                //bundles.Add(new StyleBundle("").Include("", "", ""));
                //bundles.Add(new StyleBundle("").Include("", "", ""));

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
            }
        }
   
}
