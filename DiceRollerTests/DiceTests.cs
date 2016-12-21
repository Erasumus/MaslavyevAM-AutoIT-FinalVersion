using System;
using AutoItX3Lib;
using NUnit.Framework;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace MaslavyevAM
{
    [TestFixture]
    public class DiceTests : TestBase
    {
        [Test]
        public void ThrowDice() //Тест на кинуть кость
        {
            DiceSide side = DiceSide.D20;
            manager.Dice.ThrowDice(side);
            Assert.IsTrue(manager.Dice.CheckResultForDiceSide(side)); //Assert окно сообщения
        }

        [Test]
        public void ClearDice() //Тест на проверка очистки окна результата
        {
            manager.Dice.ClearDice();
            Assert.AreEqual("", manager.Dice.GetResult()); //Assert окно сообщения
        }
    }
}
