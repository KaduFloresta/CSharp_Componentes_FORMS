using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FormsComponentes
{
    public partial class AbaDois : TabPage
    {
        public AbaDois()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método CheckedListBox - Laço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clb_CheckedLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clb_CheckedLB.Items.Count; i++)
                if (i != e.Index) clb_CheckedLB.SetItemChecked(i, false);
        }

        /// <summary>
        /// Evento Scroll do TrackBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_ExTrackBar_Scroll(object sender, EventArgs e)
        { // Display the trackbar value in the text box. 
            tb_TrackBar.Text = "" + tb_ExTrackBar.Value;
        }

        /// <summary>
        /// Evento OpenFile - Abrir conteúdo (txt)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OpenFileClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // dialog.InitialDirectory = @"C:\";
            // dialog.Multiselect = true;
            // dialog.Title = "Selecionar arquivos...";
            // dialog.Filter = "Arquivo de Texto (*.TXT; *.RTF) |abrirarquivo.txt";
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                StreamReader arquivo = new StreamReader(dialog.FileName);
                string conteudo = arquivo.ReadLine();
                arquivo.Dispose();

                MessageBox.Show(conteudo);
            }
        }

        private void Btn_TesteErro_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[a-zA-Z]+$");
            if (!r.IsMatch(this.txt_ErrorBox.Text))
            {
                this.TextError.SetError(this.txt_ErrorBox, "SOMENTE LETRAS!");
            }
            else
            {
                this.TextError.SetError(this.txt_ErrorBox, String.Empty);
            }
        }
    }
}