﻿using Maker.View.Control;
using Maker_IDE.Business;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Maker.View.Setting
{
    /// <summary>
    /// DeviceManagementWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DeviceManagementWindow : Window
    {
        private MainWindow mw;
        public DeviceManagementWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
            Owner = mw;
        }

        private void NewOrUpdateDevice(object sender, RoutedEventArgs e)
        {
            //NewOrUpdateDeviceWindow window;
            //if (sender == btnNewDevice)
            //{
            //    window = new NewOrUpdateDeviceWindow(mw, 0);
            //}
            //else
            //{
            //    if (lbMain.SelectedIndex == -1)
            //        return;
            //    window = new NewOrUpdateDeviceWindow(mw, 1);
            //    window.iniName = lbMain.SelectedItem.ToString();
            //}

            //if (window.ShowDialog() == true)
            //{
            //    LoadDeviceFile();
            //}
        }
        private void RunDevice(object sender, RoutedEventArgs e)
        {
            if (lbMain.SelectedIndex == -1)
            {
                return;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Device\" + lbMain.SelectedItem.ToString() + ".ini"))
            {
                if (mw.deviceDictionary.ContainsKey(lbMain.SelectedItem.ToString()))
                {
                    System.Windows.Forms.MessageBox.Show("该设备已经被打开了。");
                    mw.deviceDictionary[lbMain.SelectedItem.ToString()].Topmost = true;
                    return;
                }
                else
                {
                //    PlayerWindow pw = new PlayerWindow(mw);
                //    ConfigBusiness config = new ConfigBusiness(@"Device\" + lbMain.SelectedItem.ToString() + ".ini");
                //    if (config.Get("DeviceType").Trim().Equals("Launchpad Pro"))
                //    {

                //        String strBg = config.Get("DeviceBackGround");
                //        if (strBg.Equals(String.Empty))
                //        {
                //            System.Windows.Forms.MessageBox.Show("设置有误，无法启动播放器");
                //            return;
                //        }
                //        if (strBg[0] == '#' || strBg.Length == 7)
                //        {
                //            pw.playLpd.SetLaunchpadBackground(new SolidColorBrush((Color)ColorConverter.ConvertFromString(strBg)));
                //        }
                //        else
                //        {
                //            if (!File.Exists(strBg))
                //            {
                //                System.Windows.Forms.MessageBox.Show("设置有误，无法启动播放器");
                //                return;
                //            }
                //            else
                //            {
                //                ImageBrush b = new ImageBrush();
                //                b.ImageSource = new BitmapImage(new Uri(strBg, UriKind.Absolute));
                //                b.Stretch = Stretch.Fill;
                //                pw.playLpd.SetLaunchpadBackground(b);

                //            }
                //        }
                //        Double iDeviceSize = Convert.ToDouble(config.Get("DeviceSize"));
                //        pw.playLpd.SetSize(iDeviceSize);
                //        pw.SetSize(iDeviceSize, iDeviceSize + 31);
                //        pw.DeviceName = lbMain.SelectedItem.ToString();
                //        try
                //        {
                //            if (config.Get("IsMembrane").Equals("true"))
                //            {
                //                pw.playLpd.ToMembraneLaunchpad();
                //            }
                //        }
                //        catch
                //        {
                //        }
                //        pw.Show();
                //        mw.deviceDictionary.Add(lbMain.SelectedItem.ToString(), pw);
                //        ComboBoxItem item = new ComboBoxItem();
                //        mw.cbDevice.Items.Add(lbMain.SelectedItem.ToString());
                //        if (mw.cbDevice.SelectedIndex == -1)
                //        {
                //            mw.cbDevice.SelectedIndex = 0;
                //        }
                //    }
                }
            }
        }
        private void DeleteDevice(object sender, RoutedEventArgs e)
        {
            if (lbMain.SelectedIndex == -1)
            {
                return;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Device\" + lbMain.SelectedItem.ToString() + ".ini"))
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"Device\" + lbMain.SelectedItem.ToString() + ".ini");
            }
            if (mw.deviceDictionary.ContainsKey(lbMain.SelectedItem.ToString()))
            {
                try
                {
                    mw.deviceDictionary[lbMain.SelectedItem.ToString()].Close();
                }
                catch
                {
                }
                mw.deviceDictionary.Remove(lbMain.SelectedItem.ToString());
            }
            if (mw.cbDevice.Items.Contains(lbMain.SelectedItem.ToString()))
            {
                mw.cbDevice.Items.Remove(lbMain.SelectedItem.ToString());
            }
            lbMain.Items.Remove(lbMain.SelectedItem.ToString());
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDeviceFile();
        }
        private void LoadDeviceFile()
        {
            lbMain.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Device");
            foreach (FileInfo file in folder.GetFiles("*.ini"))
            {
                lbMain.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file.FullName));
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

    }
}
