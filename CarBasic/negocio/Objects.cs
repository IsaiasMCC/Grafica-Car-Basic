using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Graphics.OpenGL;
namespace CarBasic.negocio
{
    class Objects: IObject
    {
        private float width;
        private float height;
        private float depth;
        private float size;
        private Point center;
        Car car;
        Pared pared;
        Soporte soporte;

        public Objects(Point center, float width, float height, float depth, float size)
        {
            this.center = center;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.size = size;

            car = new Car(center, width, height, depth, size);
            pared = new Pared(center, width, height, depth, size);
            soporte = new Soporte(center, width, height, depth, size);
        }

        public void draw()
        {
            //GL.LoadIdentity();
           //GL.Rotate(0.5f, 0, 1, 0);
            pared.draw();
            soporte.draw();
            car.draw();
        }
    }
}
