namespace ShapeLib;

public record struct Triangle(float A, float B, float C) : IShape
{
	public readonly float Area
	{
		get
		{
			float semiPerimeter = Perimeter / 2f;
			return MathF.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
		}
	}
	public readonly float Perimeter => A + B + C;

	/// <summary>Прямоуголен ли треугольник</summary>
	public readonly bool IsRightTriangle
	{
		get
		{
			float rightAngleInRads = float.DegreesToRadians(90); // чтобы не конвертировать 3 результата в радианах в градусы, конвертируем градусы в радианы
			float cDegrees = MathF.Asin(A / B);
			float bDegrees = MathF.Asin(A / C);
			float aDegrees = MathF.Asin(B / C);

			return (cDegrees == rightAngleInRads) ||
					(bDegrees == rightAngleInRads) ||
					(aDegrees == rightAngleInRads);
		}
	}
}
