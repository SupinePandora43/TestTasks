namespace ShapeLib.Test;

public class TriangleTest
{
	[Fact]
	public void Test()
	{
		var triangle = new Triangle(10, 10, 14.1421356f);

		Assert.Equal(50, triangle.Area);
		Assert.Equal(34.1421356f, triangle.Perimeter);
		Assert.True(triangle.IsRightTriangle);
	}

	[Theory]
	[InlineData(10f, 10f, 14.1421356f)]
	public void TestIsRightTriangle(float A, float B, float C)
	{
		var triangle = new Triangle(A, B, C);

		Assert.True(triangle.IsRightTriangle);
	}
}
