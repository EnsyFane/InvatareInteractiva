using AutoMapper;
using Common.DTOs;
using Common.Entities;
using DataPersistence;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    #region interface
    public interface IStickyNoteService
    {
        Task<List<StickyNoteDto>> GetStickyNotes(int noChapter);
        Task<StickyNoteDto>AddStickyNote(StickyNoteDto stickyNote);
    }
    #endregion
    public class StickyNoteService : IStickyNoteService
    {
        private readonly DataContext _context;
        private readonly IMapper _map;

        public StickyNoteService(DataContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public async Task<StickyNoteDto> AddStickyNote(StickyNoteDto stickyNoteDto)
        {
            var stickyNote = _map.Map<StickyNote>(stickyNoteDto);

            await _context.StickyNotes.AddAsync(stickyNote);
            await _context.SaveChangesAsync();

            return _map.Map<StickyNoteDto>(stickyNote);
        }

        public async Task<List<StickyNoteDto>> GetStickyNotes(int noChapter)
        {
            var response = _map.Map<List<StickyNoteDto>>(await _context.StickyNotes.Where(s=>s.NoChapter==noChapter).ToListAsync());
            return response;
        }
    }
}
