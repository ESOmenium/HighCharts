using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Data : BaseObject
	{
		public List<List<object>> Columns
		{
			get;
			set;
		}

		private List<List<object>> Columns_DefaultValue
		{
			get;
			set;
		}

		public string Complete
		{
			get;
			set;
		}

		private string Complete_DefaultValue
		{
			get;
			set;
		}

		public string Csv
		{
			get;
			set;
		}

		private string Csv_DefaultValue
		{
			get;
			set;
		}

		public string DateFormat
		{
			get;
			set;
		}

		private string DateFormat_DefaultValue
		{
			get;
			set;
		}

		public string DecimalPoint
		{
			get;
			set;
		}

		private string DecimalPoint_DefaultValue
		{
			get;
			set;
		}

		public double? EndColumn
		{
			get;
			set;
		}

		private double? EndColumn_DefaultValue
		{
			get;
			set;
		}

		public double? EndRow
		{
			get;
			set;
		}

		private double? EndRow_DefaultValue
		{
			get;
			set;
		}

		public bool? FirstRowAsNames
		{
			get;
			set;
		}

		private bool? FirstRowAsNames_DefaultValue
		{
			get;
			set;
		}

		public string GoogleSpreadsheetKey
		{
			get;
			set;
		}

		private string GoogleSpreadsheetKey_DefaultValue
		{
			get;
			set;
		}

		public string GoogleSpreadsheetWorksheet
		{
			get;
			set;
		}

		private string GoogleSpreadsheetWorksheet_DefaultValue
		{
			get;
			set;
		}

		public string ItemDelimiter
		{
			get;
			set;
		}

		private string ItemDelimiter_DefaultValue
		{
			get;
			set;
		}

		public string LineDelimiter
		{
			get;
			set;
		}

		private string LineDelimiter_DefaultValue
		{
			get;
			set;
		}

		public string Parsed
		{
			get;
			set;
		}

		private string Parsed_DefaultValue
		{
			get;
			set;
		}

		public string ParseDate
		{
			get;
			set;
		}

		private string ParseDate_DefaultValue
		{
			get;
			set;
		}

		public List<List<object>> Rows
		{
			get;
			set;
		}

		private List<List<object>> Rows_DefaultValue
		{
			get;
			set;
		}

		public List<object> SeriesMapping
		{
			get;
			set;
		}

		private List<object> SeriesMapping_DefaultValue
		{
			get;
			set;
		}

		public double? StartColumn
		{
			get;
			set;
		}

		private double? StartColumn_DefaultValue
		{
			get;
			set;
		}

		public double? StartRow
		{
			get;
			set;
		}

		private double? StartRow_DefaultValue
		{
			get;
			set;
		}

		public bool? SwitchRowsAndColumns
		{
			get;
			set;
		}

		private bool? SwitchRowsAndColumns_DefaultValue
		{
			get;
			set;
		}

		public string Table
		{
			get;
			set;
		}

		private string Table_DefaultValue
		{
			get;
			set;
		}

		public Data()
		{
			List<List<object>> lists = new List<List<object>>();
			List<List<object>> lists1 = lists;
			this.Columns_DefaultValue = lists;
			this.Columns = lists1;
			string str = "";
			string str1 = str;
			this.Complete_DefaultValue = str;
			this.Complete = str1;
			object obj = null;
			str1 = (string)obj;
			this.Csv_DefaultValue = (string)obj;
			this.Csv = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.DateFormat_DefaultValue = (string)obj1;
			this.DateFormat = str1;
			string str2 = ".";
			str1 = str2;
			this.DecimalPoint_DefaultValue = str2;
			this.DecimalPoint = str1;
			double? nullable = null;
			this.EndColumn_DefaultValue = nullable;
			this.EndColumn = nullable;
			nullable = null;
			this.EndRow_DefaultValue = nullable;
			this.EndRow = nullable;
			bool? nullable1 = new bool?(true);
			this.FirstRowAsNames_DefaultValue = nullable1;
			this.FirstRowAsNames = nullable1;
			string str3 = "";
			str1 = str3;
			this.GoogleSpreadsheetKey_DefaultValue = str3;
			this.GoogleSpreadsheetKey = str1;
			object obj2 = null;
			str1 = (string)obj2;
			this.GoogleSpreadsheetWorksheet_DefaultValue = (string)obj2;
			this.GoogleSpreadsheetWorksheet = str1;
			string str4 = "";
			str1 = str4;
			this.ItemDelimiter_DefaultValue = str4;
			this.ItemDelimiter = str1;
			string str5 = "\n";
			str1 = str5;
			this.LineDelimiter_DefaultValue = str5;
			this.LineDelimiter = str1;
			string str6 = "";
			str1 = str6;
			this.ParseDate_DefaultValue = str6;
			this.ParseDate = str1;
			string str7 = "";
			str1 = str7;
			this.Parsed_DefaultValue = str7;
			this.Parsed = str1;
			List<List<object>> lists2 = new List<List<object>>();
			lists1 = lists2;
			this.Rows_DefaultValue = lists2;
			this.Rows = lists1;
			List<object> objs = new List<object>();
			List<object> objs1 = objs;
			this.SeriesMapping_DefaultValue = objs;
			this.SeriesMapping = objs1;
			nullable = new double?(0);
			this.StartColumn_DefaultValue = nullable;
			this.StartColumn = nullable;
			nullable = new double?(0);
			this.StartRow_DefaultValue = nullable;
			this.StartRow = nullable;
			nullable1 = new bool?(false);
			this.SwitchRowsAndColumns_DefaultValue = nullable1;
			this.SwitchRowsAndColumns = nullable1;
			string str8 = "";
			str1 = str8;
			this.Table_DefaultValue = str8;
			this.Table = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Columns != this.Columns_DefaultValue)
			{
				hashtables.Add("columns", this.Columns);
			}
			if (this.Complete != this.Complete_DefaultValue)
			{
				hashtables.Add("complete", this.Complete);
				Highcharts.AddFunction("DataComplete.complete", this.Complete);
			}
			if (this.Csv != this.Csv_DefaultValue)
			{
				hashtables.Add("csv", this.Csv);
			}
			if (this.DateFormat != this.DateFormat_DefaultValue)
			{
				hashtables.Add("dateFormat", this.DateFormat);
			}
			if (this.DecimalPoint != this.DecimalPoint_DefaultValue)
			{
				hashtables.Add("decimalPoint", this.DecimalPoint);
			}
			double? endColumn = this.EndColumn;
			double? endColumnDefaultValue = this.EndColumn_DefaultValue;
			if ((endColumn.GetValueOrDefault() == endColumnDefaultValue.GetValueOrDefault() ? endColumn.HasValue != endColumnDefaultValue.HasValue : true))
			{
				hashtables.Add("endColumn", this.EndColumn);
			}
			endColumnDefaultValue = this.EndRow;
			endColumn = this.EndRow_DefaultValue;
			if ((endColumnDefaultValue.GetValueOrDefault() == endColumn.GetValueOrDefault() ? endColumnDefaultValue.HasValue != endColumn.HasValue : true))
			{
				hashtables.Add("endRow", this.EndRow);
			}
			bool? firstRowAsNames = this.FirstRowAsNames;
			bool? firstRowAsNamesDefaultValue = this.FirstRowAsNames_DefaultValue;
			if ((firstRowAsNames.GetValueOrDefault() == firstRowAsNamesDefaultValue.GetValueOrDefault() ? firstRowAsNames.HasValue != firstRowAsNamesDefaultValue.HasValue : true))
			{
				hashtables.Add("firstRowAsNames", this.FirstRowAsNames);
			}
			if (this.GoogleSpreadsheetKey != this.GoogleSpreadsheetKey_DefaultValue)
			{
				hashtables.Add("googleSpreadsheetKey", this.GoogleSpreadsheetKey);
			}
			if (this.GoogleSpreadsheetWorksheet != this.GoogleSpreadsheetWorksheet_DefaultValue)
			{
				hashtables.Add("googleSpreadsheetWorksheet", this.GoogleSpreadsheetWorksheet);
			}
			if (this.ItemDelimiter != this.ItemDelimiter_DefaultValue)
			{
				hashtables.Add("itemDelimiter", this.ItemDelimiter);
			}
			if (this.LineDelimiter != this.LineDelimiter_DefaultValue)
			{
				hashtables.Add("lineDelimiter", this.LineDelimiter);
			}
			if (this.ParseDate != this.ParseDate_DefaultValue)
			{
				hashtables.Add("parseDate", this.ParseDate);
				Highcharts.AddFunction("DataParseDate.parseDate", this.ParseDate);
			}
			if (this.Parsed != this.Parsed_DefaultValue)
			{
				hashtables.Add("parsed", this.Parsed);
				Highcharts.AddFunction("DataParsed.parsed", this.Parsed);
			}
			if (this.Rows != this.Rows_DefaultValue)
			{
				hashtables.Add("rows", this.Rows);
			}
			if (this.SeriesMapping != this.SeriesMapping_DefaultValue)
			{
				hashtables.Add("seriesMapping", this.SeriesMapping);
			}
			endColumn = this.StartColumn;
			endColumnDefaultValue = this.StartColumn_DefaultValue;
			if ((endColumn.GetValueOrDefault() == endColumnDefaultValue.GetValueOrDefault() ? endColumn.HasValue != endColumnDefaultValue.HasValue : true))
			{
				hashtables.Add("startColumn", this.StartColumn);
			}
			endColumnDefaultValue = this.StartRow;
			endColumn = this.StartRow_DefaultValue;
			if ((endColumnDefaultValue.GetValueOrDefault() == endColumn.GetValueOrDefault() ? endColumnDefaultValue.HasValue != endColumn.HasValue : true))
			{
				hashtables.Add("startRow", this.StartRow);
			}
			firstRowAsNamesDefaultValue = this.SwitchRowsAndColumns;
			firstRowAsNames = this.SwitchRowsAndColumns_DefaultValue;
			if ((firstRowAsNamesDefaultValue.GetValueOrDefault() == firstRowAsNames.GetValueOrDefault() ? firstRowAsNamesDefaultValue.HasValue != firstRowAsNames.HasValue : true))
			{
				hashtables.Add("switchRowsAndColumns", this.SwitchRowsAndColumns);
			}
			if (this.Table != this.Table_DefaultValue)
			{
				hashtables.Add("table", this.Table);
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