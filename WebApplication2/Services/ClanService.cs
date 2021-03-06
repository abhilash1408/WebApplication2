﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Services
{
    public class ClanService : IClanService<Clan>
    {
        private IClanRepository<Clan> _clanRepository;

public ClanService(IClanRepository<Clan> clanRepository)
{
    _clanRepository = clanRepository ?? throw new ArgumentNullException(nameof(clanRepository));
}
        public Task<Clan> CreateAsync(Clan clan)
        {
            throw new NotSupportedException();
        }

        public Task<Clan> DeleteAsync(string clanName)
        {
            throw new NotSupportedException();
        }

        public async Task<bool> IsClanExistsAsync(string clanName)
        {
            var clan = await _clanRepository.ReadOneAsync(clanName);
            return clan != null;
        }

        public Task<IEnumerable<Clan>> ReadAllAsync()
        {
            return _clanRepository.ReadAllAsync();
        }

        public Task<Clan> ReadOneAsync(string clanName)
        {
            return _clanRepository.ReadOneAsync(clanName);
        }

        public Task<Clan> UpdateAsync(Clan clan)
        {
            throw new NotSupportedException();
        }
    }
}
