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

        // Controle de Abas
        // private TabControl tc_LabControl;
        // private TabPage tp_PageOne;
        // private TabPage tp_PageTwo;

        // Texto de Orientação 
        private ToolTip tt_Exemplo = new ToolTip();

        //Imagem da Janela
        private PictureBox pb_Imagem1;

        // Label e Texto "Rico" - Editado
        private Label lbl_Rich;
        private RichTextBox rtxt_RichTB;

        // Labels e NumericUpDown
        private Label lbl_NumericUd;
        private Label lbl_ExUm;
        private Label lbl_ExDois;
        private Label lbl_ExTres;
        private NumericUpDown num_Numeric1;
        private NumericUpDown num_Numeric2;
        private NumericUpDown num_Numeric3;

        // Label e Texto com máscara de orientação
        private Label lbl_Masked;
        private MaskedTextBox rtxt_Masked;

        // Label e ComboBox (Cascata)
        private Label lbl_Combo;
        private ComboBox cb_Combo;

        // Linklabel - Link de acesso           
        private LinkLabel link_help;

        // Caixa GrupoBox e Seleção RadioButton (Apenas 1 opção)
        private Label lbl_Radio;
        private RadioButton rb_RadioUm;
        private RadioButton rb_RadioDois;
        private RadioButton rb_RadioTres;

        // Caixa GrupoBox e Seleção CheckBox (nenhuma, 1 ou mais opções)
        private Label lbl_Check;
        private CheckBox chk_Um;
        private CheckBox chk_Dois;
        private CheckBox chk_Tres;

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
            this.BackColor = ColorTranslator.FromHtml("#0fe3ef");

            this.TableLayoutPanel = new TableLayoutPanel();
            this.TableLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.RowCount = 10;
            this.TableLayoutPanel.Dock = DockStyle.Fill;
            this.TableLayoutPanel.BackColor = ColorTranslator.FromHtml("#0fe3ef");
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
            this.TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // PictureBox
            pb_Imagem1 = new PictureBox();
            pb_Imagem1.Size = new Size(460, 100);
            pb_Imagem1.ClientSize = new Size(460, 100);
            pb_Imagem1.Load("Imagem.jpg");
            pb_Imagem1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.TableLayoutPanel.Controls.Add(this.pb_Imagem1, 0, 0);
            TableLayoutPanel.SetColumnSpan(pb_Imagem1, 3);
            pb_Imagem1.Anchor = AnchorStyles.None;

            // ToolTip - RichTextBox
            tt_Exemplo.AutoPopDelay = 10000;
            tt_Exemplo.InitialDelay = 100;
            tt_Exemplo.ReshowDelay = 500;
            tt_Exemplo.ShowAlways = true;

            // Label e RichTextBox
            lbl_Rich = new Label();
            lbl_Rich.Text = "RichTextBox";
            lbl_Rich.Font = new Font(lbl_Rich.Font, FontStyle.Bold);
            lbl_Rich.Dock = DockStyle.Fill;
            this.lbl_Rich.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_Rich, 0, 1);

            rtxt_RichTB = new RichTextBox();
            rtxt_RichTB.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
            rtxt_RichTB.SelectionColor = System.Drawing.Color.Blue;
            rtxt_RichTB.Font = new Font(rtxt_RichTB.Font, FontStyle.Bold);
            rtxt_RichTB.Size = new Size(300, 20);
            tt_Exemplo.SetToolTip(rtxt_RichTB, "Informe o nome");
            this.TableLayoutPanel.Controls.Add(this.rtxt_RichTB, 1, 1);
            TableLayoutPanel.SetColumnSpan(rtxt_RichTB, 2);
            rtxt_RichTB.Anchor = AnchorStyles.None;

            // Label e NumericUpDown
            lbl_NumericUd = new Label();
            lbl_NumericUd.Text = "NumericUpDown: ";
            lbl_NumericUd.Font = new Font(lbl_NumericUd.Font, FontStyle.Bold);
            lbl_NumericUd.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_NumericUd, 0, 3);

            lbl_ExUm = new Label();
            lbl_ExUm.Text = "Ex.: 2 Digitos";
            lbl_ExUm.Font = new Font(lbl_ExUm.Font, FontStyle.Bold);
            lbl_ExUm.ForeColor = Color.Red;
            this.TableLayoutPanel.Controls.Add(this.lbl_ExUm, 1, 3);
            lbl_ExUm.Anchor = AnchorStyles.None;

            // Seleção de números - Casa 1
            num_Numeric1 = new NumericUpDown();
            num_Numeric1.ForeColor = Color.Black;
            num_Numeric1.Minimum = 1;
            num_Numeric1.Maximum = 99;
            this.TableLayoutPanel.Controls.Add(this.num_Numeric1, 2, 3);

            lbl_ExDois = new Label();
            lbl_ExDois.Text = "Ex.: 3 Digitos";
            lbl_ExDois.Font = new Font(lbl_ExDois.Font, FontStyle.Bold);
            lbl_ExDois.ForeColor = Color.Red;
            this.TableLayoutPanel.Controls.Add(this.lbl_ExDois, 1, 4);
            lbl_ExDois.Anchor = AnchorStyles.None;

            // Seleção de números - Casa 2
            num_Numeric2 = new NumericUpDown();
            num_Numeric2.ForeColor = Color.Black;
            num_Numeric2.Minimum = 100;
            num_Numeric2.Maximum = 999;
            this.TableLayoutPanel.Controls.Add(this.num_Numeric2, 2, 4);

            lbl_ExTres = new Label();
            lbl_ExTres.Text = "Ex.: 4 Digitos";
            lbl_ExTres.Font = new Font(lbl_ExTres.Font, FontStyle.Bold);
            lbl_ExTres.ForeColor = Color.Red;
            this.TableLayoutPanel.Controls.Add(this.lbl_ExTres, 1, 5);
            lbl_ExTres.Anchor = AnchorStyles.None;

            // Seleção de números - Casa 3
            num_Numeric3 = new NumericUpDown();
            num_Numeric3.ForeColor = Color.Black;
            num_Numeric3.Minimum = 1000;
            num_Numeric3.Maximum = 9999;
            this.TableLayoutPanel.Controls.Add(this.num_Numeric3, 3, 5);

            // Label e MaskedTextBox
            lbl_Masked = new Label();
            lbl_Masked.Text = "MaskedTextBox";
            lbl_Masked.Font = new Font(lbl_Masked.Font, FontStyle.Bold);
            lbl_Masked.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_Masked, 0, 7);

            rtxt_Masked = new MaskedTextBox();
            rtxt_Masked.Mask = "(00) 00000 - 0000";
            rtxt_Masked.Size = new Size(150, 20);
            rtxt_Masked.Font = new Font(rtxt_Masked.Font, FontStyle.Bold);
            rtxt_Masked.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.rtxt_Masked, 1, 7);

            lbl_Combo = new Label();
            lbl_Combo.Text = "ComboBox";
            lbl_Combo.AutoSize = true;
            lbl_Combo.Font = new Font(lbl_Combo.Font, FontStyle.Bold);
            lbl_Combo.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_Combo, 0, 9);

            // ComboBox - Seleção Cascata
            cb_Combo = new ComboBox();
            cb_Combo.Items.Add("Ítem 1");
            cb_Combo.Items.Add("Ítem 2");
            cb_Combo.Items.Add("Ítem 3");
            cb_Combo.Items.Add("Ítem 4");
            cb_Combo.Items.Add("Ítem 5");
            cb_Combo.AutoCompleteMode = AutoCompleteMode.Append;
            cb_Combo.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.cb_Combo, 1, 9);

            // Label e RadioButton
            lbl_Radio = new Label();
            lbl_Radio.Text = "RadioButton";
            lbl_Radio.AutoSize = true;
            lbl_Radio.Font = new Font(lbl_Radio.Font, FontStyle.Bold);
            lbl_Radio.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_Radio, 0, 11);
            lbl_Radio.Anchor = AnchorStyles.None;

            rb_RadioUm = new RadioButton();
            rb_RadioUm.AutoSize = true;
            rb_RadioUm.Text = "Ítem - 1";
            this.TableLayoutPanel.Controls.Add(this.rb_RadioUm, 0, 12);

            rb_RadioDois = new RadioButton();
            rb_RadioDois.AutoSize = true;
            rb_RadioDois.Text = "Ítem - 2";
            this.TableLayoutPanel.Controls.Add(this.rb_RadioDois, 0, 13);

            rb_RadioTres = new RadioButton();
            rb_RadioTres.AutoSize = true;
            rb_RadioTres.Text = "Ítem - 3";
            this.TableLayoutPanel.Controls.Add(this.rb_RadioTres, 0, 14);

            // LinkLabel - Link de acesso
            this.link_help = new System.Windows.Forms.LinkLabel();
            this.link_help.AutoSize = true;
            this.link_help.Font = new Font(link_help.Font, FontStyle.Bold);
            this.link_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForHelp_LinkClicked);
            this.link_help.Text = "Ajuda com LinkLabel";
            this.TableLayoutPanel.Controls.AddRange(new System.Windows.Forms.Control[] { this.link_help });
            this.TableLayoutPanel.Controls.Add(this.link_help, 1, 12);
            this.link_help.Anchor = AnchorStyles.None;

            // Label e CheckBox - Múltiplas escolhas
            lbl_Check = new Label();
            lbl_Check.Text = "CheckBox";
            lbl_Check.Location = new Point(260, 295);
            lbl_Check.AutoSize = true;
            lbl_Check.Font = new Font(lbl_Check.Font, FontStyle.Bold);
            this.TableLayoutPanel.Controls.Add(this.lbl_Check, 2, 11);
            this.lbl_Check.Anchor = AnchorStyles.None;

            chk_Um = new CheckBox();
            chk_Um.AutoSize = true;
            chk_Um.Text = "Opção - X";
            this.TableLayoutPanel.Controls.Add(this.chk_Um, 2, 12);

            chk_Dois = new CheckBox();
            chk_Dois.AutoSize = true;
            chk_Dois.Text = "Opção - Y";
            this.TableLayoutPanel.Controls.Add(this.chk_Dois, 2, 13);

            chk_Tres = new CheckBox();
            chk_Tres.AutoSize = true;
            chk_Tres.Text = "Opção - Z";
            this.TableLayoutPanel.Controls.Add(this.chk_Tres, 2, 14);

            this.Controls.Add(this.TableLayoutPanel);
        }
    }
}