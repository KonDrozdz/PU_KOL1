using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public HistoryService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PagedResultDTO<HistoryResponseDTO>> GetHistoryPagedAsync(int pageNumber, int pageSize)
        {
            var query = _context.History.OrderByDescending(h => h.Data);

            var totalItems = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResultDTO<HistoryResponseDTO>
            {
                Items = _mapper.Map<List<HistoryResponseDTO>>(items),
                TotalItemsCount = totalItems,
                ItemsFrom = (pageNumber - 1) * pageSize + 1,
                ItemsTo = (pageNumber - 1) * pageSize + items.Count,
                TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
            };
        }
    }
}