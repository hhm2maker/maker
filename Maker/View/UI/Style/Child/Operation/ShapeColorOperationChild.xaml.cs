﻿using Maker.Business;
using Maker.Business.Model.OperationModel;
using Maker.Model;
using Maker.View.Control;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Maker.View.UI.Style.Child
{
    /// <summary>
    /// ShapeColorDialog.xaml 的交互逻辑
    /// </summary>
    public partial class ShapeColorOperationChild : OperationStyle
    {
        public override string Title { get; set; } = "ShapeColor";
        private ShapeColorOperationModel shapeColorOperationModel;

        private List<TextBox> textBoxs = new List<TextBox>();
        public ShapeColorOperationChild(ShapeColorOperationModel shapeColorOperationModel)
        {
            InitializeComponent();
                
            this.shapeColorOperationModel = shapeColorOperationModel;

            ComboBox cb = GetComboBox(new List<string>() { "Square", "Vertical", "Horizontal" }, null);
            cb.IsEnabled = false;
            AddTitleAndControl("TypeColon",cb);

            osContent.Content = null;
            AddUIElement(spContent);

            CreateDialog();

            mLaunchpad.SetLaunchpadBackground(new SolidColorBrush(Color.FromRgb(43, 43, 43)));
            mLaunchpad.Size = 300;

            textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[0] + ""));
            textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[1] + ""));
            textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[2] + ""));
            textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[3] + ""));
            textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[4] + ""));

            if (shapeColorOperationModel.MyShapeType == ShapeColorOperationModel.ShapeType.SQUARE)
            {
                cb.SelectedIndex = 0;
            }
            else if (shapeColorOperationModel.MyShapeType == ShapeColorOperationModel.ShapeType.RADIALVERTICAL)
            {
                cb.SelectedIndex = 1;

                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[5] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[6] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[7] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[8] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[9] + ""));
            }
            else if (shapeColorOperationModel.MyShapeType == ShapeColorOperationModel.ShapeType.RADIALVERTICAL)
            {
                cb.SelectedIndex = 2;

                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[5] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[6] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[7] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[8] + ""));
                textBoxs.Add(GetTexeBox(shapeColorOperationModel.Colors[9] + ""));
            }
            GetTexeBlock(shapeColorOperationModel.TopString);

            dpContent.Children.Add(GetTexeBlock(shapeColorOperationModel.TopString));
            
            foreach(var item in textBoxs) {
                dpContent.Children.Add(item);
            }

            dpContent.Children.Add(GetTexeBlock(shapeColorOperationModel.BottomString));
        }
   
        /// <summary>
        /// 数字转笔刷
        /// </summary>
        /// <param name="i">颜色数值</param>
        /// <returns>SolidColorBrush笔刷</returns>
        private SolidColorBrush NumToBrush(int i)
        {
            if (i == 0)
            {
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4F4F5"));
            }
            else
            {
                return StaticConstant.brushList[i - 1];
            }
        }
        
        public override bool ToSave()
        {
            if (!int.TryParse(textBoxs[0].Text, out int numberOne))
            {
                textBoxs[0].Select(0, textBoxs[0].Text.Length);
                return false;
            }
            if (!int.TryParse(textBoxs[1].Text, out int numberTwo))
            {
                textBoxs[1].Select(0, textBoxs[1].Text.Length);
                return false;
            }
            if (!int.TryParse(textBoxs[2].Text, out int numberThree))
            {
                textBoxs[2].Select(0, textBoxs[2].Text.Length);
                return false;
            }
            if (!int.TryParse(textBoxs[3].Text, out int numberFour))
            {
                textBoxs[3].Select(0, textBoxs[3].Text.Length);
                return false;
            }
            if (!int.TryParse(textBoxs[4].Text, out int numberFive))
            {
                textBoxs[4].Select(0, textBoxs[4].Text.Length);
                return false;
            }
          
            shapeColorOperationModel.Colors.Clear();
            shapeColorOperationModel.Colors.Add(numberOne);
            shapeColorOperationModel.Colors.Add(numberTwo);
            shapeColorOperationModel.Colors.Add(numberThree);
            shapeColorOperationModel.Colors.Add(numberFour);
            shapeColorOperationModel.Colors.Add(numberFive);
          
            if (shapeColorOperationModel.MyShapeType != ShapeColorOperationModel.ShapeType.SQUARE) {

                if (!int.TryParse(textBoxs[5].Text, out int numberSix))
                {
                    textBoxs[5].Select(0, textBoxs[5].Text.Length);
                    return false;
                }
                if (!int.TryParse(textBoxs[6].Text, out int numberSeven))
                {
                    textBoxs[6].Select(0, textBoxs[6].Text.Length);
                    return false;
                }
                if (!int.TryParse(textBoxs[7].Text, out int numberEight))
                {
                    textBoxs[7].Select(0, textBoxs[7].Text.Length);
                    return false;
                }
                if (!int.TryParse(textBoxs[8].Text, out int numberNine))
                {
                    textBoxs[8].Select(0, textBoxs[8].Text.Length);
                    return false;
                }
                if (!int.TryParse(textBoxs[9].Text, out int numberTen))
                {
                    textBoxs[9].Select(0, textBoxs[9].Text.Length);
                    return false;
                }

                shapeColorOperationModel.Colors.Add(numberSix);
                shapeColorOperationModel.Colors.Add(numberSeven);
                shapeColorOperationModel.Colors.Add(numberEight);
                shapeColorOperationModel.Colors.Add(numberNine);
                shapeColorOperationModel.Colors.Add(numberTen);
            }
            return true;
        }
     
        private void Preview(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(textBoxs[0].Text, out int numberOne))
            {
                textBoxs[0].Select(0, textBoxs[0].Text.Length);
                return ;
            }
            if (!int.TryParse(textBoxs[1].Text, out int numberTwo))
            {
                textBoxs[1].Select(0, textBoxs[1].Text.Length);
                return ;
            }
            if (!int.TryParse(textBoxs[2].Text, out int numberThree))
            {
                textBoxs[2].Select(0, textBoxs[2].Text.Length);
                return ;
            }
            if (!int.TryParse(textBoxs[3].Text, out int numberFour))
            {
                textBoxs[3].Select(0, textBoxs[3].Text.Length);
                return ;
            }
            if (!int.TryParse(textBoxs[4].Text, out int numberFive))
            {
                textBoxs[4].Select(0, textBoxs[4].Text.Length);
                return ;
            }
            //方形
            if (shapeColorOperationModel.MyShapeType == ShapeColorOperationModel.ShapeType.SQUARE ) {
                List<List<int>> lli = new List<List<int>>();
                lli.Add(new List<int>() { 51, 55, 80, 84 });
                lli.Add(new List<int>() { 46, 47, 50, 54, 58, 59, 76, 77, 81, 85, 88, 89 });
                lli.Add(new List<int>() { 41, 42, 43, 45, 49, 53, 57, 61, 62, 63, 72, 73, 74, 78, 82, 86, 90, 92, 93, 94 });
                lli.Add(new List<int>() { 36, 37, 38, 39, 40, 44, 48, 52, 56, 60, 64, 65,66,67,68,69,70,71,75,79,83,87,91,95,96,97,98,99 });
                List<int> _list = new List<int>();
                for (int i = 28;i<=35;i++) {
                    _list.Add(i);
                }
                for (int i = 100; i <= 123; i++)
                {
                    _list.Add(i);
                }
                lli.Add(_list);
                if (numberOne != 0) {
                   for(int i = 0;i < lli[0].Count; i++) {
                        mLaunchpad.SetButtonBackground(lli[0][i] - 28,NumToBrush(numberOne));
                    }
                }
                if (numberTwo != 0)
                {
                    for (int i = 0; i < lli[1].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[1][i] - 28, NumToBrush(numberTwo));
                    }
                }
                if (numberThree != 0)
                {
                    for (int i = 0; i < lli[2].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[2][i] - 28, NumToBrush(numberThree));
                    }
                }
                if (numberFour != 0)
                {
                    for (int i = 0; i < lli[3].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[3][i] - 28, NumToBrush(numberFour));
                    }
                }
                if (numberFive != 0)
                {
                    for (int i = 0; i < lli[4].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[4][i] - 28, NumToBrush(numberFive));
                    }
                }
            }
            //垂直径向
            if (shapeColorOperationModel.MyShapeType == ShapeColorOperationModel.ShapeType.RADIALVERTICAL)
            {
                if (!int.TryParse(textBoxs[5].Text, out int numberSix))
                {
                    textBoxs[5].Select(0, textBoxs[5].Text.Length);
                    return ;
                }
                if (!int.TryParse(textBoxs[6].Text, out int numberSeven))
                {
                    textBoxs[6].Select(0, textBoxs[6].Text.Length);
                    return ;
                }
                if (!int.TryParse(textBoxs[7].Text, out int numberEight))
                {
                    textBoxs[7].Select(0, textBoxs[7].Text.Length);
                    return ;
                }
                if (!int.TryParse(textBoxs[8].Text, out int numberNine))
                {
                    textBoxs[8].Select(0, textBoxs[8].Text.Length);
                    return ;
                }
                if (!int.TryParse(textBoxs[9].Text, out int numberTen))
                {
                    textBoxs[9].Select(0, textBoxs[9].Text.Length);
                    return ;
                }

                List<List<int>> lli = new List<List<int>>();
                lli.Add(new List<int>() { 28, 29, 30, 31, 32, 33, 34, 35 });
                lli.Add(new List<int>() { 108, 64, 65, 66, 67, 96, 97, 98, 99, 100 });
                lli.Add(new List<int>() { 109, 60, 61, 62, 63, 92, 93, 94, 95, 101 });
                lli.Add(new List<int>() { 110, 56, 57, 58, 59, 88, 89, 90, 91, 102 });
                lli.Add(new List<int>() { 111, 52, 53, 54, 55, 84, 85, 86, 87, 103 });
                lli.Add(new List<int>() { 112, 48, 49, 50, 51, 80, 81, 82, 83, 104 });
                lli.Add(new List<int>() { 113, 44, 45, 46, 47, 76, 77, 78, 79, 105 });
                lli.Add(new List<int>() { 114, 40, 41, 42, 43, 72, 73, 74, 75, 106 });
                lli.Add(new List<int>() { 115, 36, 37, 38, 39, 68, 69, 70, 71, 107 });
                lli.Add(new List<int>() { 116, 117, 118, 119, 120, 121, 122, 123 });
                if (numberOne != 0)
                {
                    for (int i = 0; i < lli[0].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[0][i] - 28, NumToBrush(numberOne));
                    }
                }
                if (numberTwo != 0)
                {
                    for (int i = 0; i < lli[1].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[1][i] - 28, NumToBrush(numberTwo));
                    }
                }
                if (numberThree != 0)
                {
                    for (int i = 0; i < lli[2].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[2][i] - 28, NumToBrush(numberThree));
                    }
                }
                if (numberFour != 0)
                {
                    for (int i = 0; i < lli[3].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[3][i] - 28, NumToBrush(numberFour));
                    }
                }
                if (numberFive != 0)
                {
                    for (int i = 0; i < lli[4].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[4][i] - 28, NumToBrush(numberFive));
                    }
                }
                if (numberSix != 0)
                {
                    for (int i = 0; i < lli[5].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[5][i] - 28, NumToBrush(numberSix));
                    }
                }
                if (numberSeven != 0)
                {
                    for (int i = 0; i < lli[6].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[6][i] - 28, NumToBrush(numberSeven));
                    }
                }
                if (numberEight != 0)
                {
                    for (int i = 0; i < lli[7].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[7][i] - 28, NumToBrush(numberEight));
                    }
                }
                if (numberNine != 0)
                {
                    for (int i = 0; i < lli[8].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[8][i] - 28, NumToBrush(numberNine));
                    }
                }
                if (numberTen != 0)
                {
                    for (int i = 0; i < lli[9].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[9][i] - 28, NumToBrush(numberTen));
                    }
                }
            }
            //水平径向
            if (shapeColorOperationModel.MyShapeType == ShapeColorOperationModel.ShapeType.RADIALHORIZONTAL)
            {
                if (!int.TryParse(textBoxs[5].Text, out int numberSix))
                {
                    textBoxs[5].Select(0, textBoxs[5].Text.Length);
                    return;
                }
                if (!int.TryParse(textBoxs[6].Text, out int numberSeven))
                {
                    textBoxs[6].Select(0, textBoxs[6].Text.Length);
                    return;
                }
                if (!int.TryParse(textBoxs[7].Text, out int numberEight))
                {
                    textBoxs[7].Select(0, textBoxs[7].Text.Length);
                    return;
                }
                if (!int.TryParse(textBoxs[8].Text, out int numberNine))
                {
                    textBoxs[8].Select(0, textBoxs[8].Text.Length);
                    return;
                }
                if (!int.TryParse(textBoxs[9].Text, out int numberTen))
                {
                    textBoxs[9].Select(0, textBoxs[9].Text.Length);
                    return;
                }

                List<List<int>> lli = new List<List<int>>();
                lli.Add(new List<int>() { 108, 109, 110, 111, 112, 113, 114, 115 });
                lli.Add(new List<int>() { 28, 64, 60, 56, 52, 48, 44, 40, 36, 116 });
                lli.Add(new List<int>() { 29, 65, 61, 57, 53, 49, 45, 41, 37, 117 });
                lli.Add(new List<int>() { 30, 66, 62, 58, 54, 50, 46, 42, 38, 118 });
                lli.Add(new List<int>() { 31, 67, 63, 59, 55, 51, 47, 43, 39, 119 });
                lli.Add(new List<int>() { 32, 96, 92, 88, 84, 80, 76, 72, 68, 120 });
                lli.Add(new List<int>() { 33, 97, 93, 89, 85, 81, 77, 73, 69, 121 });
                lli.Add(new List<int>() { 34, 98, 94, 90, 86, 82, 78, 74, 70, 122 });
                lli.Add(new List<int>() { 35, 99, 95, 91, 87, 83, 79, 75, 71, 123 });
                lli.Add(new List<int>() { 100, 101, 102, 103, 104, 105, 106, 107 });
                if (numberOne != 0)
                {
                    for (int i = 0; i < lli[0].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[0][i] - 28, NumToBrush(numberOne));
                    }
                }
                if (numberTwo != 0)
                {
                    for (int i = 0; i < lli[1].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[1][i] - 28, NumToBrush(numberTwo));
                    }
                }
                if (numberThree != 0)
                {
                    for (int i = 0; i < lli[2].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[2][i] - 28, NumToBrush(numberThree));
                    }
                }
                if (numberFour != 0)
                {
                    for (int i = 0; i < lli[3].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[3][i] - 28, NumToBrush(numberFour));
                    }
                }
                if (numberFive != 0)
                {
                    for (int i = 0; i < lli[4].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[4][i] - 28, NumToBrush(numberFive));
                    }
                }
                if (numberSix != 0)
                {
                    for (int i = 0; i < lli[5].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[5][i] - 28, NumToBrush(numberSix));
                    }
                }
                if (numberSeven != 0)
                {
                    for (int i = 0; i < lli[6].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[6][i] - 28, NumToBrush(numberSeven));
                    }
                }
                if (numberEight != 0)
                {
                    for (int i = 0; i < lli[7].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[7][i] - 28, NumToBrush(numberEight));
                    }
                }
                if (numberNine != 0)
                {
                    for (int i = 0; i < lli[8].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[8][i] - 28, NumToBrush(numberNine));
                    }
                }
                if (numberTen != 0)
                {
                    for (int i = 0; i < lli[9].Count; i++)
                    {
                        mLaunchpad.SetButtonBackground(lli[9][i] - 28, NumToBrush(numberTen));
                    }
                }
            }
        }

        private void PasteRangeListContent(object sender, RoutedEventArgs e)
        {
            try
            {
                IDataObject iData = Clipboard.GetDataObject();
                // Determines whether the data is in a format you can use.
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    // Yes it is, so display it in a text box.
                    String str = (String)iData.GetData(DataFormats.Text);
                    String[] strs = str.Split(' ');
                    if (strs.Length > 0) {
                        textBoxs[0].Text = strs[0];
                    }
                    if (strs.Length > 1)
                    {
                        textBoxs[1].Text = strs[1];
                    }
                    if (strs.Length > 2)
                    {
                        textBoxs[2].Text = strs[2];
                    }
                    if (strs.Length > 3)
                    {
                        textBoxs[3].Text = strs[3];
                    }
                    if (strs.Length > 4)
                    {
                        textBoxs[4].Text = strs[4];
                    }
                    if (strs.Length > 5)
                    {
                        textBoxs[5].Text = strs[5];
                    }
                    if (strs.Length > 6)
                    {
                        textBoxs[6].Text = strs[6];
                    }
                    if (strs.Length > 7)
                    {
                        textBoxs[7].Text = strs[7];
                    }
                    if (strs.Length > 8)
                    {
                        textBoxs[8].Text = strs[8];
                    }
                    if (strs.Length > 9)
                    {
                        textBoxs[8].Text = strs[9];
                    }
                }
            }
            catch {
            }
        }
    }
}
