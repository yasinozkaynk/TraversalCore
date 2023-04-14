using AutoMapper;
using Entity.Concrete;
using Entity.DTOs.ContactDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //CreateMap<AnnouncementAddDto, Announcement>();
            //CreateMap<Announcement, AnnouncementAddDto>();

            //CreateMap<AppUserRegisterDTOs, AppUser>();
            //CreateMap<AppUser, AppUserRegisterDTOs>();

            //CreateMap<AppUserLoginDTOs, AppUser>();
            //CreateMap<AppUser, AppUserLoginDTOs>();

            //CreateMap<AnnouncementListDto, Announcement>();
            //CreateMap<Announcement, AnnouncementListDto>();

            //CreateMap<AnnouncementUpdateDto, Announcement>();
            //CreateMap<Announcement, AnnouncementUpdateDto>();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();
        }
    }
}
