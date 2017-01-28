using System.Threading.Tasks;
using Xunit;

namespace ConsoleApplication1
{
    public class TestClass
    {
        [Fact]
        public async Task BCL_type_does_appear()
        {
            var response = await Service.String();
            Assert.True(false);
        }

        [Fact]
        public async Task Custom_type_does_not_appear()
        {
            var response = await Service.CustomType();
            Assert.True(false);
        }
    }
}
