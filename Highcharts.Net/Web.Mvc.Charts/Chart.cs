using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Chart : BaseObject
	{
		public bool? AlignTicks
		{
			get;
			set;
		}

		private bool? AlignTicks_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Animation Animation
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Animation Animation_DefaultValue
		{
			get;
			set;
		}

		public string BackgroundColor
		{
			get;
			set;
		}

		private string BackgroundColor_DefaultValue
		{
			get;
			set;
		}

		public string BorderColor
		{
			get;
			set;
		}

		private string BorderColor_DefaultValue
		{
			get;
			set;
		}

		public double? BorderRadius
		{
			get;
			set;
		}

		private double? BorderRadius_DefaultValue
		{
			get;
			set;
		}

		public double? BorderWidth
		{
			get;
			set;
		}

		private double? BorderWidth_DefaultValue
		{
			get;
			set;
		}

		public string ClassName
		{
			get;
			set;
		}

		private string ClassName_DefaultValue
		{
			get;
			set;
		}

		public double? ColorCount
		{
			get;
			set;
		}

		private double? ColorCount_DefaultValue
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		private string Description_DefaultValue
		{
			get;
			set;
		}

		public ChartEvents Events
		{
			get;
			set;
		}

		private ChartEvents Events_DefaultValue
		{
			get;
			set;
		}

		public string Height
		{
			get;
			set;
		}

		private string Height_DefaultValue
		{
			get;
			set;
		}

		public bool? IgnoreHiddenSeries
		{
			get;
			set;
		}

		private bool? IgnoreHiddenSeries_DefaultValue
		{
			get;
			set;
		}

		public bool? Inverted
		{
			get;
			set;
		}

		private bool? Inverted_DefaultValue
		{
			get;
			set;
		}

		public string[] Margin
		{
			get;
			set;
		}

		private string[] Margin_DefaultValue
		{
			get;
			set;
		}

		public double? MarginBottom
		{
			get;
			set;
		}

		private double? MarginBottom_DefaultValue
		{
			get;
			set;
		}

		public double? MarginLeft
		{
			get;
			set;
		}

		private double? MarginLeft_DefaultValue
		{
			get;
			set;
		}

		public double? MarginRight
		{
			get;
			set;
		}

		private double? MarginRight_DefaultValue
		{
			get;
			set;
		}

		public double? MarginTop
		{
			get;
			set;
		}

		private double? MarginTop_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3d Options3d
		{
			get;
			set;
		}

		private ChartOptions3d Options3d_DefaultValue
		{
			get;
			set;
		}

		public ChartPanKey PanKey
		{
			get;
			set;
		}

		private ChartPanKey PanKey_DefaultValue
		{
			get;
			set;
		}

		public bool? Panning
		{
			get;
			set;
		}

		private bool? Panning_DefaultValue
		{
			get;
			set;
		}

		public ChartPinchType PinchType
		{
			get;
			set;
		}

		private ChartPinchType PinchType_DefaultValue
		{
			get;
			set;
		}

		public string PlotBackgroundColor
		{
			get;
			set;
		}

		private string PlotBackgroundColor_DefaultValue
		{
			get;
			set;
		}

		public string PlotBackgroundImage
		{
			get;
			set;
		}

		private string PlotBackgroundImage_DefaultValue
		{
			get;
			set;
		}

		public string PlotBorderColor
		{
			get;
			set;
		}

		private string PlotBorderColor_DefaultValue
		{
			get;
			set;
		}

		public double? PlotBorderWidth
		{
			get;
			set;
		}

		private double? PlotBorderWidth_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Shadow PlotShadow
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Shadow PlotShadow_DefaultValue
		{
			get;
			set;
		}

		public bool? Polar
		{
			get;
			set;
		}

		private bool? Polar_DefaultValue
		{
			get;
			set;
		}

		public bool? Reflow
		{
			get;
			set;
		}

		private bool? Reflow_DefaultValue
		{
			get;
			set;
		}

		public string RenderTo
		{
			get;
			set;
		}

		private string RenderTo_DefaultValue
		{
			get;
			set;
		}

		public ChartResetZoomButton ResetZoomButton
		{
			get;
			set;
		}

		private ChartResetZoomButton ResetZoomButton_DefaultValue
		{
			get;
			set;
		}

		public string SelectionMarkerFill
		{
			get;
			set;
		}

		private string SelectionMarkerFill_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Shadow Shadow
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Shadow Shadow_DefaultValue
		{
			get;
			set;
		}

		public bool? ShowAxes
		{
			get;
			set;
		}

		private bool? ShowAxes_DefaultValue
		{
			get;
			set;
		}

		public double? SpacingBottom
		{
			get;
			set;
		}

		private double? SpacingBottom_DefaultValue
		{
			get;
			set;
		}

		public double? SpacingLeft
		{
			get;
			set;
		}

		private double? SpacingLeft_DefaultValue
		{
			get;
			set;
		}

		public double? SpacingRight
		{
			get;
			set;
		}

		private double? SpacingRight_DefaultValue
		{
			get;
			set;
		}

		public double? SpacingTop
		{
			get;
			set;
		}

		private double? SpacingTop_DefaultValue
		{
			get;
			set;
		}

		public Hashtable Style
		{
			get;
			set;
		}

		private Hashtable Style_DefaultValue
		{
			get;
			set;
		}

		public ChartType Type
		{
			get;
			set;
		}

		private ChartType Type_DefaultValue
		{
			get;
			set;
		}

		public string TypeDescription
		{
			get;
			set;
		}

		private string TypeDescription_DefaultValue
		{
			get;
			set;
		}

		public double? Width
		{
			get;
			set;
		}

		private double? Width_DefaultValue
		{
			get;
			set;
		}

		public ChartZoomType ZoomType
		{
			get;
			set;
		}

		private ChartZoomType ZoomType_DefaultValue
		{
			get;
			set;
		}

		public Chart()
		{
			bool? nullable = new bool?(true);
			this.AlignTicks_DefaultValue = nullable;
			this.AlignTicks = nullable;
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			string str = "#FFFFFF";
			string str1 = str;
			this.BackgroundColor_DefaultValue = str;
			this.BackgroundColor = str1;
			string str2 = "#335cad";
			str1 = str2;
			this.BorderColor_DefaultValue = str2;
			this.BorderColor = str1;
			double? nullable1 = new double?(0);
			this.BorderRadius_DefaultValue = nullable1;
			this.BorderRadius = nullable1;
			nullable1 = new double?(0);
			this.BorderWidth_DefaultValue = nullable1;
			this.BorderWidth = nullable1;
			object obj = null;
			str1 = (string)obj;
			this.ClassName_DefaultValue = (string)obj;
			this.ClassName = str1;
			nullable1 = new double?((double)10);
			this.ColorCount_DefaultValue = nullable1;
			this.ColorCount = nullable1;
			string str3 = "undefined";
			str1 = str3;
			this.Description_DefaultValue = str3;
			this.Description = str1;
			ChartEvents chartEvent = new ChartEvents();
			ChartEvents chartEvent1 = chartEvent;
			this.Events_DefaultValue = chartEvent;
			this.Events = chartEvent1;
			string str4 = "null";
			str1 = str4;
			this.Height_DefaultValue = str4;
			this.Height = str1;
			nullable = new bool?(true);
			this.IgnoreHiddenSeries_DefaultValue = nullable;
			this.IgnoreHiddenSeries = nullable;
			nullable = new bool?(false);
			this.Inverted_DefaultValue = nullable;
			this.Inverted = nullable;
			string[] strArrays = new string[0];
			string[] strArrays1 = strArrays;
			this.Margin_DefaultValue = strArrays;
			this.Margin = strArrays1;
			nullable1 = null;
			this.MarginBottom_DefaultValue = nullable1;
			this.MarginBottom = nullable1;
			nullable1 = null;
			this.MarginLeft_DefaultValue = nullable1;
			this.MarginLeft = nullable1;
			nullable1 = null;
			this.MarginRight_DefaultValue = nullable1;
			this.MarginRight = nullable1;
			nullable1 = null;
			this.MarginTop_DefaultValue = nullable1;
			this.MarginTop = nullable1;
			ChartOptions3d chartOptions3d = new ChartOptions3d();
			ChartOptions3d chartOptions3d1 = chartOptions3d;
			this.Options3d_DefaultValue = chartOptions3d;
			this.Options3d = chartOptions3d1;
			int num = 0;
			ChartPanKey chartPanKey = (ChartPanKey)num;
			this.PanKey_DefaultValue = (ChartPanKey)num;
			this.PanKey = chartPanKey;
			nullable = new bool?(false);
			this.Panning_DefaultValue = nullable;
			this.Panning = nullable;
			int num1 = 0;
			ChartPinchType chartPinchType = (ChartPinchType)num1;
			this.PinchType_DefaultValue = (ChartPinchType)num1;
			this.PinchType = chartPinchType;
			object obj1 = null;
			str1 = (string)obj1;
			this.PlotBackgroundColor_DefaultValue = (string)obj1;
			this.PlotBackgroundColor = str1;
			object obj2 = null;
			str1 = (string)obj2;
			this.PlotBackgroundImage_DefaultValue = (string)obj2;
			this.PlotBackgroundImage = str1;
			string str5 = "#cccccc";
			str1 = str5;
			this.PlotBorderColor_DefaultValue = str5;
			this.PlotBorderColor = str1;
			nullable1 = new double?(0);
			this.PlotBorderWidth_DefaultValue = nullable1;
			this.PlotBorderWidth = nullable1;
			Highsoft.Web.Mvc.Charts.Shadow shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow1 = shadow;
			Highsoft.Web.Mvc.Charts.Shadow shadow2 = shadow1;
			this.PlotShadow_DefaultValue = shadow1;
			this.PlotShadow = shadow2;
			nullable = new bool?(false);
			this.Polar_DefaultValue = nullable;
			this.Polar = nullable;
			nullable = new bool?(true);
			this.Reflow_DefaultValue = nullable;
			this.Reflow = nullable;
			object obj3 = null;
			str1 = (string)obj3;
			this.RenderTo_DefaultValue = (string)obj3;
			this.RenderTo = str1;
			ChartResetZoomButton chartResetZoomButton = new ChartResetZoomButton();
			ChartResetZoomButton chartResetZoomButton1 = chartResetZoomButton;
			this.ResetZoomButton_DefaultValue = chartResetZoomButton;
			this.ResetZoomButton = chartResetZoomButton1;
			string str6 = "rgba(51,92,173,0.25)";
			str1 = str6;
			this.SelectionMarkerFill_DefaultValue = str6;
			this.SelectionMarkerFill = str1;
			shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow3 = shadow;
			shadow2 = shadow3;
			this.Shadow_DefaultValue = shadow3;
			this.Shadow = shadow2;
			nullable = new bool?(false);
			this.ShowAxes_DefaultValue = nullable;
			this.ShowAxes = nullable;
			nullable1 = new double?((double)15);
			this.SpacingBottom_DefaultValue = nullable1;
			this.SpacingBottom = nullable1;
			nullable1 = new double?((double)10);
			this.SpacingLeft_DefaultValue = nullable1;
			this.SpacingLeft = nullable1;
			nullable1 = new double?((double)10);
			this.SpacingRight_DefaultValue = nullable1;
			this.SpacingRight = nullable1;
			nullable1 = new double?((double)10);
			this.SpacingTop_DefaultValue = nullable1;
			this.SpacingTop = nullable1;
			Hashtable hashtables = new Hashtable()
			{
				{ "fontFamily", "\"Lucida Grande\"},{ \"Lucida Sans Unicode\"},{ Verdana},{ Arial},{ Helvetica},{ sans-serif" },
				{ "fontSize", "12px" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.Style_DefaultValue = hashtables1;
			this.Style = hashtables2;
			int num2 = 0;
			ChartType chartType = (ChartType)num2;
			this.Type_DefaultValue = (ChartType)num2;
			this.Type = chartType;
			string str7 = "undefined";
			str1 = str7;
			this.TypeDescription_DefaultValue = str7;
			this.TypeDescription = str1;
			nullable1 = null;
			this.Width_DefaultValue = nullable1;
			this.Width = nullable1;
			int num3 = 0;
			ChartZoomType chartZoomType = (ChartZoomType)num3;
			this.ZoomType_DefaultValue = (ChartZoomType)num3;
			this.ZoomType = chartZoomType;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? alignTicks = this.AlignTicks;
			bool? alignTicksDefaultValue = this.AlignTicks_DefaultValue;
			if ((alignTicks.GetValueOrDefault() == alignTicksDefaultValue.GetValueOrDefault() ? alignTicks.HasValue != alignTicksDefaultValue.HasValue : true))
			{
				hashtables.Add("alignTicks", this.AlignTicks);
			}
			if (this.Animation.IsDirty())
			{
				hashtables.Add("animation", this.Animation.ToJSON());
			}
			if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
			{
				hashtables.Add("backgroundColor", this.BackgroundColor);
			}
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			double? borderRadius = this.BorderRadius;
			double? borderRadiusDefaultValue = this.BorderRadius_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("borderRadius", this.BorderRadius);
			}
			borderRadiusDefaultValue = this.BorderWidth;
			borderRadius = this.BorderWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
			}
			borderRadius = this.ColorCount;
			borderRadiusDefaultValue = this.ColorCount_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("colorCount", this.ColorCount);
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			if (this.Height != this.Height_DefaultValue)
			{
				hashtables.Add("height", this.Height);
			}
			alignTicksDefaultValue = this.IgnoreHiddenSeries;
			alignTicks = this.IgnoreHiddenSeries_DefaultValue;
			if ((alignTicksDefaultValue.GetValueOrDefault() == alignTicks.GetValueOrDefault() ? alignTicksDefaultValue.HasValue != alignTicks.HasValue : true))
			{
				hashtables.Add("ignoreHiddenSeries", this.IgnoreHiddenSeries);
			}
			alignTicks = this.Inverted;
			alignTicksDefaultValue = this.Inverted_DefaultValue;
			if ((alignTicks.GetValueOrDefault() == alignTicksDefaultValue.GetValueOrDefault() ? alignTicks.HasValue != alignTicksDefaultValue.HasValue : true))
			{
				hashtables.Add("inverted", this.Inverted);
			}
			if (this.Margin != this.Margin_DefaultValue)
			{
				hashtables.Add("margin", this.Margin);
			}
			borderRadiusDefaultValue = this.MarginBottom;
			borderRadius = this.MarginBottom_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("marginBottom", this.MarginBottom);
			}
			borderRadius = this.MarginLeft;
			borderRadiusDefaultValue = this.MarginLeft_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("marginLeft", this.MarginLeft);
			}
			borderRadiusDefaultValue = this.MarginRight;
			borderRadius = this.MarginRight_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("marginRight", this.MarginRight);
			}
			borderRadius = this.MarginTop;
			borderRadiusDefaultValue = this.MarginTop_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("marginTop", this.MarginTop);
			}
			if (this.Options3d.IsDirty())
			{
				hashtables.Add("options3d", this.Options3d.ToHashtable());
			}
			if (this.PanKey != this.PanKey_DefaultValue)
			{
				ChartPanKey panKey = this.PanKey;
				hashtables.Add("panKey", Highcharts.FirstCharacterToLower(panKey.ToString()));
			}
			alignTicksDefaultValue = this.Panning;
			alignTicks = this.Panning_DefaultValue;
			if ((alignTicksDefaultValue.GetValueOrDefault() == alignTicks.GetValueOrDefault() ? alignTicksDefaultValue.HasValue != alignTicks.HasValue : true))
			{
				hashtables.Add("panning", this.Panning);
			}
			if (this.PinchType != this.PinchType_DefaultValue)
			{
				ChartPinchType pinchType = this.PinchType;
				hashtables.Add("pinchType", Highcharts.FirstCharacterToLower(pinchType.ToString()));
			}
			if (this.PlotBackgroundColor != this.PlotBackgroundColor_DefaultValue)
			{
				hashtables.Add("plotBackgroundColor", this.PlotBackgroundColor);
			}
			if (this.PlotBackgroundImage != this.PlotBackgroundImage_DefaultValue)
			{
				hashtables.Add("plotBackgroundImage", this.PlotBackgroundImage);
			}
			if (this.PlotBorderColor != this.PlotBorderColor_DefaultValue)
			{
				hashtables.Add("plotBorderColor", this.PlotBorderColor);
			}
			borderRadiusDefaultValue = this.PlotBorderWidth;
			borderRadius = this.PlotBorderWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("plotBorderWidth", this.PlotBorderWidth);
			}
			if (this.PlotShadow.IsDirty())
			{
				hashtables.Add("plotShadow", this.PlotShadow.ToJSON());
			}
			alignTicks = this.Polar;
			alignTicksDefaultValue = this.Polar_DefaultValue;
			if ((alignTicks.GetValueOrDefault() == alignTicksDefaultValue.GetValueOrDefault() ? alignTicks.HasValue != alignTicksDefaultValue.HasValue : true))
			{
				hashtables.Add("polar", this.Polar);
			}
			alignTicksDefaultValue = this.Reflow;
			alignTicks = this.Reflow_DefaultValue;
			if ((alignTicksDefaultValue.GetValueOrDefault() == alignTicks.GetValueOrDefault() ? alignTicksDefaultValue.HasValue != alignTicks.HasValue : true))
			{
				hashtables.Add("reflow", this.Reflow);
			}
			if (this.RenderTo != this.RenderTo_DefaultValue)
			{
				hashtables.Add("renderTo", this.RenderTo);
			}
			if (this.ResetZoomButton.IsDirty())
			{
				hashtables.Add("resetZoomButton", this.ResetZoomButton.ToHashtable());
			}
			if (this.SelectionMarkerFill != this.SelectionMarkerFill_DefaultValue)
			{
				hashtables.Add("selectionMarkerFill", this.SelectionMarkerFill);
			}
			if (this.Shadow != this.Shadow_DefaultValue)
			{
				hashtables.Add("shadow", this.Shadow);
			}
			alignTicks = this.ShowAxes;
			alignTicksDefaultValue = this.ShowAxes_DefaultValue;
			if ((alignTicks.GetValueOrDefault() == alignTicksDefaultValue.GetValueOrDefault() ? alignTicks.HasValue != alignTicksDefaultValue.HasValue : true))
			{
				hashtables.Add("showAxes", this.ShowAxes);
			}
			borderRadius = this.SpacingBottom;
			borderRadiusDefaultValue = this.SpacingBottom_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("spacingBottom", this.SpacingBottom);
			}
			borderRadiusDefaultValue = this.SpacingLeft;
			borderRadius = this.SpacingLeft_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("spacingLeft", this.SpacingLeft);
			}
			borderRadius = this.SpacingRight;
			borderRadiusDefaultValue = this.SpacingRight_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("spacingRight", this.SpacingRight);
			}
			borderRadiusDefaultValue = this.SpacingTop;
			borderRadius = this.SpacingTop_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("spacingTop", this.SpacingTop);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			if (this.Type != this.Type_DefaultValue)
			{
				ChartType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			if (this.TypeDescription != this.TypeDescription_DefaultValue)
			{
				hashtables.Add("typeDescription", this.TypeDescription);
			}
			borderRadius = this.Width;
			borderRadiusDefaultValue = this.Width_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("width", this.Width);
			}
			if (this.ZoomType != this.ZoomType_DefaultValue)
			{
				ChartZoomType zoomType = this.ZoomType;
				hashtables.Add("zoomType", Highcharts.FirstCharacterToLower(zoomType.ToString()));
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = this.ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer()
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(this.ToHashtable()));
			return str;
		}
	}
}