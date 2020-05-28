﻿using Maker.Business;
using Maker.Business.Model.OperationModel;
using Maker.Model;
using Maker.View.Dialog;
using Maker.View.LightScriptUserControl;
using Operation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Maker.View.UI.Style.Child
{
    [Serializable]
    public partial class CreateFromQuickOperationChild : OperationStyle
    {
        public override string Title { get; set; } = "FastGeneration";
        private CreateFromQuickOperationModel createFromQuickOperationModel;

        private TextBox tbTime, tbPosition, tbInterval, tbContinued, tbColor;
        private ComboBox cbType, cbAction;

        private List<String> types =new List<String>() { "Up", "Down", "UpDown", "DownUp", "UpAndDown", "DownAndUp", "FreezeFrame" };
        public CreateFromQuickOperationChild(CreateFromQuickOperationModel createFromQuickOperationModel, ScriptUserControl suc)
        {
            this.createFromQuickOperationModel = createFromQuickOperationModel;
            this.suc = suc;
            //构建对话框
            tbTime = GetTexeBox(createFromQuickOperationModel.Time.ToString());
            tbTime.Width = 270;
            AddTitleAndControl("TimeColon", new List<FrameworkElement>() { tbTime, ViewBusiness.GetImage("calc.png", 25) });

            StringBuilder sbPosition = new StringBuilder();
            foreach (var item in createFromQuickOperationModel.PositionList)
            {
                sbPosition.Append(item).Append(StaticConstant.mw.projectUserControl.suc.StrInputFormatDelimiter);
            }
            tbPosition = GetTexeBox(sbPosition.ToString().Substring(0, sbPosition.ToString().Length - 1));
            tbPosition.Width = 270;
            DrawRangeClass drawRangeClass = new DrawRangeClass(tbPosition);
            ShowRangeClass showRangeClassPosition = new ShowRangeClass(tbPosition);
            AddTitleAndControl("PositionColon", new List<FrameworkElement>() { tbPosition, ViewBusiness.GetImage("draw.png", 25, drawRangeClass.DrawRange), ViewBusiness.GetImage("more_white.png", 25, showRangeClassPosition.ShowRangeList) });

            tbInterval = GetTexeBox(createFromQuickOperationModel.Interval.ToString());
            AddTitleAndControl("IntervalColon", tbInterval);

            tbContinued = GetTexeBox(createFromQuickOperationModel.Continued.ToString());
            AddTitleAndControl("DurationColon", tbContinued);

            StringBuilder sbColor = new StringBuilder();
            foreach (var item in createFromQuickOperationModel.ColorList)
            {
                sbColor.Append(item).Append(StaticConstant.mw.projectUserControl.suc.StrInputFormatDelimiter);
            }
            tbColor = GetTexeBox(sbColor.ToString().Substring(0, sbColor.ToString().Length - 1));
            tbColor.Width = 270;
            ShowRangeClass showRangeClassColor = new ShowRangeClass(tbColor);
            AddTitleAndControl("ColorColon", new List<FrameworkElement>() { tbColor, ViewBusiness.GetImage("more_white.png", 25, showRangeClassColor.ShowRangeList) });

            cbType = GetComboBox(new List<String>() { "Up", "Down", "UpDown", "DownUp", "UpAndDown", "DownAndUp", "FreezeFrame" }, null);
            cbType.SelectedIndex = createFromQuickOperationModel.Type;
            AddTitleAndControl("TypeColon", cbType);

            cbAction = GetComboBox(new List<String>() { "All", "Open", "Close" }, null);
            cbAction.SelectedIndex = createFromQuickOperationModel.Action - 10;
            AddTitleAndControl("ActionColon", cbAction);

            if (cbType.SelectedIndex > 3)
            {
                cbAction.SelectedIndex = 0;
            }

            List<RunModel> runModel = new List<RunModel>
            {
                new RunModel("TimeColon", createFromQuickOperationModel.Time.ToString()),
                new RunModel("PositionColon", sbPosition.ToString().Substring(0, sbPosition.ToString().Length - 1), RunModel.RunType.Position),
                new RunModel("IntervalColon", createFromQuickOperationModel.Interval.ToString()),
                new RunModel("DurationColon", createFromQuickOperationModel.Continued.ToString()),
                new RunModel("ColorColon", sbColor.ToString().Substring(0, sbColor.ToString().Length - 1),RunModel.RunType.Color),
                new RunModel("TypeColon", ((ComboBoxItem)cbType.SelectedItem).Content.ToString(), RunModel.RunType.Combo, new List<String>() { "Up", "Down", "UpDown", "DownUp", "UpAndDown", "DownAndUp", "FreezeFrame" }),
                new RunModel("ActionColon", ((ComboBoxItem)cbAction.SelectedItem).Content.ToString(), RunModel.RunType.Combo, new List<String>() { "All", "Open", "Close" })
            };

            tbMain = GetTexeBlockNoBorder("", false);
            tbMain.FontSize = 18;
            tbMain.TextWrapping = TextWrapping.Wrap;

            tbRight = GetTexeBlockNoBorder("", false);
            tbRight.FontSize = 18;
            tbRight.TextWrapping = TextWrapping.Wrap;

            tbEdit = GetTexeBox("");
            tbEdit.FontSize = 18;

            runs = GetRuns(tbMain,runModel);

            SolidColorBrush solidNormal = (SolidColorBrush)suc.mw.Resources["Text_Normal"];
            SolidColorBrush solidOrange = (SolidColorBrush)suc.mw.Resources["Text_Orange"];
           
            foreach (var item in runs)
            {
                tbMain.Inlines.Add(item);
            }
            AddDockPanel(out DockPanel dp, tbMain, tbEdit,tbRight);

            CreateDialog();
        }


        public class DrawRangeClass
        {
            public TextBox TbInput
            {
                get;
                set;
            }

            public DrawRangeClass(TextBox tbInput)
            {
                TbInput = tbInput;
            }

            public void DrawRange(object sender, MouseButtonEventArgs e)
            {
                DrawRangeDialog dialog = new DrawRangeDialog(StaticConstant.mw);
                StringBuilder builder = new StringBuilder();
                if (dialog.ShowDialog() == true)
                {
                    foreach (int i in dialog.Content)
                    {
                        builder.Append(i + " ");
                    }
                    TbInput.Text = builder.ToString().Trim();
                }
            }
        }

        public class ShowRangeClass
        {
            public TextBox TbInput
            {
                get;
                set;
            }

            public ShowRangeClass(TextBox tbInput)
            {
                TbInput = tbInput;
            }

            public void ShowRangeList(object sender, MouseButtonEventArgs e)
            {
                ShowRangeListDialog dialog = new ShowRangeListDialog(StaticConstant.mw.projectUserControl.suc);
                if (dialog.ShowDialog() == true)
                {
                    String[] str = StaticConstant.mw.projectUserControl.suc.rangeDictionary.Keys.ToArray();
                    TbInput.Text = str[dialog.lbMain.SelectedIndex];
                }
                SaveRangeFile();
            }

            private void SaveRangeFile()
            {
                StringBuilder builder = new StringBuilder();
                foreach (var item in StaticConstant.mw.projectUserControl.suc.rangeDictionary)
                {
                    builder.Append(item.Key + ":");
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        if (i == item.Value.Count - 1)
                        {
                            builder.Append(item.Value[i] + ";" + Environment.NewLine);
                        }
                        else
                        {
                            builder.Append(item.Value[i] + ",");
                        }
                    }
                }
                String filePath = AppDomain.CurrentDomain.BaseDirectory + @"RangeList\test.Range";
                //获得文件路径
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
                FileStream f = new FileStream(filePath, FileMode.OpenOrCreate);
                for (int j = 0; j < builder.Length; j++)
                {
                    //Console.WriteLine((int)line[j]);
                    f.WriteByte((byte)builder[j]);
                }
                f.Close();
            }
        }


        protected override void RefreshView()
        {
            char splitNotation = StaticConstant.mw.projectUserControl.suc.StrInputFormatDelimiter;
            char rangeNotation = StaticConstant.mw.projectUserControl.suc.StrInputFormatRange;

            List<int> positions = null;
            List<int> colors = null;

            StringBuilder fastGenerationrRangeBuilder = new StringBuilder();
            String position = runs[5].Text;
            if (suc.rangeDictionary.ContainsKey(position))
            {
                for (int i = 0; i < suc.rangeDictionary[position].Count; i++)
                {
                    if (i != suc.rangeDictionary[position].Count - 1)
                    {
                        fastGenerationrRangeBuilder.Append(suc.rangeDictionary[position][i] + splitNotation.ToString());
                    }
                    else
                    {
                        fastGenerationrRangeBuilder.Append(suc.rangeDictionary[position][i]);
                    }
                }
            }
            else
            {
                positions = GetTrueContent(position, splitNotation, rangeNotation);
                if (positions != null)
                {
                    fastGenerationrRangeBuilder.Append(position);
                }
                else
                {
                    tbPosition.Select(0, tbPosition.Text.Length);
                    tbPosition.Focus();
                    return;
                }
            }
            String color = runs[14].Text;
            StringBuilder fastGenerationrColorBuilder = new StringBuilder();
            if (suc.rangeDictionary.ContainsKey(color))
            {
                for (int i = 0; i < suc.rangeDictionary[color].Count; i++)
                {
                    if (i != suc.rangeDictionary[color].Count - 1)
                    {
                        fastGenerationrColorBuilder.Append(suc.rangeDictionary[color][i] + splitNotation.ToString());
                    }
                    else
                    {
                        fastGenerationrColorBuilder.Append(suc.rangeDictionary[color][i]);
                    }
                }
            }
            else
            {
                colors = GetTrueContent(color, splitNotation, rangeNotation);
                if (colors != null)
                {
                    fastGenerationrColorBuilder.Append(color);
                }
                else
                {
                    tbColor.Select(0, tbColor.Text.Length);
                    tbColor.Focus();
                    return;
                }
            }
            object result = null;
            String time = runs[2].Text;
            try
            {
                string expression = time;
                System.Data.DataTable eval = new System.Data.DataTable();
                result = eval.Compute(expression, "");
            }
            catch
            {
                tbTime.Select(0, tbTime.Text.Length);
                tbTime.Focus();
                return;
            }

            String interval = runs[8].Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(interval, "^\\d+$"))
            {
                tbInterval.Select(0, tbInterval.Text.Length);
                tbInterval.Focus();
                return;
            }
            String continued = runs[11].Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(continued, "^\\d+$"))
            {
                tbContinued.Select(0, tbContinued.Text.Length);
                tbContinued.Focus();
                return;
            }
            
            //Type
            int type = 0;

            String strType = runs[17].Text;
            int _type = -1;
            for (int i = 0; i < types.Count; i++) {
                if (((string)Application.Current.FindResource(types[i])).Equals(strType)) {
                    _type = i;
                }
            }
            switch (_type)
            {
                case -1:
                    return;
                case 0:
                    type = Create.UP;
                    break;
                case 1:
                    type = Create.DOWN;
                    break;
                case 2:
                    type = Create.UPDOWN;
                    break;
                case 3:
                    type = Create.DOWNUP;
                    break;
                case 4:
                    type = Create.UPANDDOWN;
                    break;
                case 5:
                    type = Create.DOWNANDUP;
                    break;
                case 6:
                    type = Create.FREEZEFRAME;
                    break;
            }
            //Action
            int action = 0;
            switch (cbAction.SelectedIndex)
            {
                case -1:
                    return;
                case 0:
                    action = Create.ALL;
                    break;
                case 1:
                    action = Create.OPEN;
                    break;
                case 2:
                    action = Create.CLOSE;
                    break;
            }

            createFromQuickOperationModel.Time = (int)result;
            createFromQuickOperationModel.PositionList = positions;
            createFromQuickOperationModel.Interval = int.Parse(interval);
            createFromQuickOperationModel.Continued = int.Parse(continued);
            createFromQuickOperationModel.ColorList = colors;
            createFromQuickOperationModel.Type = type;
            createFromQuickOperationModel.Action = action;

            //suc.UpdateStep();
            //RefreshView();
        }

            /// <summary>
            /// 内容是否正确
            /// </summary>
            /// <param name="content"></param>
            /// <param name="split"></param>
            /// <param name="range"></param>
            /// <returns></returns>
            public List<int> GetTrueContent(String content, char split, char range)
        {
            try
            {
                List<int> nums = new List<int>();
                string[] strSplit = content.Split(split);
                for (int i = 0; i < strSplit.Length; i++)
                {
                    if (strSplit[i].Contains(range))
                    {
                        String[] TwoNumber = null;
                        TwoNumber = strSplit[i].Split(range);

                        int One = int.Parse(TwoNumber[0]);
                        int Two = int.Parse(TwoNumber[1]);
                        if (One < Two)
                        {
                            for (int k = One; k <= Two; k++)
                            {
                                nums.Add(k);
                            }
                        }
                        else if (One > Two)
                        {
                            for (int k = One; k >= Two; k--)
                            {
                                nums.Add(k);
                            }
                        }
                        else
                        {
                            nums.Add(One);
                        }
                    }
                    else
                    {
                        nums.Add(int.Parse(strSplit[i]));
                    }
                }
                return nums;
            }
            catch
            {
                return null;
            }
        }

        public override bool ToSave()
        {
            return true;
        }
    }
}
