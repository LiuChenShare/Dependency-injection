﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_3.IService
{
    internal interface IFactory
    {
        IWindow MakeWindow();

        IButton MakeButton();

        ITextBox MakeTextBox();
    }
}
