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
    public partial class AbaUm : TabPage
    {
        public AbaUm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento LinkLabel - Acesso á página de web
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkForHelp_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to open link that was clicked.");
            }
        }

        /// <summary>
        /// Método VisitLink - Acesso á página de web
        /// </summary>
        private void VisitLink()
        {
            this.link_help.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe",
            "https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.linklabel.linkclicked?view=netcore-3.1");
        }
    }
}

