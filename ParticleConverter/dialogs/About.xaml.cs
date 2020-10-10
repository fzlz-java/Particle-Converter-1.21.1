﻿using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;

namespace ParticleConverter.dialogs
{
    /// <summary>
    /// About.xaml の相互作用ロジック
    /// </summary>
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            var fullname = typeof(App).Assembly.Location;
            var info = System.Diagnostics.FileVersionInfo.GetVersionInfo(fullname);
            var ver = info.FileVersion;
            Version.Text = ver;
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var tb = (TextBlock)sender;
            var ps = new ProcessStartInfo(tb.Text)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}
