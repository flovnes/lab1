using Xunit;
using Lab1;

namespace gp_tests
{
	public partial class Tests
	{
		[Fact]
		public static void Student_FilterSummer_ReturnStudents() 
		{
			Lab1.GP gp = new(4, 2);
			
			Assert.Equal(64, gp[4]);
		}
	}
}
