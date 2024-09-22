using Xunit;
using Lab1;

namespace gp_tests
{
	public partial class Tests
	{
		[Fact]
		public static void GP_Constructor_ReturnDouble_IntegerValues() 
		{
			GP gp = new(4, 2);
			
			Assert.Equal(64, gp[4]);
		}

		[Fact]
		public static void GP_Constructor_ReturnDouble_Negative() 
		{
			GP gp = new(-4, 2);
			
			Assert.Equal(-64, gp[4]);
		}

        [Fact]
		public static void GP_Constructor_ReturnDouble() 
		{
			GP gp = new(0.1, 2.11);
			
			Assert.Equal(0.1*2.11*2.11*2.11, gp[3]);
		}

        [Fact]
		public static void GP_Constructor_ReturnDouble_NegativeRatio() 
		{
			GP gp = new(10, -0.2);
			
			Assert.Equal(10*-0.2*-0.2*-0.2, gp[3]);
		}

        [Fact]
		public static void GP_Sum_ReturnDouble() 
		{
			GP gp = new(2, 5);
			
			Assert.Equal(4882812, gp.Sum(10));
		}

        [Fact]
		public static void GP_Sum_ReturnDouble_1() 
		{
			GP gp = new(2, 0.5);
			
			Assert.Equal(4, gp.Sum(100));
		}

        [Fact]
		public static void GP_Sum_ReturnDouble_2() 
		{
			GP gp = new(1, 1/5);
			
			Assert.Equal(1 + 1/4, gp.Sum(100));
		}
	}
}
