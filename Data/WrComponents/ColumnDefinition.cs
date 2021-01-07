using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Woorj.Data.WrComponents
{
    public class ColumnDefinition
    {
        public ColumnDefinition()
        {
            this.DataType = DataType.NotSet;
            this.Alignment = Alignment.NotSet;
            this.SortDirection = SortDirection.NotSet;
            this.LinkAddress="";
            this.SelectedField="";
            this.SelectedFieldKey="";
        }

        public string DataField { get; set; }
        public string Caption { get; set; }
        public DataType DataType { get; set; }
        public string LinkAddress { get; set; }
        public string SelectedField { get; set; }
        public string SelectedFieldKey { get; set; }
        public string Format { get; set; }
        public Alignment Alignment { get; set; }
        public SortDirection SortDirection { get; set; }

        public string MinWidth { get; set; }
        public string MaxWidth { get; set; }
    }
}
