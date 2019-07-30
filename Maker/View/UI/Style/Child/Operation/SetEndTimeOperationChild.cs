﻿using Maker.Business.Model.OperationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Maker.View.UI.Style.Child
{
    public partial class SetEndTimeOperationChild : OperationStyle
    {
        public override string Title { get; set; } = "EndTime";
        private SetEndTimeOperationModel setEndTimeOperationModel;
        public SetEndTimeOperationChild(SetEndTimeOperationModel setEndTimeOperationModel)
        {
            this.setEndTimeOperationModel =  setEndTimeOperationModel;
            //构建对话框
            cbType = GetComboBox(new List<string>() { "All", "End", "AllAndEnd" }, null);
            AddTitleAndControl("TypeColon", cbType);
            tbValue = GetTexeBox(setEndTimeOperationModel.Value.ToString());
            AddTitleAndControl("ValueColon", tbValue);

            CreateDialog();

            if (setEndTimeOperationModel.MyType == SetEndTimeOperationModel.Type.ALL)
            {
                cbType.SelectedIndex = 0;
            }
            else if (setEndTimeOperationModel.MyType == SetEndTimeOperationModel.Type.END)
            {
                cbType.SelectedIndex = 1;
            }
            else if(setEndTimeOperationModel.MyType == SetEndTimeOperationModel.Type.ALLANDEND)
            {
                cbType.SelectedIndex = 2;
            }
            tbValue.Text = setEndTimeOperationModel.Value.ToString();

            cbType.SelectionChanged += CbOperation_SelectionChanged;
        }

        private void CbOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbType.SelectedIndex == 0) {
                setEndTimeOperationModel.MyType = SetEndTimeOperationModel.Type.ALL;
            }
            else if (cbType.SelectedIndex == 1)
            {
                setEndTimeOperationModel.MyType = SetEndTimeOperationModel.Type.END;
            }
            else if (cbType.SelectedIndex == 2)
            {
                setEndTimeOperationModel.MyType = SetEndTimeOperationModel.Type.ALLANDEND;
            }
        }

        public TextBox tbValue;
        public ComboBox cbType;

        public override bool ToSave() {
            if (tbValue.Text.Equals(String.Empty))
            {
                tbValue.Focus();
                return false;
            }
            setEndTimeOperationModel.Value = tbValue.Text;
            return true;
        }
    }
}
