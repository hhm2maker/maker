﻿using Maker.Business.Model;
using Maker.Business.Model.OperationModel;
using Maker.Model;
using Maker.View.LightScriptUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;

namespace Maker.View.UI.Style.Child
{
    public partial class ThirdPartyOperationChild : OperationStyle
    {
        public override string Title { get; set; } = "ThirdParty";
        private ThirdPartyOperationModel thirdPartyOperationModel;
        public ThirdPartyOperationChild(ThirdPartyOperationModel thirdPartyOperationModel, ScriptUserControl suc) : base(suc)
        {
            this.thirdPartyOperationModel = thirdPartyOperationModel;
            //构建对话框
            ThirdPartyModelsModel.ThirdPartyModel thirdPartyModel = new ThirdPartyModelsModel.ThirdPartyModel();
            for (int i = 0; i < StaticConstant.mw.projectUserControl.suc.thirdPartys.Count; i++) {
                if (StaticConstant.mw.projectUserControl.suc.thirdPartys[i].name.Equals(thirdPartyOperationModel.ThirdPartyName)) {
                    thirdPartyModel = StaticConstant.mw.projectUserControl.suc.thirdPartys[i];
                }
            }
            AddTitleAndControl("NameColon",GetTexeBlock(thirdPartyModel.text));
            
            String _viewFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\Operation\View\" + thirdPartyModel.view;//+ ".xml"
            XDocument doc = XDocument.Load(_viewFilePath);
            foreach (XElement element in doc.Element("Views").Elements())
            {
                AddTitleAndControl(element.Attribute("hint").Value, false,GetTexeBox(element.Attribute("default").Value));
            }
            CreateDialog();
            ///CreateDialog(200, 50 * UICount);

            //List<String> parameters = thirdPartyOperationModel.Parameters;

            //int position = 0;
            //for (int i = 0; i < _UI.Count; i++)
            //{
            //    if (_UI[i] is TextBox)
            //    {
            //        Console.WriteLine(parameters[position]);
            //        (_UI[i] as TextBox).Text = parameters[position];
            //        position++;
            //    }
            //}
            //thirdPartyOperationModel.Parameters = parameters;

            //String viewString = window.thirdPartys[window.iuc.miChildThirdParty.Items.IndexOf(sender)].view;
            //if (viewString.Equals(String.Empty))
            //{
            //    //不需要View
            //    for (int k = 0; k < window.iuc.lbStep.SelectedItems.Count; k++)
            //    {
            //        StackPanel sp = (StackPanel)window.iuc.lbStep.SelectedItems[k];
            //        //没有可操作的灯光组
            //        if (!window.iuc.lightScriptDictionary[window.iuc.GetStepName(sp)].Contains(window.iuc.GetStepName(sp) + "LightGroup"))
            //        {
            //            continue;
            //        }
            //        String command = String.Empty;
            //        command = Environment.NewLine + "\t" + window.iuc.GetStepName(sp) + "LightGroup = Edit." + window.thirdPartys[window.iuc.miChildThirdParty.Items.IndexOf(sender)].name + "(" + window.iuc.GetStepName(sp) + "LightGroup);";
            //        window.iuc.lightScriptDictionary[window.iuc.GetStepName(sp)] += command;
            //    }
            //    window.iuc.RefreshData();
            //}
            //else
            //{
            //    ThirdPartyDialog dialog = new ThirdPartyDialog(window, viewString);
            //    if (window.strMyLanguage.Equals("en-US"))
            //    {
            //        dialog.Title = window.thirdPartys[window.iuc.miChildThirdParty.Items.IndexOf(sender)].entext;
            //    }
            //    else if (window.strMyLanguage.Equals("zh-CN"))
            //    {
            //        dialog.Title = window.thirdPartys[window.iuc.miChildThirdParty.Items.IndexOf(sender)].zhtext;
            //    }
            //    if (dialog.ShowDialog() == true)
            //    {
            //        for (int k = 0; k < window.iuc.lbStep.SelectedItems.Count; k++)
            //        {
            //            StackPanel sp = (StackPanel)window.iuc.lbStep.SelectedItems[k];
            //            //没有可操作的灯光组
            //            if (!window.iuc.lightScriptDictionary[window.iuc.GetStepName(sp)].Contains(window.iuc.GetStepName(sp) + "LightGroup"))
            //            {
            //                continue;
            //            }
            //            String command = Environment.NewLine + "\t" + window.iuc.GetStepName(sp) + "LightGroup = Edit." + window.thirdPartys[window.iuc.miChildThirdParty.Items.IndexOf(sender)].name + "(" + window.iuc.GetStepName(sp) + "LightGroup" + dialog.result + ");";
            //            window.iuc.lightScriptDictionary[window.iuc.GetStepName(sp)] += command;
            //        }
            //        window.iuc.RefreshData();
            //    }
            //}

            //tbStart.Text = interceptTimeOperationModel.Start.ToString();
            //tbEnd.Text = interceptTimeOperationModel.End.ToString();
        }


        public override bool ToSave() {
            List<String> parameters = new List<string>();
            for (int i = 0; i < _UI.Count; i++) {
                if (_UI[i] is TextBox) {
                    if ((_UI[i] as TextBox).Text.Equals(String.Empty)) {
                        (_UI[i] as TextBox).Focus();
                        return false;
                    }
                    parameters.Add((_UI[i] as TextBox).Text);
                }
            }
            thirdPartyOperationModel.Parameters = parameters;
            return true;
        }

       
    }
}
