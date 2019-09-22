using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Legend : BaseObject
	{
		public LegendAlign Align
		{
			get;
			set;
		}

		private LegendAlign Align_DefaultValue
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

		public bool? Enabled
		{
			get;
			set;
		}

		private bool? Enabled_DefaultValue
		{
			get;
			set;
		}

		public bool? Floating
		{
			get;
			set;
		}

		private bool? Floating_DefaultValue
		{
			get;
			set;
		}

		public double? ItemDistance
		{
			get;
			set;
		}

		private double? ItemDistance_DefaultValue
		{
			get;
			set;
		}

		public Hashtable ItemHiddenStyle
		{
			get;
			set;
		}

		private Hashtable ItemHiddenStyle_DefaultValue
		{
			get;
			set;
		}

		public Hashtable ItemHoverStyle
		{
			get;
			set;
		}

		private Hashtable ItemHoverStyle_DefaultValue
		{
			get;
			set;
		}

		public double? ItemMarginBottom
		{
			get;
			set;
		}

		private double? ItemMarginBottom_DefaultValue
		{
			get;
			set;
		}

		public double? ItemMarginTop
		{
			get;
			set;
		}

		private double? ItemMarginTop_DefaultValue
		{
			get;
			set;
		}

		public Hashtable ItemStyle
		{
			get;
			set;
		}

		private Hashtable ItemStyle_DefaultValue
		{
			get;
			set;
		}

		public double? ItemWidth
		{
			get;
			set;
		}

		private double? ItemWidth_DefaultValue
		{
			get;
			set;
		}

		public string LabelFormat
		{
			get;
			set;
		}

		private string LabelFormat_DefaultValue
		{
			get;
			set;
		}

		public string LabelFormatter
		{
			get;
			set;
		}

		private string LabelFormatter_DefaultValue
		{
			get;
			set;
		}

		public LegendLayout Layout
		{
			get;
			set;
		}

		private LegendLayout Layout_DefaultValue
		{
			get;
			set;
		}

		public double? LineHeight
		{
			get;
			set;
		}

		private double? LineHeight_DefaultValue
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

		public double? MaxHeight
		{
			get;
			set;
		}

		private double? MaxHeight_DefaultValue
		{
			get;
			set;
		}

		public LegendNavigation Navigation
		{
			get;
			set;
		}

		private LegendNavigation Navigation_DefaultValue
		{
			get;
			set;
		}

		public double? Padding
		{
			get;
			set;
		}

		private double? Padding_DefaultValue
		{
			get;
			set;
		}

		public bool? Reversed
		{
			get;
			set;
		}

		private bool? Reversed_DefaultValue
		{
			get;
			set;
		}

		public bool? Rtl
		{
			get;
			set;
		}

		private bool? Rtl_DefaultValue
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

		public bool? SquareSymbol
		{
			get;
			set;
		}

		private bool? SquareSymbol_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolHeight
		{
			get;
			set;
		}

		private double? SymbolHeight_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolPadding
		{
			get;
			set;
		}

		private double? SymbolPadding_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolRadius
		{
			get;
			set;
		}

		private double? SymbolRadius_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolWidth
		{
			get;
			set;
		}

		private double? SymbolWidth_DefaultValue
		{
			get;
			set;
		}

		public LegendTitle Title
		{
			get;
			set;
		}

		private LegendTitle Title_DefaultValue
		{
			get;
			set;
		}

		public bool? UseHTML
		{
			get;
			set;
		}

		private bool? UseHTML_DefaultValue
		{
			get;
			set;
		}

		public LegendVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private LegendVerticalAlign VerticalAlign_DefaultValue
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

		public double? X
		{
			get;
			set;
		}

		private double? X_DefaultValue
		{
			get;
			set;
		}

		public double? Y
		{
			get;
			set;
		}

		private double? Y_DefaultValue
		{
			get;
			set;
		}

		public Legend()
		{
			int num = 1;
			LegendAlign legendAlign = (LegendAlign)num;
			this.Align_DefaultValue = (LegendAlign)num;
			this.Align = legendAlign;
			object obj = null;
			string str = (string)obj;
			this.BackgroundColor_DefaultValue = (string)obj;
			this.BackgroundColor = str;
			string str1 = "#999999";
			str = str1;
			this.BorderColor_DefaultValue = str1;
			this.BorderColor = str;
			double? nullable = new double?(0);
			this.BorderRadius_DefaultValue = nullable;
			this.BorderRadius = nullable;
			nullable = new double?(0);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			bool? nullable1 = new bool?(true);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			nullable1 = new bool?(false);
			this.Floating_DefaultValue = nullable1;
			this.Floating = nullable1;
			nullable = new double?((double)20);
			this.ItemDistance_DefaultValue = nullable;
			this.ItemDistance = nullable;
			Hashtable hashtables = new Hashtable()
			{
				{ "color", "#cccccc" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.ItemHiddenStyle_DefaultValue = hashtables1;
			this.ItemHiddenStyle = hashtables2;
			hashtables = new Hashtable()
			{
				{ "color", "#000000" }
			};
			Hashtable hashtables3 = hashtables;
			hashtables2 = hashtables3;
			this.ItemHoverStyle_DefaultValue = hashtables3;
			this.ItemHoverStyle = hashtables2;
			nullable = new double?(0);
			this.ItemMarginBottom_DefaultValue = nullable;
			this.ItemMarginBottom = nullable;
			nullable = new double?(0);
			this.ItemMarginTop_DefaultValue = nullable;
			this.ItemMarginTop = nullable;
			hashtables = new Hashtable()
			{
				{ "color", "#333333" },
				{ "cursor", "pointer" },
				{ "fontSize", "12px" },
				{ "fontWeight", "bold" }
			};
			Hashtable hashtables4 = hashtables;
			hashtables2 = hashtables4;
			this.ItemStyle_DefaultValue = hashtables4;
			this.ItemStyle = hashtables2;
			nullable = null;
			this.ItemWidth_DefaultValue = nullable;
			this.ItemWidth = nullable;
			string str2 = "{name}";
			str = str2;
			this.LabelFormat_DefaultValue = str2;
			this.LabelFormat = str;
			string str3 = "";
			str = str3;
			this.LabelFormatter_DefaultValue = str3;
			this.LabelFormatter = str;
			int num1 = 0;
			LegendLayout legendLayout = (LegendLayout)num1;
			this.Layout_DefaultValue = (LegendLayout)num1;
			this.Layout = legendLayout;
			nullable = new double?((double)16);
			this.LineHeight_DefaultValue = nullable;
			this.LineHeight = nullable;
			string[] strArrays = new string[0];
			string[] strArrays1 = strArrays;
			this.Margin_DefaultValue = strArrays;
			this.Margin = strArrays1;
			nullable = null;
			this.MaxHeight_DefaultValue = nullable;
			this.MaxHeight = nullable;
			LegendNavigation legendNavigation = new LegendNavigation();
			LegendNavigation legendNavigation1 = legendNavigation;
			this.Navigation_DefaultValue = legendNavigation;
			this.Navigation = legendNavigation1;
			nullable = new double?((double)8);
			this.Padding_DefaultValue = nullable;
			this.Padding = nullable;
			nullable1 = new bool?(false);
			this.Reversed_DefaultValue = nullable1;
			this.Reversed = nullable1;
			nullable1 = new bool?(false);
			this.Rtl_DefaultValue = nullable1;
			this.Rtl = nullable1;
			Highsoft.Web.Mvc.Charts.Shadow shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow1 = shadow;
			this.Shadow_DefaultValue = shadow;
			this.Shadow = shadow1;
			nullable1 = new bool?(true);
			this.SquareSymbol_DefaultValue = nullable1;
			this.SquareSymbol = nullable1;
			nullable = null;
			this.SymbolHeight_DefaultValue = nullable;
			this.SymbolHeight = nullable;
			nullable = new double?((double)5);
			this.SymbolPadding_DefaultValue = nullable;
			this.SymbolPadding = nullable;
			nullable = null;
			this.SymbolRadius_DefaultValue = nullable;
			this.SymbolRadius = nullable;
			nullable = null;
			this.SymbolWidth_DefaultValue = nullable;
			this.SymbolWidth = nullable;
			LegendTitle legendTitle = new LegendTitle();
			LegendTitle legendTitle1 = legendTitle;
			this.Title_DefaultValue = legendTitle;
			this.Title = legendTitle1;
			nullable1 = new bool?(false);
			this.UseHTML_DefaultValue = nullable1;
			this.UseHTML = nullable1;
			int num2 = 2;
			LegendVerticalAlign legendVerticalAlign = (LegendVerticalAlign)num2;
			this.VerticalAlign_DefaultValue = (LegendVerticalAlign)num2;
			this.VerticalAlign = legendVerticalAlign;
			nullable = null;
			this.Width_DefaultValue = nullable;
			this.Width = nullable;
			nullable = new double?(0);
			this.X_DefaultValue = nullable;
			this.X = nullable;
			nullable = new double?(0);
			this.Y_DefaultValue = nullable;
			this.Y = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Align != this.Align_DefaultValue)
			{
				LegendAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
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
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			enabledDefaultValue = this.Floating;
			enabled = this.Floating_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("floating", this.Floating);
			}
			borderRadius = this.ItemDistance;
			borderRadiusDefaultValue = this.ItemDistance_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("itemDistance", this.ItemDistance);
			}
			if (this.ItemHiddenStyle != this.ItemHiddenStyle_DefaultValue)
			{
				hashtables.Add("itemHiddenStyle", this.ItemHiddenStyle);
			}
			if (this.ItemHoverStyle != this.ItemHoverStyle_DefaultValue)
			{
				hashtables.Add("itemHoverStyle", this.ItemHoverStyle);
			}
			borderRadiusDefaultValue = this.ItemMarginBottom;
			borderRadius = this.ItemMarginBottom_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("itemMarginBottom", this.ItemMarginBottom);
			}
			borderRadius = this.ItemMarginTop;
			borderRadiusDefaultValue = this.ItemMarginTop_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("itemMarginTop", this.ItemMarginTop);
			}
			if (this.ItemStyle != this.ItemStyle_DefaultValue)
			{
				hashtables.Add("itemStyle", this.ItemStyle);
			}
			borderRadiusDefaultValue = this.ItemWidth;
			borderRadius = this.ItemWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("itemWidth", this.ItemWidth);
			}
			if (this.LabelFormat != this.LabelFormat_DefaultValue)
			{
				hashtables.Add("labelFormat", this.LabelFormat);
			}
			if (this.LabelFormatter != this.LabelFormatter_DefaultValue)
			{
				hashtables.Add("labelFormatter", this.LabelFormatter);
				Highcharts.AddFunction("LegendLabelFormatter.labelFormatter", this.LabelFormatter);
			}
			if (this.Layout != this.Layout_DefaultValue)
			{
				LegendLayout layout = this.Layout;
				hashtables.Add("layout", Highcharts.FirstCharacterToLower(layout.ToString()));
			}
			borderRadius = this.LineHeight;
			borderRadiusDefaultValue = this.LineHeight_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("lineHeight", this.LineHeight);
			}
			if (this.Margin != this.Margin_DefaultValue)
			{
				hashtables.Add("margin", this.Margin);
			}
			borderRadiusDefaultValue = this.MaxHeight;
			borderRadius = this.MaxHeight_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("maxHeight", this.MaxHeight);
			}
			if (this.Navigation.IsDirty())
			{
				hashtables.Add("navigation", this.Navigation.ToHashtable());
			}
			borderRadius = this.Padding;
			borderRadiusDefaultValue = this.Padding_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("padding", this.Padding);
			}
			enabled = this.Reversed;
			enabledDefaultValue = this.Reversed_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("reversed", this.Reversed);
			}
			enabledDefaultValue = this.Rtl;
			enabled = this.Rtl_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("rtl", this.Rtl);
			}
			if (this.Shadow != this.Shadow_DefaultValue)
			{
				hashtables.Add("shadow", this.Shadow);
			}
			enabled = this.SquareSymbol;
			enabledDefaultValue = this.SquareSymbol_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("squareSymbol", this.SquareSymbol);
			}
			borderRadiusDefaultValue = this.SymbolHeight;
			borderRadius = this.SymbolHeight_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("symbolHeight", this.SymbolHeight);
			}
			borderRadius = this.SymbolPadding;
			borderRadiusDefaultValue = this.SymbolPadding_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("symbolPadding", this.SymbolPadding);
			}
			borderRadiusDefaultValue = this.SymbolRadius;
			borderRadius = this.SymbolRadius_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("symbolRadius", this.SymbolRadius);
			}
			borderRadius = this.SymbolWidth;
			borderRadiusDefaultValue = this.SymbolWidth_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("symbolWidth", this.SymbolWidth);
			}
			if (this.Title.IsDirty())
			{
				hashtables.Add("title", this.Title.ToHashtable());
			}
			enabledDefaultValue = this.UseHTML;
			enabled = this.UseHTML_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				LegendVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			borderRadiusDefaultValue = this.Width;
			borderRadius = this.Width_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("width", this.Width);
			}
			borderRadius = this.X;
			borderRadiusDefaultValue = this.X_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			borderRadiusDefaultValue = this.Y;
			borderRadius = this.Y_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("y", this.Y);
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