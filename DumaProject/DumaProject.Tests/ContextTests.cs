using System.Linq;
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
