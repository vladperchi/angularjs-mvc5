﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSMVC5.Startup))]
namespace AngularJSMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
