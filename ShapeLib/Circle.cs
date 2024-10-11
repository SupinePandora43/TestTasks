namespace ShapeLib;

public record struct Circle(float Radius) : IShape
{
	public readonly float Area => MathF.PI * MathF.Pow(Radius, 2);
	public readonly float Perimeter => MathF.PI * 2f * Radius;
	public readonly float Diameter => Radius * 2;
}
