using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using NUnit.Framework;

namespace MaslavyevAM
{
    public class FuncBase
    {
        protected Manager manager;
        protected string winTitle;
        protected AutoItX3 autoX;

        public FuncBase(Manager manager)
        {
            this.manager = manager;
            winTitle = manager.WinTitle;
            autoX = manager.AutoX;
        }


    }
}
