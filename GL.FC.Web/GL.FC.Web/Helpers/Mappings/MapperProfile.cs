using AutoMapper;
using GL.FC.Data;
using GL.FC.Shared;

namespace GL.FC.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserProfileEntity, UserProfileModel>().ReverseMap();

            CreateMap<UserHealthEntity, UserHealthModel>().ReverseMap();

            CreateMap<CategoryEntity, CategoryModel>().ReverseMap();

            CreateMap<PostEntity, PostModel>().ReverseMap();

            CreateMap<PostImagesEntity, PostImagesModel>().ReverseMap();

            CreateMap<LikesEntity, LikesModel>().ReverseMap();

            CreateMap<CommentEntity, CommentModel>().ReverseMap();
        }
    }
}
