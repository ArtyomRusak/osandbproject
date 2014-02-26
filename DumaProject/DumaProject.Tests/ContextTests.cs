using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
