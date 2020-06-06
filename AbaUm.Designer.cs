using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace FormsComponentes
{
    partial class AbaUm
    {
        private IContainer components = null;
        private TableLayoutPanel TableLayoutPanel;

        // Texto de Orientação 
        private ToolTip tt_Exemplo = new ToolTip();

        //Imagem da Janela
        private PictureBox pb_Imagem1;

        // Label e Texto "Rico" - Editado
        private Label lbl_Rich;
        private RichTextBox rtxt_RichTB;

        // Labels e NumericUpDown
        private Library.Label lbl_NumericUd;
        private Label lbl_ExUm;
        private Label lbl_ExDois;
        private Label lbl_ExTres;
        private NumericUpDown num_Numeric1;
        private NumericUpDown num_Numeric2;
        private NumericUpDown num_Numeric3;

        // Label e Texto com máscara de orientação
        private Library.Label lbl_Masked;
        private MaskedTextBox rtxt_Masked;

        // Label e ComboBox (Cascata)
        private Library.Label lbl_Combo;
        private ComboBox cb_Combo;

        // Linklabel - Link de acesso           
        private LinkLabel link_help;

        // Caixa GrupoBox e Seleção RadioButton (Apenas 1 opção)
        private Library.Label lbl_Radio;
        private Library.RadioButton rb_RadioUm;
        private Library.RadioButton rb_RadioDois;
        private Library.RadioButton rb_RadioTres;

        // Caixa GrupoBox e Seleção CheckBox (nenhuma, 1 ou mais opções)
        private Library.Label lbl_Check;
        private Library.CheckBox chk_Um;
        private Library.CheckBox chk_Dois;
        private Library.CheckBox chk_Tres;

        // GUIDE FOR LOCATION n SIZE (X Y) 
        // Location (X = Horizontal - Y = Vertical)
        // Size     (X = Largura    - Y = Altura)

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
            this.Text = "TableLP # 1";
            this.BackColor = ColorTranslator.FromHtml("#8f8caf");

            this.TableLayoutPanel = new TableLayoutPanel();
            this.TableLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.RowCount = 15;
            this.TableLayoutPanel.Dock = DockStyle.Fill;
            this.TableLayoutPanel.BackColor = ColorTranslator.FromHtml("#8f8caf");
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // PictureBox
            this.pb_Imagem1 = new PictureBox();
            this.pb_Imagem1.Size = new Size(460, 100);
            this.pb_Imagem1.ClientSize = new Size(460, 100);
            this.pb_Imagem1.Load("Imagem.jpg");
            this.pb_Imagem1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TableLayoutPanel.Controls.Add(this.pb_Imagem1, 0, 0);
            this.TableLayoutPanel.SetColumnSpan(pb_Imagem1, 3);
            this.pb_Imagem1.Anchor = AnchorStyles.None;

            // ToolTip - RichTextBox
            this.tt_Exemplo.AutoPopDelay = 10000;
            this.tt_Exemplo.InitialDelay = 100;
            this.tt_Exemplo.ReshowDelay = 500;
            this.tt_Exemplo.ShowAlways = true;

            // Label e RichTextBox
            this.lbl_Rich = new Library.Label();
            this.lbl_Rich.Text = "RichTextBox";
            this.TableLayoutPanel.Controls.Add(this.lbl_Rich, 0, 1);

            this.rtxt_RichTB = new RichTextBox();
            this.rtxt_RichTB.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
            this.rtxt_RichTB.SelectionColor = System.Drawing.Color.Blue;
            this.rtxt_RichTB.Font = new Font(rtxt_RichTB.Font, FontStyle.Bold);
            this.rtxt_RichTB.Size = new Size(300, 20);
            this.tt_Exemplo.SetToolTip(rtxt_RichTB, "Informe o nome");
            this.TableLayoutPanel.Controls.Add(this.rtxt_RichTB, 1, 1);
            this.TableLayoutPanel.SetColumnSpan(rtxt_RichTB, 2);
            this.rtxt_RichTB.Anchor = AnchorStyles.None;

            // Label e NumericUpDown
            this.lbl_NumericUd = new Library.Label();
            this.lbl_NumericUd.Text = "NumericUpDown: ";
            this.TableLayoutPanel.Controls.Add(this.lbl_NumericUd, 0, 3);

            this.lbl_ExUm = new Label();
            this.lbl_ExUm.Text = "Ex.: 2 Digitos";
            this.lbl_ExUm.Font = new Font(lbl_ExUm.Font, FontStyle.Bold);
            this.lbl_ExUm.ForeColor = Color.Red;
            this.TableLayoutPanel.Controls.Add(this.lbl_ExUm, 1, 3);
            this.lbl_ExUm.Anchor = AnchorStyles.None;

            // Seleção de números - Casa 1
            this.num_Numeric1 = new NumericUpDown();
            this.num_Numeric1.ForeColor = Color.Black;
            this.num_Numeric1.Minimum = 1;
            this.num_Numeric1.Maximum = 99;
            this.TableLayoutPanel.Controls.Add(this.num_Numeric1, 2, 3);

            this.lbl_ExDois = new Label();
            this.lbl_ExDois.Text = "Ex.: 3 Digitos";
            this.lbl_ExDois.Font = new Font(lbl_ExDois.Font, FontStyle.Bold);
            this.lbl_ExDois.ForeColor = Color.Red;
            this.TableLayoutPanel.Controls.Add(this.lbl_ExDois, 1, 4);
            this.lbl_ExDois.Anchor = AnchorStyles.None;

            // Seleção de números - Casa 2
            this.num_Numeric2 = new NumericUpDown();
            this.num_Numeric2.ForeColor = Color.Black;
            this.num_Numeric2.Minimum = 100;
            this.num_Numeric2.Maximum = 999;
            this.TableLayoutPanel.Controls.Add(this.num_Numeric2, 2, 4);

            this.lbl_ExTres = new Label();
            this.lbl_ExTres.Text = "Ex.: 4 Digitos";
            this.lbl_ExTres.Font = new Font(lbl_ExTres.Font, FontStyle.Bold);
            this.lbl_ExTres.ForeColor = Color.Red;
            this.TableLayoutPanel.Controls.Add(this.lbl_ExTres, 1, 5);
            this.lbl_ExTres.Anchor = AnchorStyles.None;

            // Seleção de números - Casa 3
            this.num_Numeric3 = new NumericUpDown();
            this.num_Numeric3.ForeColor = Color.Black;
            this.num_Numeric3.Minimum = 1000;
            this.num_Numeric3.Maximum = 9999;
            this.TableLayoutPanel.Controls.Add(this.num_Numeric3, 3, 5);

            // Label e MaskedTextBox
            this.lbl_Masked = new Library.Label();
            this.lbl_Masked.Text = "MaskedTextBox";
            this.TableLayoutPanel.Controls.Add(this.lbl_Masked, 0, 7);

            this.rtxt_Masked = new MaskedTextBox();
            this.rtxt_Masked.Mask = "(00) 00000 - 0000";
            this.rtxt_Masked.Size = new Size(150, 20);
            this.rtxt_Masked.Font = new Font(rtxt_Masked.Font, FontStyle.Bold);
            this.rtxt_Masked.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.rtxt_Masked, 1, 7);

            this.lbl_Combo = new Library.Label();
            this.lbl_Combo.Text = "ComboBox";
            this.lbl_Combo.AutoSize = true;
            this.TableLayoutPanel.Controls.Add(this.lbl_Combo, 0, 9);

            // ComboBox - Seleção Cascata
            this.cb_Combo = new ComboBox();
            this.cb_Combo.Items.Add("Ítem A");
            this.cb_Combo.Items.Add("Ítem B");
            this.cb_Combo.Items.Add("Ítem C");
            this.cb_Combo.Items.Add("Ítem D");
            this.cb_Combo.Items.Add("Ítem E");
            this.cb_Combo.AutoCompleteMode = AutoCompleteMode.Append;
            this.cb_Combo.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.cb_Combo, 1, 9);

            // Label e RadioButton
            this.lbl_Radio = new Library.Label();
            this.lbl_Radio.Text = "RadioButton";
            this.TableLayoutPanel.Controls.Add(this.lbl_Radio, 0, 11);
            this.lbl_Radio.Anchor = AnchorStyles.None;

            this.rb_RadioUm = new Library.RadioButton();
            this.rb_RadioUm.Text = "Ítem - 1";
            this.TableLayoutPanel.Controls.Add(this.rb_RadioUm, 0, 12);

            this.rb_RadioDois = new Library.RadioButton();
            this.rb_RadioDois.Text = "Ítem - 2";
            this.TableLayoutPanel.Controls.Add(this.rb_RadioDois, 0, 13);

            this.rb_RadioTres = new Library.RadioButton();
            this.rb_RadioTres.Text = "Ítem - 3";
            this.TableLayoutPanel.Controls.Add(this.rb_RadioTres, 0, 14);

            // LinkLabel - Link de acesso
            this.link_help = new System.Windows.Forms.LinkLabel();
            this.link_help.AutoSize = true;
            this.link_help.Font = new Font(link_help.Font, FontStyle.Bold);
            this.link_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkForHelp_LinkClicked);
            this.link_help.Text = "Ajuda com LinkLabel";
            this.TableLayoutPanel.Controls.AddRange(new System.Windows.Forms.Control[] { this.link_help });
            this.TableLayoutPanel.Controls.Add(this.link_help, 1, 13);
            this.link_help.Anchor = AnchorStyles.None;

            // Label e CheckBox - Múltiplas escolhas
            this.lbl_Check = new Library.Label();
            this.lbl_Check.Text = "CheckBox";
            this.TableLayoutPanel.Controls.Add(this.lbl_Check, 2, 11);
            this.lbl_Check.Anchor = AnchorStyles.None;

            this.chk_Um = new Library.CheckBox();
            this.chk_Um.Text = "Opção - X";
            this.TableLayoutPanel.Controls.Add(this.chk_Um, 2, 12);

            this.chk_Dois = new Library.CheckBox();
            this.chk_Dois.Text = "Opção - Y";
            this.TableLayoutPanel.Controls.Add(this.chk_Dois, 2, 13);

            this.chk_Tres = new Library.CheckBox();
            this.chk_Tres.Text = "Opção - Z";
            this.TableLayoutPanel.Controls.Add(this.chk_Tres, 2, 14);

            this.Controls.Add(this.TableLayoutPanel);
        }
    }
}