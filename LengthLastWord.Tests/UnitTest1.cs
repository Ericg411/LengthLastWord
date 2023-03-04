namespace LengthLastWord.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        string s = "Hello World";
        var result = _test.LengthOfLastWord(s);
        int answer = 5;
        Assert.AreEqual(answer, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        string s = "   fly me   to   the moon  ";
        var result = _test.LengthOfLastWord(s);
        int answer = 4;
        Assert.AreEqual(answer, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        string s = "luffy is still joyboy";
        var result = _test.LengthOfLastWord(s);
        int answer = 6;
        Assert.AreEqual(answer, result);
    }
}