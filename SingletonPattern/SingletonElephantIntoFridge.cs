using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonElephantIntoFridge
    {
        /// <summary>
        /// 借助Lazy语法实现懒加载
        /// </summary>
        private static readonly Lazy<SingletonElephantIntoFridge> singleton = new Lazy<SingletonElephantIntoFridge>(() => new SingletonElephantIntoFridge());

        public static SingletonElephantIntoFridge GetInstance() => singleton.Value;

        private OperationStep step;

        /// <summary>
        /// 需要构造函数为私有的
        /// </summary>
        private SingletonElephantIntoFridge()
        {
            Console.WriteLine("Now story is beginning.");
            step = OperationStep.FridgeDoorClose;
        }

        public void OpenFridgeDoor()
        {
            if (!IsFridgeDoorClosed)
            {
                return;
            }
            Console.WriteLine("Fridge Door now is open.");
            step = OperationStep.FridgeDoorOpen;
        }

        public void PutElephantIn()
        {
            if (!IsFridgeDoorOpen)
            {
                return;
            }
            Console.WriteLine("Elephant now is in Fridge.");
            step = OperationStep.ElephantIn;
        }

        public void CloseFridgeDoor()
        {
            if (IsFridgeDoorOpen || IsFridgeDoorClosed)
            {
                return;
            }
            Console.WriteLine("Fridge Door now is in close.");
            step = OperationStep.FridgeDoorClose;
        }

        private bool IsFridgeDoorOpen => (step == OperationStep.FridgeDoorOpen);

        private bool IsFridgeDoorClosed => (step == OperationStep.FridgeDoorClose);
    }

    public enum OperationStep
    {
        FridgeDoorOpen,
        ElephantIn,
        FridgeDoorClose
    }


}
