using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection;
using System.Reflection.Metadata;
using ShoppingCartPresentations;
using AssemblyReference = ShoppingCartPresentations.AssemblyReference;
using ShoppingCartApp.ExtensionsMethod;
namespace ShoppingCartApp.ExtensionsMethod
{
    public static class RegisterControllerExtensions
    {
        public static IServiceCollection RegisterController(this IServiceCollection services)
        {
            services.AddControllers()
                .AddApplicationPart(AssemblyReference.Assembly)
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            return services;
        }
    }
}
