﻿using DotVVM.Framework.Configuration;

namespace DotVVM.Samples.BasicSamples.Api.AspNetCore
{
    public class DotvvmStartup : IDotvvmStartup
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Generator", "", "Views/Generator.dothtml");
        }
    }
}
