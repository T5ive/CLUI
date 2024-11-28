﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CLUI
{
    public class Label : IComponent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 1;
        public string Text { get; set; } = "text";
        public ConsoleColor BackGroundColor { get; set; }
        public ConsoleColor ForeGroundColor { get; set; }
        public HorizontalAlignment HorizontalAlignment { get; set; } = 0;
        private int _offsetX = 0;
        private int _offsetY = 0;
        public void Render(int offsetX, int offsetY)
        {
            _offsetX = offsetX;
            _offsetY = offsetY;

            if (Width == 0)
            {
                Width = Text.Length;
            }

            Console.ForegroundColor = ForeGroundColor;
            Console.BackgroundColor = BackGroundColor;
            if (HorizontalAlignment == HorizontalAlignment.Left)
            {
                Console.SetCursorPosition(X + offsetX, Y + offsetY);
                string outputText = Text;
                outputText += new string(' ', Width - Text.Length);
                Console.Write(outputText);
            }
        }
        public void Update()
        {
            this.Render(_offsetX, _offsetY);
        }
    }
    public enum HorizontalAlignment
    {
        Left, Right, Center
    }

}
