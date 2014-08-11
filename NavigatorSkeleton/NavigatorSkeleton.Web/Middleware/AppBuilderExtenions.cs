using Owin;

namespace NavigatorSkeleton.Web.Middleware
{
    public static class AppBuilderExtenions
    {
        public static void UseSkeltonMiddleware(this IAppBuilder app)
        {
            app.Use<SkeltonMiddleware>();
        }
    }
}