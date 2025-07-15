using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Grafic
{
    // Структура для зберігання точок
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Grafic
    {
        private List<Point> points;
        private Func<double, double> function; // Делегат для функції
        private double minX;
        private double maxX;
        private double step;
        public double dx;
        public double dy;
        public double max_X;
        public double max_Y;
        public static Bitmap bitmap;

        // Конструктор з передачею функції
        public Grafic(Func<double, double> func)
        {
            points = new List<Point>();
            function = func;
        }

        // Додавання точок у список на основі функції
        public void AddPoint()
        {
            points.Clear(); // Очистити попередні точки
            for (double x = minX; x <= maxX; x += step)
            {
                double y = function(x);
                points.Add(new Point(x, y));
            }
        }

        // Малювання декартової системи координат
        public void DecardSystem()
        {
            using (Graphics device = Graphics.FromImage(bitmap))
            {
                device.Clear(Color.White);
                Pen pen = new Pen(Color.Black);
                // Вісь X
                device.DrawLine(pen, 0, bitmap.Height / 2, bitmap.Width, bitmap.Height / 2);
                // Вісь Y
                device.DrawLine(pen, bitmap.Width / 2, 0, bitmap.Width / 2, bitmap.Height);
            }
        }

        // Пошук максимального абсолютного значення Y
        private double SearchMaxY()
        {
            if (points.Count == 0) return 1.0;

            double maxAbsY = Math.Abs(points[0].Y);
            foreach (var point in points)
            {
                double currentAbsY = Math.Abs(point.Y);
                if (currentAbsY > maxAbsY)
                    maxAbsY = currentAbsY;
            }
            return maxAbsY;
        }

        // Ініціалізація параметрів графіка
        public void Initialize(double minx, double maxx, double stepSize)
        {
            minX = minx;
            maxX = maxx;
            step = stepSize;

            AddPoint(); // Генеруємо точки

            max_X = Math.Max(Math.Abs(minX), Math.Abs(maxX));
            dx = bitmap.Width / 2 / (max_X + 1); // Масштаб по X

            max_Y = SearchMaxY(); // Автоматичний розрахунок
            dy = bitmap.Height / 2 / (max_Y + 0.1); // Масштаб по Y (+0.1 для відступу)
        }

        // Малювання графіка
        public void Draw()
        {
            using (Graphics device = Graphics.FromImage(bitmap))
            using (Pen pen = new Pen(Color.Red))
            {
                // З'єднуємо сусідні точки
                for (int i = 0; i < points.Count - 1; i++)
                {
                    device.DrawLine(pen,
                        (float)(bitmap.Width / 2 + points[i].X * dx),
                        (float)(bitmap.Height / 2 - points[i].Y * dy),
                        (float)(bitmap.Width / 2 + points[i + 1].X * dx),
                        (float)(bitmap.Height / 2 - points[i + 1].Y * dy));
                }
            }
        }
    }
}
