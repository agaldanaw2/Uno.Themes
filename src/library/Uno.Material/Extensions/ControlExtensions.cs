﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

#if WinUI
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Controls;
#else
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Controls;
#endif

namespace Uno.Material
{
	[Bindable]
	public static class ControlExtensions
	{
		#region DependencyProperty: Icon

		public static DependencyProperty IconProperty { [DynamicDependency(nameof(GetIcon))] get; } = DependencyProperty.RegisterAttached(
			"Icon",
			typeof(IconElement),
			typeof(ControlExtensions),
			new PropertyMetadata(default));

		[DynamicDependency(nameof(SetIcon))]
		public static IconElement GetIcon(Control obj) => (IconElement)obj.GetValue(IconProperty);

		[DynamicDependency(nameof(GetIcon))]
		public static void SetIcon(Control obj, IconElement value) => obj.SetValue(IconProperty, value);
#endregion

#region DependencyProperty: IconHeight
		public static DependencyProperty IconHeightProperty { [DynamicDependency(nameof(GetIconHeight))] get; } = DependencyProperty.RegisterAttached(
			"IconHeight",
			typeof(double),
			typeof(ControlExtensions),
			new PropertyMetadata(Double.NaN));

		[DynamicDependency(nameof(SetIconHeight))]
		public static double GetIconHeight(Control obj) => (double)obj.GetValue(IconHeightProperty);
		[DynamicDependency(nameof(GetIconHeight))]
		public static void SetIconHeight(Control obj, double value) => obj.SetValue(IconHeightProperty, value);
#endregion

#region DependencyProperty: IconWidth 
		public static DependencyProperty IconWidthProperty { [DynamicDependency(nameof(GetIconWidth))]  get; } = DependencyProperty.RegisterAttached(
			"IconWidth",
			typeof(double),
			typeof(ControlExtensions),
			new PropertyMetadata(Double.NaN));

		[DynamicDependency(nameof(SetIconWidth))]
		public static double GetIconWidth(Control obj) => (double)obj.GetValue(IconWidthProperty);
		[DynamicDependency(nameof(GetIconWidth))]
		public static void SetIconWidth(Control obj, double value) => obj.SetValue(IconWidthProperty, value);

#endregion

#region DependencyProperty: AlternateContent

		public static DependencyProperty AlternateContentProperty { [DynamicDependency(nameof(GetAlternateContent))]  get; } = DependencyProperty.RegisterAttached(
			"AlternateContent",
			typeof(object),
			typeof(ControlExtensions),
			new PropertyMetadata(default(object)));

		[DynamicDependency(nameof(SetAlternateContent))]
		public static object GetAlternateContent(Control obj) => (object)obj.GetValue(AlternateContentProperty);
		[DynamicDependency(nameof(GetAlternateContent))]
		public static void SetAlternateContent(Control obj, object value) => obj.SetValue(AlternateContentProperty, value);

#endregion
	}
}
