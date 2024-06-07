using System;
using System.Collections.Generic;

public class BowyerWatsonAlgorithm
{
	public class Point
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
	}

	public class Triangle
	{
		public Point[] Vertices { get; private set; }

		public Triangle(Point p1, Point p2, Point p3)
		{
			Vertices = new Point[3];
			Vertices[0] = p1;
			Vertices[1] = p2;
			Vertices[2] = p3;
		}

		public bool Contains(Point p)
		{
			double areaOrig = Math.Abs(0.5 * (Vertices[1].X - Vertices[0].X) * (Vertices[2].Y - Vertices[0].Y) -
									   0.5 * (Vertices[2].X - Vertices[0].X) * (Vertices[1].Y - Vertices[0].Y));

			double area1 = Math.Abs(0.5 * (Vertices[0].X - p.X) * (Vertices[1].Y - p.Y) -
									0.5 * (Vertices[1].X - p.X) * (Vertices[0].Y - p.Y));

			double area2 = Math.Abs(0.5 * (Vertices[1].X - p.X) * (Vertices[2].Y - p.Y) -
									0.5 * (Vertices[2].X - p.X) * (Vertices[1].Y - p.Y));

			double area3 = Math.Abs(0.5 * (Vertices[2].X - p.X) * (Vertices[0].Y - p.Y) -
									0.5 * (Vertices[0].X - p.X) * (Vertices[2].Y - p.Y));

			double sumOfAreas = area1 + area2 + area3;

			return Math.Abs(areaOrig - sumOfAreas) < 0.0001; // tolerance for floating-point comparison
		}
	}

	public static List<Triangle> BowyerWatson(List<Point> pointList)
	{
		List<Triangle> triangulation = new List<Triangle>();

		// Add super-triangle to triangulation (large enough to contain all the points)
		double minX = double.MaxValue, minY = double.MaxValue, maxX = double.MinValue, maxY = double.MinValue;
		foreach (Point p in pointList)
		{
			minX = Math.Min(minX, p.X);
			minY = Math.Min(minY, p.Y);
			maxX = Math.Max(maxX, p.X);
			maxY = Math.Max(maxY, p.Y);
		}
		double dx = maxX - minX;
		double dy = maxY - minY;
		double deltaMax = Math.Max(dx, dy);
		Point p1 = new Point(minX - 2 * deltaMax, minY - deltaMax);
		Point p2 = new Point(minX + 2 * deltaMax, minY - deltaMax);
		Point p3 = new Point(minX + dx / 2, maxY + 2 * deltaMax);
		triangulation.Add(new Triangle(p1, p2, p3));

		foreach (Point point in pointList)
		{
			HashSet<Triangle> badTriangles = new HashSet<Triangle>();
			foreach (Triangle triangle in triangulation)
			{
				if (triangle.Contains(point))
				{
					badTriangles.Add(triangle);
				}
			}

			HashSet<Point> polygon = new HashSet<Point>();
			foreach (Triangle triangle in badTriangles)
			{
				foreach (Point vertex in triangle.Vertices)
				{
					bool sharedEdge = false;
					foreach (Triangle otherTriangle in badTriangles)
					{
						if (otherTriangle != triangle && otherTriangle.Contains(vertex))
						{
							sharedEdge = true;
							break;
						}
					}
					if (!sharedEdge)
					{
						polygon.Add(vertex);
					}
				}
				triangulation.Remove(triangle);
			}

			foreach (Point vertex in polygon)
			{
				triangulation.Add(new Triangle(vertex, point, polygon.GetEnumerator().MoveNext() ? polygon.GetEnumerator().Current : polygon.GetEnumerator().MoveNext() ? polygon.GetEnumerator().Current : polygon.GetEnumerator().Current));
			}
		}

		List<Triangle> toRemove = new List<Triangle>();
		foreach (Triangle triangle in triangulation)
		{
			foreach (Point vertex in triangle.Vertices)
			{
				if (vertex == p1 || vertex == p2 || vertex == p3)
				{
					toRemove.Add(triangle);
					break;
				}
			}
		}

		foreach (Triangle triangle in toRemove)
		{
			triangulation.Remove(triangle);
		}

		return triangulation;
	}
}

class Program
{
	static void Main(string[] args)
	{
		List<BowyerWatsonAlgorithm.Point> points = new List<BowyerWatsonAlgorithm.Point>()
		{
			new BowyerWatsonAlgorithm.Point(0, 0),
			new BowyerWatsonAlgorithm.Point(1, 0),
			new BowyerWatsonAlgorithm.Point(0.5, 1),
			new BowyerWatsonAlgorithm.Point(0.5, 0.5),
			new BowyerWatsonAlgorithm.Point(0.2, 0.3)
		};

		List<BowyerWatsonAlgorithm.Triangle> triangulation = BowyerWatsonAlgorithm.BowyerWatson(points);

		foreach (BowyerWatsonAlgorithm.Triangle triangle in triangulation)
		{
			Console.WriteLine("Triangle vertices:");
			foreach (BowyerWatsonAlgorithm.Point vertex in triangle.Vertices)
			{
				Console.WriteLine($"({vertex.X}, {vertex.Y})");
			}
			Console.WriteLine();
		}
	}
}