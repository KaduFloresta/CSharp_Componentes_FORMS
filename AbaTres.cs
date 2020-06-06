using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace FormsComponentes
{
    public partial class AbaTres : TabPage
    {
        public AbaTres()
        {
            InitializeComponent();
        }

        public string GetInfo()
        {
            return
                $"MonthCalendar Inicio:> {this.mc_MonthCal.SelectionRange.Start}\n" +
                $"MonthCalendar Final:> {this.mc_MonthCal.SelectionRange.End}\n";
        }
    }
}