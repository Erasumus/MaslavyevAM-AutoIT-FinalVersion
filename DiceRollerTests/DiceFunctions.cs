using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaslavyevAM
{
    public enum DiceSide //Перечисление кубиков(кнопок)
    {
        D2   = 2,
        D3   = 3,
        D4   = 4,
        D6   = 6,
        D8   = 8,
        D10  = 10,
        D12  = 12,
        D20  = 20,
        D100 = 100,
    }
    public class DiceFunctions : FuncBase
    {
        public DiceFunctions(Manager manager)
            : base(manager) // Получили значения из Manager
        {
        }

        public void ClearDice() // Очистка окошка (полученного результата)
        {
            autoX.ControlClick(winTitle, "", "Button10");
        }

        public void ThrowDice(DiceSide side) //Бросание кости(нажатие кнопки)
        {
            autoX.ControlClick(winTitle, "", this.GetButtonStringFor(side)); 
        }

        public string GetResult() //Вывести результат
        {
            return autoX.ControlGetText(winTitle, "", "Static1");
        }

        public bool CheckResultForDiceSide(DiceSide side) //Проверка кости
        {
            Int32 result = Convert.ToInt32(autoX.ControlGetText(winTitle, "", "Static1"));
            return (result <= Convert.ToInt32(side));
        }

        private string GetButtonStringFor(DiceSide side) //Кнопки
        {
            switch (side)
            {
                case DiceSide.D2:
                    return "Button1";
                case DiceSide.D3:
                    return "Button2";
                case DiceSide.D4:
                    return "Button3";
                case DiceSide.D6:
                    return "Button4";
                case DiceSide.D8:
                    return "Button5";
                case DiceSide.D10:
                    return "Button6";
                case DiceSide.D12:
                    return "Button7";
                case DiceSide.D20:
                    return "Button8";
                case DiceSide.D100:
                    return "Button9";
                default:
                    return "Button1";
            }
        }

    }
}
