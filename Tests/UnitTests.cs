namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}


namespace GithubActionsLab
{
    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void Sub_Valid_Patino_Ibrahim()
        {
            Assert.AreEqual(1, Program.Sub("3", "2"));
            Assert.AreEqual(4, Program.Sub("7", "3"));
            Assert.AreEqual(5, Program.Sub("10", "5"));
        }

        [TestMethod]
        public void Sub_Invalid_Patino_Ibrahim()
        {
            Assert.ThrowsException<FormatException>(() => Program.Sub("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Sub("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Sub("a", "a"));
        }

        [TestMethod]
        public void Sub_Null_Patino_Ibrahim()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Sub("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Sub(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Sub(null, null));
        }
    }
}

namespace GithubActionsLab
{
    [TestClass]
    public class Multiplication
    {
        [TestMethod]
        public void Mul_Valid_Patino_Ibrahim()
        {
            Assert.AreEqual(6, Program.Mul("3", "2"));
            Assert.AreEqual(21, Program.Mul("7", "3"));
            Assert.AreEqual(50, Program.Mul("10", "5"));
        }

        [TestMethod]
        public void Mul_Invalid_Patino_Ibrahim()
        {
            Assert.ThrowsException<FormatException>(() => Program.Mul("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Mul("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Mul("a", "a"));
        }

        [TestMethod]
        public void Mul_Null_Patino_Ibrahim()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Mul("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Mul(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Mul(null, null));
        }
    }
}

namespace GithubActionsLab
{
    [TestClass]
    public class Division
    {
        [TestMethod]
        public void Div_Valid_Patino_Ibrahim()
        {
            Assert.AreEqual(2, Program.Div("6", "3"));
            Assert.AreEqual(2, Program.Div("10", "5"));
            Assert.AreEqual(3, Program.Div("21", "7"));
        }

        [TestMethod]
        public void Div_Invalid_Patino_Ibrahim()
        {
            Assert.ThrowsException<FormatException>(() => Program.Div("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Div("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Div("a", "a"));
        }

        [TestMethod]
        public void Div_Null_Patino_Ibrahim()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Div("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Div(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Div(null, null));
        }
    }
}


namespace GithubActionsLab
{
    [TestClass]
    public class Power
    {
        [TestMethod]
        public void Power_Valid_Patino_Ibrahim()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(25, Program.Power("5", "2"));
        }

        [TestMethod]
        public void Power_Invalid_Patino_Ibrahim()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
            Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
        }

        [TestMethod]
        public void Power_Null_Patino_Ibrahim()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
