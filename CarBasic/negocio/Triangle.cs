﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace CarBasic.negocio
{
    class Triangle: IObject
    {
        private float width;
        private float height;
        private float depth;
        private float size;
        private Point center;

        public Triangle(Point center, float width, float height, float depth, float size)
        {
            this.center = center;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.size = size;
        }

        public void draw()
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(1.0, 0.5, 0.0);
            GL.Vertex3(center.x - (width / 2 ) * size,  center.y - (height / 2) * size, center.z + depth * size );
            GL.Vertex3(center.x , center.y + (height / 2) * size, center.z + depth * size);
            GL.Vertex3(center.x + (width / 2) * size, center.y - (height / 2) * size, center.z + depth * size);
            GL.End();
        }

    }
}
