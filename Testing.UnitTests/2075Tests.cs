using Xunit;


namespace Testing1.UnitTests
{
	public class Problem2075Tests
	{
		[Fact]
		public void Test1()
		{
			string encodedText = "ch   ie   pr";
			int rows = 3;
			2075Solution solution = new 2075Solution();
			string result = solution.DecodeCiphertext(encodedText, rows);
			Assert.Equal("cipher", result);
		}
		[Fact]
		public void Test2()
		{
			string encodedText = "iveo    eed   l te   olc";
			int rows = 4;
			2075Solution solution = new 2075Solution();
			string result = solution.DecodeCiphertext(encodedText, rows);
			Assert.Equal("i love leetcode", result);

		}
		[Fact]
		public void Test3()
		{
			string encodedText = "coding";
			int rows = 1;
			2075Solution solution = new 2075Solution();
			string result = solution.DecodeCiphertext(encodedText, rows);
			Assert.Equal("coding", result);
		}
		[Fact]
		public void Test4()
		{
			string encodedText = "bzqlagy                gxwd tx                uvqinyi                jjmdhhb                kjcm la                rxwcqnf                ycuxczg                wwnvnqz                bsdqkqr                ushfkzu                heny dw                qvbuagj                blawlga                wzhgxxg                tzb thk                shtxjof                feguqx";
			int rows = 17;
			2075Solution solution = new 2075Solution();
			string result = solution.DecodeCiphertext(encodedText, rows);
			Assert.Equal("bgujkrywbuhqbwtsfzxvjjxcwssevlzzheqwqmcwundhnbahbtgldidmcxvqfyuwg xua nh qcnkk alxtjqgtyhlnzqqzdggxhoxyxibafgzruwjagkf", result);
		}


	}