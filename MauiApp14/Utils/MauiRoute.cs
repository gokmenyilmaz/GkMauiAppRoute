using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp14.Utils
{
    public static class MauiRoute
    {
        public static IServiceCollection GkAddTransientWithShellRoute<TPage, TViewModel>(
            this IServiceCollection services,
            string route
        )
            where TPage : ContentPage
            where TViewModel : class
        {
            services.AddTransient<TViewModel>();
            services.AddTransient<TPage>(sp =>
            {
                var page = ActivatorUtilities.CreateInstance<TPage>(sp);
                if (page is ContentPage contentPage)
                {
                    contentPage.BindingContext = sp.GetRequiredService<TViewModel>();
                }
                return page;
            });

            Routing.RegisterRoute(route, typeof(TPage));
            return services;
        }
    }
}
