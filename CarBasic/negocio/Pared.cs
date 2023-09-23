using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Graphics.OpenGL;
namespace CarBasic.negocio
{
    class Pared: IObject
    {
        private float width;
        private float height;
        private float depth;
        private float size;
        private Point center;

        public Pared(Point center, float width, float height, float depth, float size)
        {
            this.center = center;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.size = size;
        }

        public void draw()
        {
            //GL.LoadIdentity();
            //GL.Rotate(0.5f, 1, 1, 0);
            PrimitiveType primitiveType = PrimitiveType.Polygon;
            front(primitiveType);
            back(primitiveType);
            left(primitiveType);
            right(primitiveType);
            top(primitiveType);
            botton(primitiveType);
        }

        public void front(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(center.x - (width / 2) * size, center.y - (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y + (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y + (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z + (depth / 2) * size);
            GL.End();
        }
        public void back(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(center.x - (width / 2) * size, center.y - (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y + (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y + (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z - (depth / 2) * size);
            GL.End();
        }
        public void left(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(center.x - (width / 2) * size, center.y - (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y + (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y + (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y - (height / 2) * size, center.z - (depth / 2) * size);
            GL.End();
        }
        public void right(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(center.x + (width / 2) * size, center.y + (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y + (height / 2) * size, center.z - (depth / 2) * size);
            GL.End();
        }
        public void top(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(center.x - (width / 2) * size, center.y + (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y + (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y + (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y + (height / 2) * size, center.z - (depth / 2) * size);
            
            GL.End();
        }
        public void botton(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(center.x - (width / 2) * size, center.y - (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z + (depth / 2) * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z - (depth / 2) * size);
            GL.Vertex3(center.x - (width / 2) * size, center.y - (height / 2) * size, center.z - (depth / 2) * size);
            
            GL.End();
        }
    }
}
