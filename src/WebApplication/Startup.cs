// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication
{
  public class Startup
  {
    private string extensionsPath;

    public Startup(IHostingEnvironment hostingEnvironment, IConfiguration configuration)
    {
      this.extensionsPath = hostingEnvironment.ContentRootPath + configuration["Extensions:Path"];
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddExtCore(this.extensionsPath);
    }

    public void Configure(IApplicationBuilder applicationBuilder)
    {
      applicationBuilder.UseExtCore();
    }
  }
}