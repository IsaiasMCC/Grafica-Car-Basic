using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//openTK
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using CarBasic.negocio;

namespace CarBasic.negosio
{
    class Game: GameWindow
    {
        Objects obj1, obj2, obj3, obj4;

        public Game(int width, int height, string title): base(width, height, GraphicsMode.Default, title)
        {
            Run(60.0);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }

            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            //TODO LOAD INSTANCIAS
            obj1 = new Objects(new Point(0.5f, 0.5f, 0.5f), 0.5f, 0.7f, 0.2f, 0.6f);
            obj2 = new Objects(new Point(-0.5f, -0.5f, -0.5f), 0.5f, 0.7f, 0.2f, 0.6f);
            obj3 = new Objects(new Point(0.5f, -0.5f, 0.5f), 0.5f, 0.7f, 0.2f, 0.6f);
            obj4 = new Objects(new Point(-0.5f, 0.5f, 0.5f), 0.5f, 0.7f, 0.2f, 0.6f);

            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            //CODE GOES 
            obj1.draw();
            obj2.draw();
            obj3.draw();
            obj4.draw();
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            base.OnUnload(e);
        }
    }
}
