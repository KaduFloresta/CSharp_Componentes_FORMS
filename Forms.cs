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
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento MessageBox - Botão NEW do submenu do MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowNewMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New!!!!");
        }

        /// <summary>
        /// Evento MessageBox - Botão SAVE do submenu do MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowSaveMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save!!!!");
        }

        /// <summary>
        /// Botão de Confirmar - MessageBox dados inseridos e seleções do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ConfirmarClick(object sender, EventArgs e)
        {
            string filmes = "";
            string promocoes = "";
            string pagtos = "";

            // foreach (string filme in lb_ListBox.SelectedItems)
            //     filmes += " " + filme;

            // foreach (ListViewItem promocao in lv_ListView.SelectedItems)
            //     promocoes += " " + promocao.Text;

            // foreach (string pagto in clb_CheckedLB.CheckedItems)
            //     pagtos += " " + pagto;

            MessageBox.Show(
                // $"Nome:> {rtxt_Nome.Text}\n" +
                // $"Data Nascimento:> {num_Numeric1.Value + "/" + num_Numeric2.Value + "/" + num_Numeric3.Value}\n" +
                // $"C.P.F.:> {rtxt_Masked.Text}\n" +
                // $"Dias Devolução:> {cb_Combo.Text}\n" +
                // $"Tipo CLiente:> {(this.rb_RadioUm.Checked == true ? "CLIENTE BASICO" : this.rb_RadioDois.Checked ? "CLIENTE REGULAR" : this.rb_RadioTres.Checked ? "CLIENTE PREMIUM" : "")}\n" +
                // $"NewLetter:> {(this.chk_Um.Checked == true ? "SMS -" : "")}" +
                // $" {(this.chk_Dois.Checked == true ? "E-mail -" : "")}" +
                // $" {(this.chk_Tres.Checked == true ? "WhatsApp" : "")}\n" +
                // $"Especial Inicio:> {this.mc_MonthCal.SelectionRange.Start}\n" +
                // $"Especial Final:> {this.mc_MonthCal.SelectionRange.End}\n" +
                // $"Data Locação:> {this.dp_DataTP.Value}\n" +
                $"Filmes:> {filmes}\n" +
                $"Promoção:> {promocoes}\n" +
                $"Forma de Pagto:> {pagtos}\n",
                "Cliente",
                MessageBoxButtons.OK
            );
        }

        /// <summary>
        /// Botão de Cancelar (Sair) do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}