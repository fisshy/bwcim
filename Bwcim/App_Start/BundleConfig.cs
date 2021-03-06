﻿using System;
using System.Web.Optimization;

namespace Bwcim
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                            "~/Scripts/libs/*.js",
                            "~/Scripts/*.js"
                        ));

            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                            "~/Content/xeditable.css",
                            "~/Content/loading-bar.css",
                            "~/Content/bootstrap.css",
                            "~/Content/site.css"
                        ));
        }
    }
}
