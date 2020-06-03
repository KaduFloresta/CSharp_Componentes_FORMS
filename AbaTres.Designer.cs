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
        private Label lb_MonthCalendar;
        private MonthCalendar mc_MonthCal;

        // Label e Busca na Web
        private Label lbl_Web;
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
            this.BackColor = ColorTranslator.FromHtml("#0fe3ef");

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.FlowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            this.FlowLayoutPanel.Visible = true;

            // Label e MonthCalendar (Selecionar Ínicio e Fim)
            lb_MonthCalendar = new Label();
            lb_MonthCalendar.Text = "MonthCalendar";
            lb_MonthCalendar.Size = new Size(100, 30);
            lb_MonthCalendar.Font = new Font(lb_MonthCalendar.Font, FontStyle.Bold);
            this.FlowLayoutPanel.Controls.Add(this.lb_MonthCalendar);
            lb_MonthCalendar.Anchor = AnchorStyles.None;

            // Calendário p/ escolha de um período
            DateTime dt_DataLocacao = new DateTime(2020, 05, 16);
            mc_MonthCal = new MonthCalendar();
            mc_MonthCal.MaxSelectionCount = 10;
            mc_MonthCal.MinDate = new DateTime(2019, 01, 01);
            mc_MonthCal.MaxDate = new DateTime(2020, 12, 31);
            mc_MonthCal.SelectionRange = new SelectionRange(dt_DataLocacao, new DateTime(2020, 05, 19));
            this.FlowLayoutPanel.Controls.Add(this.mc_MonthCal);
            mc_MonthCal.Anchor = AnchorStyles.Top;

            // Label e WebBrowser
            lbl_Web = new Label();
            lbl_Web.Text = "WebBrowser";
            lbl_Web.AutoSize = true;
            lbl_Web.Font = new Font(lbl_Web.Font, FontStyle.Bold);
            lbl_Web.ForeColor = Color.Black;
            this.FlowLayoutPanel.Controls.Add(this.lbl_Web);
            lbl_Web.Anchor = AnchorStyles.None;

            wb_ExWebBrowser = new WebBrowser();
            wb_ExWebBrowser.Size = new Size(480, 200);
            wb_ExWebBrowser.Navigate("https://www.google.com");
            this.FlowLayoutPanel.Controls.Add(this.wb_ExWebBrowser);

            this.Controls.Add(this.FlowLayoutPanel);
        }
    }
}
