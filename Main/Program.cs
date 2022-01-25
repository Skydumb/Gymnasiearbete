using System;
using System.Collections.Generic;
using System.Collections;
using GLFW;
using OpenGL;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Glfw.Init();

        }
    }

    public class DisplayManager
    {
        NativeWindow window;
        public DisplayManager(int height, int width, string name)
        {
            window = new NativeWindow(width, height, name);
        }
    }
}
