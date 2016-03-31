using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Sort
    {
        public event Action<int?> ProgressChanged;
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void QuickSort(List<SortModel> arr, int left, int right)
        {
            if (left > right)
            {
                if (left < arr.Count)
                {
                    arr[left].BackgroundColor = Color.Pink;
                    OnProgressChangedAndSleep(null, 0);
                }
                return;
            }
            SortModel baseVal = arr[left];
            int i = left, j = right;
            arr[left].BackgroundColor = Color.Plum;
            OnProgressChangedAndSleep(baseVal.Value);
            while (i < j)
            {
                arr[i].BackgroundColor = Color.Red;
                arr[j].BackgroundColor = Color.Red;
                OnProgressChangedAndSleep(null);
                while (arr[j].Value >= baseVal.Value && j > i)
                {
                    arr[j].BackgroundColor = Color.Green;
                    j--;
                    arr[j].BackgroundColor = Color.Red;
                    OnProgressChangedAndSleep(baseVal.Value);
                }
                while (arr[i].Value <= baseVal.Value && j > i)
                {
                    if (i != left)
                    {
                        arr[i].BackgroundColor = Color.Green;
                    }
                    i++;
                    arr[i].BackgroundColor = Color.Red;
                    arr[left].BackgroundColor = Color.Plum;
                    OnProgressChangedAndSleep(baseVal.Value);
                }
                if (i < j)
                {
                    Blink(arr[i], arr[j]);//交换前闪烁一下
                    Swap(arr, i, j);//交换
                }
            }

            if (i != left)
            {
                Blink(arr[left], arr[i]);//交换前闪烁一下
                Swap(arr, left, i);//交换
                arr[i].BackgroundColor = Color.Pink;
                arr[left].BackgroundColor = Color.Red;
                OnProgressChangedAndSleep(arr[left].Value);
            }
            QuickSort(arr, left, i - 1);
            QuickSort(arr, i + 1, right);
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        public void BubbleSort(List<SortModel> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = 0; j < arr.Count - i - 1; j++)
                {
                    arr[j].BackgroundColor = Color.Red;
                    arr[j + 1].BackgroundColor = Color.Red;
                    OnProgressChangedAndSleep(null);
                    if (arr[j + 1].Value < arr[j].Value)
                    {
                        Blink(arr[j], arr[j + 1]);
                        Swap(arr, j, j + 1);
                        OnProgressChangedAndSleep(null);
                    }
                    arr[j].BackgroundColor = Color.Green;
                    if (j == arr.Count - i - 2)
                        arr[j + 1].BackgroundColor = Color.Pink;
                    else
                        arr[j + 1].BackgroundColor = Color.Green;
                    OnProgressChangedAndSleep(null);
                }
            }
            arr[0].BackgroundColor = Color.Pink;
            OnProgressChangedAndSleep(null);
        }

        public void InsertionSort(List<SortModel> arr, out SortModel temp)
        {
            temp = null;
            OnProgressChangedAndSleep(null);
            for (int i = 1; i < arr.Count; i++)
            {
                arr[i].BackgroundColor = Color.Red;
                OnProgressChangedAndSleep(null);
                if (arr[i - 1].Value > arr[i].Value)
                {
                    temp = arr[i];
                    int prevX = arr[i].Rect.X;
                    temp.Rect = new Rectangle(10, temp.Rect.Y, temp.Rect.Width, temp.Rect.Height);
                    temp.BackgroundColor = Color.Plum;
                    OnProgressChangedAndSleep(null);
                    int j = i;
                    while (j > 0 && temp.Value < arr[j - 1].Value)
                    {
                        arr[j - 1].BackgroundColor = Color.Red;
                        Blink(arr[j - 1]);
                        Rectangle moveRect = new Rectangle(prevX, arr[j - 1].Rect.Y, arr[j - 1].Rect.Width, arr[j - 1].Rect.Height);
                        prevX = arr[j - 1].Rect.X;
                        arr[j] = arr[j - 1];
                        arr[j].Rect = moveRect;
                        arr[j].BackgroundColor = Color.Green;
                        j--;
                        OnProgressChangedAndSleep(null);
                    }

                    temp.Rect = new Rectangle(prevX, temp.Rect.Y, temp.Rect.Width, temp.Rect.Height);
                    temp.BackgroundColor = Color.Green;
                    arr[j] = temp;
                    OnProgressChangedAndSleep(null);
                }
                else
                {
                    arr[i].BackgroundColor = Color.Green;
                    OnProgressChangedAndSleep(null);
                }
            }
        }

        public void ShellSort(List<SortModel> arr, out SortModel temp)
        {
            temp = null;
            OnProgressChangedAndSleep(null);
            int gap = arr.Count / 2;
            while (gap > 0)
            {
                for (int i = gap; i < arr.Count; i++)
                {
                    arr[i].BackgroundColor = Color.Red;
                    arr[i - gap].BackgroundColor = Color.Red;
                    OnProgressChangedAndSleep(null);

                    temp = arr[i];
                    int prevX = arr[i].Rect.X;
                    temp.Rect = new Rectangle(10, temp.Rect.Y, temp.Rect.Width, temp.Rect.Height);
                    temp.BackgroundColor = Color.Plum;
                    OnProgressChangedAndSleep(null);
                    int j = i;

                    for (j = i - gap; j >= 0; j = j - gap)
                    {
                        if (temp.Value < arr[j].Value)
                        {
                            arr[j].BackgroundColor = Color.Red;
                            Blink(arr[j]);
                            Rectangle moveRect = new Rectangle(prevX, arr[j].Rect.Y, arr[j].Rect.Width, arr[j].Rect.Height);
                            prevX = arr[j].Rect.X;
                            arr[j + gap] = arr[j];
                            arr[j + gap].Rect = moveRect;
                            arr[j + gap].BackgroundColor = Color.Green;
                            OnProgressChangedAndSleep(null);
                        }
                        else
                        {
                            arr[i - gap].BackgroundColor = Color.Green;
                            break;
                        }
                    }

                    temp.Rect = new Rectangle(prevX, temp.Rect.Y, temp.Rect.Width, temp.Rect.Height);
                    temp.BackgroundColor = Color.Green;
                    arr[j + gap] = temp;
                    OnProgressChangedAndSleep(null);
                }
                gap = gap / 2;
            }

        }
        protected void OnProgressChangedAndSleep(int? baseVal, int sleep = 1500)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(baseVal);
                Thread.Sleep(sleep);
            }
        }

        private void Swap(List<SortModel> arr, int i, int j)
        {
            Rectangle ri = new Rectangle(arr[j].Rect.X, arr[i].Rect.Y, arr[i].Rect.Width, arr[i].Rect.Height);
            Rectangle rj = new Rectangle(arr[i].Rect.X, arr[j].Rect.Y, arr[j].Rect.Width, arr[j].Rect.Height);
            SortModel temp = arr[i];
            arr[i] = arr[j];
            arr[i].Rect = rj;
            temp.Rect = ri;
            arr[j] = temp;
        }

        private void Blink(params SortModel[] list)
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (SortModel item in list)
                {
                    item.OriginalColor = item.BackgroundColor;
                    item.BackgroundColor = Color.Green;
                }
                OnProgressChangedAndSleep(null, 100);
                foreach (SortModel item in list)
                {
                    item.BackgroundColor = item.OriginalColor;
                }
                OnProgressChangedAndSleep(null, 100);
            }
            OnProgressChangedAndSleep(null);
        }
    }
}
