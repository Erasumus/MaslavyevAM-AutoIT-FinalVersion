using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using NUnit.Framework;

namespace MaslavyevAM
{
    public class Manager
    {
        public static string winTitle = "Dice Roller";
        private AutoItX3 autoX;
        private DiceFunctions dice;


        public Manager()
        {
            autoX = new AutoItX3();
            autoX.Run(@"C:\Program Files (x86)\AutoIt3\Examples\GUI\Advanced\dice.au3"); //Путь к самой программе
            autoX.WinWait(winTitle); //Ожидать окно
            autoX.WinActivate(winTitle); //Активация окна
            autoX.WinWaitActive(winTitle); //Остановка выполнения скрипта до активизации необходимого окна.

            dice = new DiceFunctions(this);
        }

        public void Stop() //Остановка программы.
        {
            autoX.WinClose(winTitle); //Закрытие окна.
        }

        public AutoItX3 AutoX { get { return autoX; } set { autoX = value; } }
        public string WinTitle { get { return winTitle; } }
        public DiceFunctions Dice { get { return dice; } }
    }
}
