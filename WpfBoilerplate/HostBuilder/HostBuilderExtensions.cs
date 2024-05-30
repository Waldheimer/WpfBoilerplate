﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WpfBoilerplate.Manager;

namespace WpfBoilerplate.HostBuilder
{
    public static class HostBuilderExtensions
    {
        //  *****   Registration of all ViewModels for DI   *****************************
        public static IHostBuilder RegisterViewModels(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {

            });
            return hostBuilder;
        }
        //  *****   Registration of all Views/Components for DI   ***********************
        public static IHostBuilder RegisterViews(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {

            });
            return hostBuilder;
        }
        //  *****   Registration of all ManagerClasses for DI   *************************
        public static IHostBuilder RegisterManagers(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {
                services.AddSingleton<NavigationManager>();
            });
            return hostBuilder;
        }
        //  *****   Registration of all ServiceClasses for DI   *************************
        public static IHostBuilder RegisterServices(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {
                //  services.AddSingleton<NavigationService<SomeViewModel>>();
            });
            return hostBuilder;
        }
        //  *****   Registration of Factory Functions for DI   **************************
        public static IHostBuilder RegisterFactoryFunctions(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {
                //  services.AddSingleton<Func<SomeViewModel>>(s => () => s.GetRequiredService<SomeViewModel>());
            });
            return hostBuilder;
        }
    }
}
