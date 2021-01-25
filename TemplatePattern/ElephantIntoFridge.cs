using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    /// <summary>
    /// 算法固定
    /// 实现各有区别
    /// 通常配合多态在运行时决定具体的对象与实现
    /// </summary>
    public abstract class ElephantIntoFridge
    {
        public abstract void OpenFridgeDoor();

        public abstract void PutElephantIn();

        public abstract void CloseFridgeDoor();

        public void PutElephantIntoFridge()
        {
            OpenFridgeDoor();

            PutElephantIn();

            CloseFridgeDoor();
        }
    }
}
