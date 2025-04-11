using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App
{
    internal class Particle
    {
        public RectangleF body;

        public string type;

        public PointF vel;

        public Color color;

        Random rand = new Random();

        public Particle(PointF pos, string _type, Color _color)
        {
            float sz;
            type = _type;
            color = _color;

            switch (type)
            {
                case "rain":
                    body = new RectangleF(pos, new SizeF(10, rand.Next(20,40)));

                    vel = new PointF(0, rand.Next(2, 4));

                    break;

                case "cloud":
                    sz = rand.Next(60, 120);

                    body = new RectangleF(pos, new SizeF(sz, sz));

                    vel = new PointF(rand.Next(1, 3), 0);

                    break;

                case "snow":
                    sz = rand.Next(10, 20);

                    body = new RectangleF(pos, new SizeF(sz, sz));

                    vel = new PointF(rand.Next(-1, 1), rand.Next(1,3));

                    break;

            }
        }
    }
}
