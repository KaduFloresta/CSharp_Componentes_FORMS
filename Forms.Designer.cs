using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace FormsComponentes
{
    partial class Forms : Form
    {
        private IContainer components = null;
        private TabControl tabControl;
        // Botões de decisões da janela
        private Button btn_Confirmar;
        private Button btn_Cancelar;

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
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = ColorTranslator.FromHtml("#0fe3ef");
            this.ClientSize = new Size(500, 640);
            this.Text = "Principal";

            // Controle das Abas
            this.tabControl = new TabControl();
            this.tabControl.Size = new Size(500, 550);
            this.tabControl.Location = new Point(0, 20);

            // Abas  #1, #2 e #3
            TabPage abaUm = new AbaUm();
            TabPage abaDois = new AbaDois();
            TabPage abaTres = new AbaTres();

            // Adicionando Abas
            this.tabControl.Controls.Add(abaUm);
            this.tabControl.Controls.Add(abaDois);
            this.tabControl.Controls.Add(abaTres);
            this.Controls.Add(this.tabControl);

            // MenuStrip - Botão de Acesso ou Funções
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
            ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(windowNewMenu_Click));
            ToolStripMenuItem windowSaveMenu = new ToolStripMenuItem("Save", null, new EventHandler(windowSaveMenu_Click));
            windowSaveMenu.Click += new EventHandler(windowSaveMenu_Click);
            ms.MdiWindowListItem = windowMenu;
            windowMenu.DropDownItems.Add(windowNewMenu);
            windowMenu.DropDownItems.Add(windowSaveMenu);
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

            // Assign the ToolStripMenuItem that displays the list of child forms.
            ms.MdiWindowListItem = windowMenu;

            // Add the window ToolStripMenuItem to the MenuStrip.
            ms.Items.Add(windowMenu);

            // The Form.MainMenuStrip property determines the merge target.
            ms.Dock = DockStyle.Top;

            // The Form.MainMenuStrip property determines the merge target.
            this.MainMenuStrip = ms;

            // Add the ToolStripPanels to the form in reverse order.            
            //this.Controls.Add(tspTop);

            // Add the MenuStrip last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);

            // Botões de decisões
            btn_Confirmar = new Button();
            btn_Confirmar.Text = "CONFIRMAR";
            btn_Confirmar.Location = new Point(70, 580);
            btn_Confirmar.Size = new Size(150, 40);
            this.btn_Confirmar.BackColor = ColorTranslator.FromHtml("#4e4786");
            this.btn_Confirmar.Font = new Font(btn_Confirmar.Font, FontStyle.Bold);
            this.btn_Confirmar.ForeColor = Color.White;
            btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(this.btn_Confirmar);
            btn_Confirmar.Anchor = AnchorStyles.None;

            btn_Cancelar = new Button();
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.Location = new Point(260, 580);
            btn_Cancelar.Size = new Size(150, 40);
            this.btn_Cancelar.BackColor = ColorTranslator.FromHtml("#4e4786");
            this.btn_Cancelar.Font = new Font(btn_Cancelar.Font, FontStyle.Bold);
            this.btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(this.btn_Cancelar);
            btn_Cancelar.Anchor = AnchorStyles.None;
        }
    }
}