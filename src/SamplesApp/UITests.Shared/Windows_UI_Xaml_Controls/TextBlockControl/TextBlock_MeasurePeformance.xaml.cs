﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace UITests.Shared.Windows_UI_Xaml_Controls.TextBlockControl
{
	[SampleControlInfo("TextBlockControl", "MeasurePerformance", ignoreInAutomatedTests: true)]
	public sealed partial class TextBlock_MeasurePeformance : UserControl
	{
		public TextBlock_MeasurePeformance()
		{
			this.InitializeComponent();
		}

		private void Bench_TextMeasure_SameText()
		{
			var sw = Stopwatch.StartNew();

			for (int i = 0; i < 300; i++)
			{
				var tb = new TextBlock { Text = "42" };
				tb.Measure(new Size(100, 100));
			}

			result1.Text = sw.Elapsed;
		}
	}
}