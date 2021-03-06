﻿using Maker.Model;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Maker.View
{
    public class ColorPanel : ListBox
    {
        public ColorPanel(){
            Create(8);
        }

        public ColorPanel(int size){
            Create(size);
        }

        private void Create(int size) {
            Background = new SolidColorBrush(Colors.Transparent);

            //Style = (System.Windows.Style)FindResource("ListBoxStyle1");//TabItemStyle 这个样式是引用的资源文件中的样式名称
            FrameworkElementFactory factory = new FrameworkElementFactory(typeof(UniformGrid));
            factory.SetValue(UniformGrid.ColumnsProperty, size);
            ItemsPanelTemplate itemsPanelTemplate = new ItemsPanelTemplate(factory);
            ItemsPanel = itemsPanelTemplate;
            for (int i = 0; i < StaticConstant.brushList.Count; i++)
            {
                Border border = new Border()
                {
                    CornerRadius = new CornerRadius(3),
                    BorderThickness = new Thickness(3),
                    Height = 25,
                    Width = 25,
                };
                ListBoxItem item = new ListBoxItem
                {
                    Padding = new Thickness(0),
                    BorderThickness = new Thickness(0),
                    Content = border,
                    Height = 29,
                    Width = 29,
                    HorizontalContentAlignment = HorizontalAlignment.Left,
                    VerticalContentAlignment = VerticalAlignment.Top,
                };
                border.BorderBrush = StaticConstant.brushList[i];
                border.Background = new SolidColorBrush(Color.FromArgb(200,
                    StaticConstant.brushList[i].Color.R,
                    StaticConstant.brushList[i].Color.G,
                    StaticConstant.brushList[i].Color.B));
                Items.Add(item);
            }
        }

        public void HideText() {
            foreach(var item in Items) {
                (item as ListBoxItem).Content = String.Empty;
            }
        }

        public void ToSmall() {
            Items.Clear();
            FrameworkElementFactory factory = new FrameworkElementFactory(typeof(UniformGrid));
            factory.SetValue(UniformGrid.ColumnsProperty, 8);
            ItemsPanelTemplate itemsPanelTemplate = new ItemsPanelTemplate(factory);
            ItemsPanel = itemsPanelTemplate;
            for (int i = 0; i < StaticConstant.brushList.Count; i++)
            {
                ListBoxItem item = new ListBoxItem
                {
                    //Content = i.ToString(),
                    Height = 20,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                       VerticalContentAlignment = VerticalAlignment.Center
                };
                if (i != 0)
                {
                    item.Background = StaticConstant.brushList[i - 1];
                }
                else
                {
                    item.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F4F4F5"));
                }
                Items.Add(item);
            }
        }
    }
}
