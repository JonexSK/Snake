﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Piece : Label
    {
        public Piece(int x, int y)
        {
            Location = new System.Drawing.Point(x,y);
            Size = new System.Drawing.Size(20, 20);
            BackColor = Color.LimeGreen;
            Enabled = false;
        }
    }
}
