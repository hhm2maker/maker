﻿using Maker.Business.Model.OperationModel;
using Maker.View.Control;
using Maker.View.Style.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Maker.View.Style
{
    /// <summary>
    /// StyleWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StyleWindow : Window
    {
        public StyleWindow(Window mw)
        {
            InitializeComponent();
            Owner = mw;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public String _Content {
            get;
            set;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //StringBuilder builder = new StringBuilder();
            //for (int i = 0;i<lbCatalog.Items.Count;i++) {
            //    CheckBox cb = (CheckBox)lbCatalog.Items[i];
            //    if (cb.IsChecked == true) {
            //        BaseChild child = (BaseChild)svMain.Children[i];
            //        String result = child.GetString(this, i);
            //        if (result == null)
            //        {
            //            return;
            //        }
            //        else {
            //            builder.Append(result);
            //        }
            //    }
            //}
            //_Content = builder.ToString();

            DialogResult = true;
        }



        private void lbCatalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            svMain.Children.Clear();
            if (lbCatalog.SelectedIndex == -1)
            {
                return;
            }
            else {
                BaseOperationModel baseOperationModel = operationModels[lbCatalog.SelectedIndex];
                    if (baseOperationModel is VerticalFlippingOperationModel)
                    {
                        svMain.Children.Add(new VerticalFlippingOperationChild());
                    }
                else if (baseOperationModel is HorizontalFlippingOperationModel)
                {
                    svMain.Children.Add(new HorizontalFlippingOperationChild());
                }
            }

            
        }
       private List<BaseOperationModel> operationModels;
        public void SetData(List<BaseOperationModel> operationModels)
        {
            this.operationModels = operationModels;

            foreach (var item in operationModels)
            {
                TextBlock box = new TextBlock
                {
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Color.FromArgb(255, 240, 240, 240))
                };
                box.MouseLeftButtonDown += Box_Click;
                lbCatalog.Items.Add(box);
                if (item is VerticalFlippingOperationModel)
                {
                    box.SetResourceReference(TextBlock.TextProperty, "VerticalFlipping");
                }
                else if (item is HorizontalFlippingOperationModel)
                {
                    box.SetResourceReference(TextBlock.TextProperty, "HorizontalFlipping");
                }
           
            }
            //String[] contents = content.Split(';');
            //   foreach (String str in contents)
            //   {
            //       if (str.Equals(String.Empty))
            //           continue;
            //       String[] strs = str.Split('=');
            //       String type = strs[0];
            //       String[] _contents = strs[1].Split(',');

            //       AddContent(type);
            //       CheckBox box = (CheckBox)lbCatalog.Items[lbCatalog.Items.Count - 1];
            //       box.IsChecked = true;

            //       BaseChild child = (BaseChild)svMain.Children[svMain.Children.Count - 1];
            //       child.SetString(_contents);
            //   }
            lbCatalog.SelectedIndex = 0;
         
        }

        private void AddContent(string type)
        {
            CheckBox box = new CheckBox
            {
                FontSize = 16,
                Foreground = new SolidColorBrush(Color.FromArgb(255, 240, 240, 240))
            };
            box.SetValue(CheckBox.StyleProperty, Application.Current.Resources["CheckBoxStyle1"]);
            //box.Width = 200;
            if (type.Equals("Color")) {
                box.SetResourceReference(CheckBox.ContentProperty, "Color");
                svMain.Children.Add(new ColorChild());
            }
            else if (type.Equals("Shape"))
            {
                box.SetResourceReference(CheckBox.ContentProperty, "Shape");
                svMain.Children.Add(new ShapeChild());
            }
            else if (type.Equals("Time"))
            {
                box.SetResourceReference(CheckBox.ContentProperty, "Time");
                svMain.Children.Add(new TimeChild());
            }
            else if (type.Equals("ColorOverlay"))
            {
                box.SetResourceReference(CheckBox.ContentProperty, "ColorSuperposition");
                svMain.Children.Add(new ColorOverlayChild());
            }
            else if (type.Equals("SportOverlay"))
            {
                box.SetResourceReference(CheckBox.ContentProperty, "AccelerationOrDeceleration");
                svMain.Children.Add(new SportOverlayChild());
            }
            else if (type.Equals("Other"))
            {
                box.SetResourceReference(CheckBox.ContentProperty, "Other");
                svMain.Children.Add(new OtherChild());
            }
            //box.Click += Box_Click;
            lbCatalog.Items.Add(box);
        }

        private void Box_Click(object sender, MouseButtonEventArgs e)
        {
            lbCatalog.SelectedItem = sender;
        }


        private void BtnRemoveFx_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lbCatalog.SelectedIndex == -1)
                return;
            int position = lbCatalog.SelectedIndex;
            lbCatalog.Items.RemoveAt(position);
            operationModels.RemoveAt(position);
            //svMain.Children.RemoveAt(position);
        }

        private void ImgUp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lbCatalog.SelectedIndex <= 0) {
                return;
            }
            else
            {
                int i = lbCatalog.SelectedIndex;

                List<CheckBox> checkboxs = new List<CheckBox>();
                foreach (Object o in lbCatalog.Items) {
                    checkboxs.Add((CheckBox)o);
                }

                lbCatalog.Items.Clear();

                CheckBox box = checkboxs[i-1];
                checkboxs[i-1]  = checkboxs[i];
                checkboxs[i] = box;

                foreach (CheckBox c in checkboxs) {
                    lbCatalog.Items.Add(c);
                }

                List<BaseChild> basechilds = new List<BaseChild>();
                foreach (Object o in svMain.Children)
                {
                    basechilds.Add((BaseChild)o);
                }

                svMain.Children.Clear();

                BaseChild child = basechilds[i - 1];
                basechilds[i - 1] = basechilds[i];
                basechilds[i] = child;

                foreach (BaseChild b in basechilds)
                {
                    svMain.Children.Add(b);
                }
                lbCatalog.SelectedIndex = i - 1;
            }
        }
        private void ImgDown_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lbCatalog.SelectedIndex == -1 || lbCatalog.SelectedIndex == lbCatalog.Items.Count-1)
            {
                return;
            }
            else
            {
                int i = lbCatalog.SelectedIndex;

                List<CheckBox> checkboxs = new List<CheckBox>();
                foreach (Object o in lbCatalog.Items)
                {
                    checkboxs.Add((CheckBox)o);
                }

                lbCatalog.Items.Clear();

                CheckBox box = checkboxs[i + 1];
                checkboxs[i + 1] = checkboxs[i];
                checkboxs[i] = box;

                foreach (CheckBox c in checkboxs)
                {
                    lbCatalog.Items.Add(c);
                }

                List<BaseChild> basechilds = new List<BaseChild>();
                foreach (Object o in svMain.Children)
                {
                    basechilds.Add((BaseChild)o);
                }

                svMain.Children.Clear();

                BaseChild child = basechilds[i + 1];
                basechilds[i + 1] = basechilds[i];
                basechilds[i] = child;

                foreach (BaseChild b in basechilds)
                {
                    svMain.Children.Add(b);
                }
                lbCatalog.SelectedIndex = i + 1;
            }
        }
    }
}
