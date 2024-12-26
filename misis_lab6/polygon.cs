using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misis_lab6
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

    public class Polygon
    {
        public List<Point> Vertices { get; set; }

        public Polygon(List<Point> vertices)
        {
            Vertices = vertices;
        }

        public bool IsConvex()
        {
            int n = Vertices.Count;
            if (n < 3) return false;

            bool isPositive = false;

            for (int i = 0; i < n; i++)
            {
                double crossProduct = CrossProduct(Vertices[i], Vertices[(i + 1) % n], Vertices[(i + 2) % n]);
                if (i == 0)
                {
                    isPositive = crossProduct > 0;
                }
                else if (crossProduct > 0 != isPositive)
                {
                    return false;
                }
            }

            return true;
        }

        public bool AreCollinear()
        {
            int n = Vertices.Count;
            if (n < 3) return false; // Меньше 3 точек не может быть коллинеарным

            for (int i = 0; i < n; i++)
            {
                if (CrossProduct(Vertices[i], Vertices[(i + 1) % n], Vertices[(i + 2) % n]) != 0)
                {
                    return false; // Если хотя бы одна тройка не коллинеарна, возвращаем false
                }
            }

            return true; // Все точки коллинеарны
        }

        private double CrossProduct(Point A, Point B, Point C)
        {
            return (B.X - A.X) * (C.Y - A.Y) - (B.Y - A.Y) * (C.X - A.X);
        }
    public double CalculateArea()
        {
            double area = 0;
            int n = Vertices.Count;

            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;
                area += Vertices[i].X * Vertices[j].Y;
                area -= Vertices[j].X * Vertices[i].Y;
            }

            return Math.Abs(area) / 2.0;
        }
    }
}
