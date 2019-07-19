﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using SampleControl.Presentation;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Toolkit.VisibleBoundsPadding
{
	[SampleControlInfo("Toolkit", nameof(VisibleBoundsPadding_ListView))]
	public sealed partial class VisibleBoundsPadding_ListView : UserControl
	{
		public VisibleBoundsPadding_ListView()
		{
			this.InitializeComponent();
		}

		private void ShowTitleBar(object sender, RoutedEventArgs e)
		{
			SampleChooserViewModel.Instance.ShowHideTitleBarCommand.Execute(true);
		}

		private void HideTitleBar(object sender, RoutedEventArgs e)
		{
			SampleChooserViewModel.Instance.ShowHideTitleBarCommand.Execute(false);
		}
	}
}
