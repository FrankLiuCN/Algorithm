﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SortModel> modelArr;
        SortModel tempModel;
        int panelH = 50;
        int modelW = 40;
        Thread quickSorkThread;
        Sort s = new Sort();
        Font myFont = new Font("Verdana", 12);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> strArr = textBox1.Text.Split(' ').ToList<string>();
                modelArr = new List<SortModel>();
                int max = GetMax(strArr);
                float percent = (float)(panel1.Height - panelH) / (float)max;

                for (int i = 0; i < strArr.Count; i++)
                {
                    SortModel model = new SortModel();
                    model.Value = int.Parse(strArr[i]);
                    model.BackgroundColor = Color.Green;
                    model.OriginalColor = Color.Green;
                    model.Rect = new Rectangle(i * (modelW + 10) + 10, (panel1.Height - (int)(model.Value * percent) - 2), modelW, (int)(model.Value * percent));
                    modelArr.Add(model);
                }
                panel1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GenerateList(int startX = 10)
        {
            try
            {
                List<string> strArr = textBox1.Text.Split(' ').ToList<string>();
                modelArr = new List<SortModel>();
                int max = GetMax(strArr);
                float percent = (float)(panel1.Height - panelH) / (float)max;

                for (int i = 0; i < strArr.Count; i++)
                {
                    SortModel model = new SortModel();
                    model.Value = int.Parse(strArr[i]);
                    model.BackgroundColor = Color.Green;
                    model.OriginalColor = Color.Green;
                    model.Rect = new Rectangle(i * (modelW + 10) + startX, (panel1.Height - (int)(model.Value * percent) - 2), modelW, (int)(model.Value * percent));
                    modelArr.Add(model);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetMax(List<string> strArr)
        {
            int max = int.Parse(strArr[0]);
            foreach (string item in strArr)
            {
                if (int.Parse(item) > max)
                {
                    max = int.Parse(item);
                }
            }
            return max;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (modelArr != null)
            {
                lock (modelArr)
                {
                    Graphics gp = e.Graphics;
                    if (tempModel != null)
                    {
                        gp.FillRectangle(new SolidBrush(tempModel.BackgroundColor), tempModel.Rect); //填充
                        gp.DrawString(tempModel.Value.ToString(), myFont, new SolidBrush(Color.Black), new RectangleF(tempModel.Rect.X + (modelW - myFont.Size * tempModel.Value.ToString().Length) / 2, tempModel.Rect.Y - myFont.Height, (myFont.Size + 2) * tempModel.Value.ToString().Length, myFont.Height));
                    }
                    foreach (SortModel item in modelArr)
                    {
                        if (item.Value != null)
                        {
                            gp.FillRectangle(new SolidBrush(item.BackgroundColor), item.Rect); //填充
                            gp.DrawString(item.Value.ToString(), myFont, new SolidBrush(Color.Black), new RectangleF(item.Rect.X + (modelW - myFont.Size * item.Value.ToString().Length) / 2, item.Rect.Y - myFont.Height, (myFont.Size + 2) * item.Value.ToString().Length, myFont.Height));
                        }
                    }
                    gp.Flush();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (quickSorkThread != null && quickSorkThread.ThreadState == ThreadState.Running)
            {
                quickSorkThread.Abort();
            }
            GenerateList();

            s.ProgressChanged += s_ProgressChanged;
            quickSorkThread = new Thread(() => s.QuickSort(modelArr, 0, modelArr.Count - 1));
            quickSorkThread.Start();
        }

        void s_ProgressChanged(int? baseVal)
        {
            PanelRefresh();
            //BaseValRefresh(baseVal);
        }

        private void BaseValRefresh(int? baseVal)
        {
            if (baseVal == null)
            {
                return;
            }
            this.Invoke(new Action(delegate()
            {
                //lblBaseVal.Text = "当前基准数为:" + baseVal;
            }));


        }
        private void PanelRefresh()
        {
            if (panel1.InvokeRequired)
            {
                this.Invoke(new Action(PanelRefresh));
            }
            else
            {
                panel1.Refresh();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (quickSorkThread != null)
            {
                quickSorkThread.Abort();
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            if (quickSorkThread != null && quickSorkThread.ThreadState == ThreadState.Running)
            {
                quickSorkThread.Abort();
            }
            GenerateList();
            s.ProgressChanged += s_ProgressChanged;
            quickSorkThread = new Thread(() => s.BubbleSort(modelArr));
            quickSorkThread.Start();
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            GenerateList(modelW + 20);
            s.ProgressChanged += s_ProgressChanged;
            quickSorkThread = new Thread(() => s.InsertionSort(modelArr, out tempModel));
            quickSorkThread.Start();
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            GenerateList(modelW + 20);
            s.ProgressChanged += s_ProgressChanged;
            quickSorkThread = new Thread(() => s.ShellSort(modelArr, out tempModel));
            quickSorkThread.Start();
        }

    }
}
