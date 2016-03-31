using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm
{
    class MyPanel : Panel
    {
        public MyPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);//不擦除背景
            this.SetStyle(ControlStyles.UserPaint, true);//使用自定义重绘
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//双缓冲       
        }
    }
}
