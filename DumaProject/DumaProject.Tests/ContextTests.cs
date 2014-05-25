using System;
using System.Linq;
using DumaProject.Core.Entities;
using DumaProject.EFData.EFContext;
using FluentAssertions;
using NUnit.Framework;

namespace DumaProject.Tests
{
    [TestFixture]
    public class ContextTests
    {
        [Test]
        public void ShouldCreateContext()
        {
            var context = new DumaContext("DumaTestConnection");
            var members = context.Members.ToList();

            context.Should().NotBeNull();
            context.Dispose();
        }

        [Test]
        public void Do()
        {
            var context = new DumaContext("DumaTestConnection");
            context.Commissions.Add(new Commission {Name = "fw", PresidentId = 1, ProfileCommissionId = 1});

            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

            }
            finally
            {
                context.Dispose();
            }
        }
    }
}
