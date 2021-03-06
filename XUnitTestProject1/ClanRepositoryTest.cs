﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Moq;
using WebApplication2.Models;
using WebApplication2.Repositories;
using Xunit;

namespace XUnitTestProject1
{
    public class ClanRepositoryTest
    {
        protected ClanRepository RepositoryUnderTest { get; }
        protected Clan[] Clans { get; }

        public ClanRepositoryTest()
        {
            Clans = new Clan[]
            {
                new Clan { Name = "My clan" },
                new Clan { Name = "Your clan" },
                new Clan { Name = "His clan" }
            };
            RepositoryUnderTest = new ClanRepository(Clans);
        }

        public class ReadAllAsync : ClanRepositoryTest
        {
            [Fact]
            public async Task Should_return_all_clans()
            {
                // Act
                var result = await RepositoryUnderTest.ReadAllAsync();
                Console.WriteLine("Repo Test Running");
                // Assert
                Assert.Collection(result,
                    clan => Assert.Same(Clans[0], clan),
                    clan => Assert.Same(Clans[1], clan),
                    clan => Assert.Same(Clans[2], clan)
                );
            }
        }

        public class ReadOneAsync : ClanRepositoryTest
        {
            [Fact]
            public async Task Should_return_the_expected_clan()
            {
                // Arrange
                var expectedClan = Clans[1];
                var expectedClanName = expectedClan.Name;

                // Act
                var result = await RepositoryUnderTest.ReadOneAsync(expectedClanName);

                // Assert
                Assert.Same(expectedClan, result);
            }

            [Fact]
            public async Task Should_return_null_if_the_clan_does_not_exist()
            {
                // Arrange
                var unexistingClanName = "Unexisting clan";

                // Act
                var result = await RepositoryUnderTest.ReadOneAsync(unexistingClanName);

                // Assert
                Assert.Null(result);
            }
        }

        public class CreateAsync : ClanRepositoryTest
        {
            [Fact]
            public async Task Should_throw_a_NotSupportedException()
            {
                // Arrange, Act, Assert
                var exception = await Assert.ThrowsAsync<NotSupportedException>(() => RepositoryUnderTest.CreateAsync(null));
            }
        }

        public class UpdateAsync : ClanRepositoryTest
        {
            [Fact]
            public async Task Should_throw_a_NotSupportedException()
            {
                // Arrange, Act, Assert
                var exception = await Assert.ThrowsAsync<NotSupportedException>(() => RepositoryUnderTest.UpdateAsync(null));
            }
        }

        public class DeleteAsync : ClanRepositoryTest
        {
            [Fact]
            public async Task Should_throw_a_NotSupportedException()
            {
                // Arrange, Act, Assert
                var exception = await Assert.ThrowsAsync<NotSupportedException>(() => RepositoryUnderTest.DeleteAsync(null));
            }
        }
    }
}
