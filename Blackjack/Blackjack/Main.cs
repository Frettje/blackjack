﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Blackjack
{
    public class Main
    {
        public MainUI _mainUI;

        public Main(PictureBox pictureBox)
        {
            _mainUI = new MainUI(pictureBox);
        }
    }
}
