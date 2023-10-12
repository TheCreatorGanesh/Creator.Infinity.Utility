global using NUnit.Framework;

public class TestObject
{
    public TestObject(string name = "NO_NAME_PROVIDED")
    {
        this.Name = name;
    }

    public string Name { get; set; }
}