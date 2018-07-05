﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class ClanRepository : IClanRepository<Clan>
    {
        private readonly List<Clan> _clans;
        public ClanRepository(IEnumerable<Clan> clans)
        {
            if (clans == null) { throw new ArgumentNullException(nameof(clans)); }
            _clans = new List<Clan>(clans);
        }
        public Task<Clan> CreateAsync(Clan clan)
        {
            throw new NotSupportedException();
        }

        public Task<Clan> DeleteAsync(string clanName)
        {
            throw new NotSupportedException();
        }

        public Task<IEnumerable<Clan>> ReadAllAsync()
        {
            return Task.FromResult(_clans.AsEnumerable());
        }

        public Task<Clan> ReadOneAsync(string clanName)
        {
            var clan = _clans.FirstOrDefault(c => c.Name == clanName);
            return Task.FromResult(clan);
        }

        public Task<Clan> UpdateAsync(Clan clan)
        {
            throw new NotSupportedException();
        }
    }
}
