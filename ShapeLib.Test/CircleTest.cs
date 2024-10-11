namespace ShapeLib.Test;

public class CircleTest
{
    [Fact]
    public void Test()
    {
		var circle = new Circle(10f);

		Assert.Equal(314.159265f, circle.Area);

		Assert.Equal(62.8318558f, circle.Perimeter, 5);

		Assert.Equal(20f, circle.Diameter);
    }
}
