using WebApplication1.Pages;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController hc=new HomeController();
            hc.Testing();
           var s= hc.ViewData["vd"];
            Assert.Equal(1, s);
        }
    }
}