using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace FormsComponentes
{
    partial class AbaTres
    {
        private IContainer components = null;
        private FlowLayoutPanel FlowLayoutPanel;

        // Calendário para selecionar (Ínicio e Fim)
        private Library.Label lb_MonthCalendar;
        private MonthCalendar mc_MonthCal;

        // Label e Busca na Web
        private Library.Label lbl_Web;
        private WebBrowser wb_ExWebBrowser;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.ClientSize = new Size(500, 550);
            this.Text = "FlowLP # 3";
            this.BackColor = ColorTranslator.FromHtml("#8f8caf");

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.FlowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            this.FlowLayoutPanel.Visible = true;

            // Label e MonthCalendar (Selecionar Ínicio e Fim)
            this.lb_MonthCalendar = new Library.Label();
            this.lb_MonthCalendar.Text = "MonthCalendar";
            this.FlowLayoutPanel.Controls.Add(this.lb_MonthCalendar);

            // Calendário p/ escolha de um período
            DateTime dt_DataLocacao = new DateTime(2020, 05, 16);
            this.mc_MonthCal = new MonthCalendar();
            this.mc_MonthCal.MaxSelectionCount = 10;
            this.mc_MonthCal.MinDate = new DateTime(2019, 01, 01);
            this.mc_MonthCal.MaxDate = new DateTime(2020, 12, 31);
            this.mc_MonthCal.SelectionRange = new SelectionRange(dt_DataLocacao, new DateTime(2020, 05, 19));
            this.FlowLayoutPanel.Controls.Add(this.mc_MonthCal);
            this.mc_MonthCal.Anchor = AnchorStyles.Top;

            // Label e WebBrowser
            this.lbl_Web = new Library.Label();
            this.lbl_Web.Text = "WebBrowser";
            this.FlowLayoutPanel.Controls.Add(this.lbl_Web);

            this.wb_ExWebBrowser = new WebBrowser();
            this.wb_ExWebBrowser.Size = new Size(480, 300);
            this.wb_ExWebBrowser.Navigate("https://github.com/KaduFloresta");
            this.FlowLayoutPanel.Controls.Add(this.wb_ExWebBrowser);
            this.wb_ExWebBrowser.Anchor = AnchorStyles.Bottom;
            this.wb_ExWebBrowser.TabIndex = 3;

            this.Controls.Add(this.FlowLayoutPanel);
        }
    }
}
