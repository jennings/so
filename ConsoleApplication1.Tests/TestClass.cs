using System.Threading.Tasks;
using Xunit;

namespace ConsoleApplication1
{
    public class TestClass
    {
        [Fact]
        public async Task Regular_BCL_type_does_appear()
        {
            var response = Service.String();
            Assert.True(false);
        }

        [Fact]
        public async Task Task_BCL_type_does_appear()
        {
            var response = await Service.StringAsync();
            Assert.True(false);
        }

        [Fact]
        public void Regular_custom_type_does_not_appear()
        {
            var response = Service.CustomType();
            Assert.True(false);
        }

        [Fact]
        public async Task Task_custom_type_does_not_appear()
        {
            var response = await Service.CustomTypeAsync();
            Assert.True(false);
        }
    }
}
