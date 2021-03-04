using Microsoft.Extensions.DependencyInjection;
using GL.FC.Data.Database;
using GL.FC.Services;

namespace GL.FC.Web
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            #region Dependency Injection for Services 
            services.AddScoped(typeof(IPostService), typeof(PostService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IPostImagesService), typeof(PostImagesService));
            services.AddScoped(typeof(ILikesService), typeof(LikesService));
            services.AddScoped(typeof(ICommentService), typeof(CommentService));
            services.AddScoped(typeof(IUserHealthService), typeof(UserHealthService));
            services.AddScoped(typeof(IUserProfileService), typeof(UserProfileService));

            #endregion

            #region Dependency Injection for Repository

            services.AddScoped(typeof(IPostRepository), typeof(PostRepository));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddScoped(typeof(IPostImagesRepository), typeof(PostImagesRepository));
            services.AddScoped(typeof(ILikesRepository), typeof(LikesRepository));
            services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
            services.AddScoped(typeof(IUserHealthRepository), typeof(UserHealthRepository));
            services.AddScoped(typeof(IUserProfileRepository), typeof(UserProfileRepository));

            #endregion
            return services;
        }
    }
}
