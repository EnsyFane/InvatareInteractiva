using AutoMapper;
using Common.DTOs;
using Common.Entities;
using Common.ViewModels;

namespace Common.MappingProfiles
{
    public class StickyNoteProfile : Profile
    {
        public StickyNoteProfile()
        {
            CreateMap<StickyNote, StickyNoteDto>().ReverseMap();
            CreateMap<StickyNoteDto, StickyNoteViewModel>().ReverseMap();
        }
    }
}
