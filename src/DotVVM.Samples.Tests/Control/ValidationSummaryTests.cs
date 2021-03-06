﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Testing.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotVVM.Samples.Tests.Control
{
    [TestClass]
    public class ValidationSummaryTests : AppSeleniumTest
    {

        [TestMethod]
        public void Control_ValidationSummary_RecursiveValidationSummary()
        {
            RunInAllBrowsers(browser =>
            {
                browser.NavigateToUrl(SamplesRouteUrls.ControlSamples_ValidationSummary_RecursiveValidationSummary);

                browser.ElementAt("input[type=button]", 0).Click().Wait();

                browser.ElementAt("ul", 0).FindElements("li").ThrowIfDifferentCountThan(2);
                browser.First("#result").CheckIfInnerTextEquals("false");
                
                browser.ElementAt("input[type=button]", 1).Click().Wait();
                browser.ElementAt("ul", 1).FindElements("li").ThrowIfDifferentCountThan(1);
                browser.First("#result").CheckIfInnerTextEquals("false");
            });
        }

    }
}