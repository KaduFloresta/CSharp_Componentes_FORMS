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
            MessageBox.Show(
                $"{abaUm.GetInfo()}" +
                $"{abaDois.GetInfo()}" +
                $"{abaTres.GetInfo()}" +
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