using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BJK_MR.Models.Containers;
using BJK_MR.Models.Objects;

namespace BJK_MR.Controllers
{
    public class ServiceController : Controller
    {
        public ActionResult Index([DefaultValue(0)] int id)
        {
            AdServiceContainer rtnVal = new AdServiceContainer();
            rtnVal.ExerciseNumber = (ExerciseNumber)id;

            // Since right now I am too lazy to try to map this integer to an Enum, just list some integer values to determine which value we're doing
            if (rtnVal.ExerciseNumber == ExerciseNumber.EXERCISE_2)
            {
                // A list of ads which appeared in the "Cover" position and also had at least 50% page coverage.
                rtnVal.Ads = rtnVal.Ads.Where(x => x.Position == "Cover" && x.NumPages >= 0.5M).ToList();
            }
            else if (rtnVal.ExerciseNumber == ExerciseNumber.EXERCISE_3)
            {
                // The top five ads by page coverage amount, distinct by brand (not sure what this means). Sort by page coverage amount (descending), then brand name alphabetically.
                rtnVal.Ads = rtnVal.Ads.OrderByDescending(x => x.NumPages).ToList();
            }
            else if (rtnVal.ExerciseNumber == ExerciseNumber.EXERCISE_4)
            {
                // The top five brands by page coverage amount. Keep in mind that a single brand may run multiple ads. Also sorted by page coverage amount (descending), then brand name alphabetically.
                var TopBrandsByCoverageAmount = rtnVal.Ads.GroupBy(x => x.Brand.BrandName).Select(lg =>
                                new
                                {
                                    BrandName = lg.Key,
                                    TotalCoverAgeAmount = lg.Sum(w => w.NumPages)
                                });

                List<BrandCoverageGrouping> groupedListing = new List<BrandCoverageGrouping>();

                foreach (var current in TopBrandsByCoverageAmount)
                {
                    BrandCoverageGrouping newListing = new BrandCoverageGrouping();
                    newListing.BrandName = current.BrandName;
                    newListing.TotalCoverage = current.TotalCoverAgeAmount;
                    groupedListing.Add(newListing);
                }

                groupedListing = groupedListing.OrderByDescending(x => x.TotalCoverage).Take(5).ToList();

                return View("ServiceConsumer_Exercise4", groupedListing);
            }

            return View("ServiceConsumer", rtnVal);
        }
    }
}