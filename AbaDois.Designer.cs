using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace FormsComponentes
{
    partial class AbaDois
    {
        private IContainer components = null;
        private TableLayoutPanel TableLayoutPanel;

        // Label e ListBox (1 Coluna)
        private Label lbl_ListBox;
        private ListBox lb_ListBox;

        // Label e ListView (1 ou mais Colunas)
        private Label lbl_ListView;
        private ListView lv_ListView;

        // Label e CheckedListBox (Colunas c/ caixas de seleção)
        private Label lbl_CheckedListBox;
        private CheckedListBox clb_CheckedLB;

        // Caixa GrupoBox, Label, TrackBar e Display de Progresso
        private Label lbl_TrackB;
        private TrackBar tb_ExTrackBar;
        private TextBox tb_TrackBar;
        private Label lbl_TrackBar;

        // Botão p/ abrir arquivo e TextBox para exibição
        private Label lbl_Open;
        private Button btn_OpenFile;

        // Caixa GrupoBox e DataTimePicker (Selelção data específica)
        private Label lbl_DataTP;
        private DateTimePicker dp_DataTP;

        // Label e ProgressBar (Barra de Progresso)
        private Label lbl_Barra2;
        private ProgressBar pb_Barra;

        private Label lbl_Error;
        private TextBox txt_ErrorBox;
        private ErrorProvider TextError;
        private Button btn_TesteErro;

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
            this.Text = "TableLP # 2";
            this.BackColor = ColorTranslator.FromHtml("#0fe3ef");

            this.TableLayoutPanel = new TableLayoutPanel();
            this.TableLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.RowCount = 14;
            this.TableLayoutPanel.Dock = DockStyle.Fill;
            this.TableLayoutPanel.BackColor = ColorTranslator.FromHtml("#0fe3ef");
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // Label e ListBox - 1 coluna
            lbl_ListBox = new Label();
            lbl_ListBox.Text = "ListBox";
            lbl_ListBox.AutoSize = true;
            lbl_ListBox.Font = new Font(lbl_ListBox.Font, FontStyle.Bold);
            lbl_ListBox.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lbl_ListBox, 0, 0);

            lb_ListBox = new ListBox();
            lb_ListBox.Size = new Size(100, 120);
            lb_ListBox.Items.Add("Ítem - A");
            lb_ListBox.Items.Add("Ítem - B");
            lb_ListBox.Items.Add("Ítem - C");
            lb_ListBox.Items.Add("Ítem - D");
            lb_ListBox.Items.Add("Ítem - E");
            lb_ListBox.SelectionMode = SelectionMode.MultiExtended;
            lb_ListBox.MultiColumn = true;
            lb_ListBox.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lb_ListBox, 0, 1);

            // Label e ListView - 1 ou mais colunas
            lbl_ListView = new Label();
            lbl_ListView.Text = "ListView";
            lbl_ListView.AutoSize = true;
            lbl_ListView.Font = new Font(lbl_ListView.Font, FontStyle.Bold);
            lbl_ListView.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lbl_ListView, 1, 0);

            lv_ListView = new ListView();
            lv_ListView.Size = new Size(150, 120);
            lv_ListView.View = View.Details;
            ListViewItem desc1 = new ListViewItem("A");
            desc1.SubItems.Add("Ítem #1");
            ListViewItem desc2 = new ListViewItem("B");
            desc2.SubItems.Add("Ítem #2");
            ListViewItem desc3 = new ListViewItem("C");
            desc3.SubItems.Add("Ítem #3");
            ListViewItem desc4 = new ListViewItem("D");
            desc4.SubItems.Add("Ítem #4");
            ListViewItem desc5 = new ListViewItem("E");
            desc5.SubItems.Add("Ítem #4");
            lv_ListView.Items.AddRange(new ListViewItem[] { desc1, desc2, desc3, desc4, desc5 });
            lv_ListView.FullRowSelect = true;
            lv_ListView.GridLines = true;
            lv_ListView.AllowColumnReorder = true;
            lv_ListView.Sorting = SortOrder.Ascending;
            lv_ListView.Columns.Add("Coluna 1", -2, HorizontalAlignment.Left);
            lv_ListView.Columns.Add("Coluna 2", -2, HorizontalAlignment.Left);
            lv_ListView.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lv_ListView, 1, 1);

            // Label e CheckedListBox - Coluna com caixa de seleção
            lbl_CheckedListBox = new Label();
            lbl_CheckedListBox.Text = "CheckedListBox";
            lbl_CheckedListBox.AutoSize = true;
            lbl_CheckedListBox.Font = new Font(lbl_CheckedListBox.Font, FontStyle.Bold);
            lbl_CheckedListBox.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lbl_CheckedListBox, 2, 0);

            clb_CheckedLB = new CheckedListBox();
            clb_CheckedLB.Size = new Size(100, 120);
            string[] pagtos = { "Opção A", "Opção B", "Opção C", "Opção D", "Opção E" };
            clb_CheckedLB.Items.AddRange(pagtos);
            clb_CheckedLB.ItemCheck += new ItemCheckEventHandler(this.clb_CheckedLB_ItemCheck);
            clb_CheckedLB.SelectionMode = SelectionMode.One;
            clb_CheckedLB.CheckOnClick = true;
            clb_CheckedLB.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.clb_CheckedLB, 2, 1);

            // Label e "OpenFile" Button - Abrir arquivos
            lbl_Open = new Label();
            lbl_Open.Text = "Button Open File";
            lbl_Open.AutoSize = true;
            lbl_Open.Font = new Font(lbl_Open.Font, FontStyle.Bold);
            this.TableLayoutPanel.Controls.Add(this.lbl_Open, 0, 3);
            lbl_Open.Anchor = AnchorStyles.None;

            btn_OpenFile = new Button();
            btn_OpenFile.Text = "OPEN FILE";
            btn_OpenFile.Size = new Size(180, 40);
            btn_OpenFile.BackColor = ColorTranslator.FromHtml("#4e4786");
            this.btn_OpenFile.Font = new Font(btn_OpenFile.Font, FontStyle.Bold);
            this.btn_OpenFile.ForeColor = Color.White;
            this.btn_OpenFile.Click += new EventHandler(this.btn_OpenFileClick);
            this.TableLayoutPanel.Controls.Add(this.btn_OpenFile, 1, 3);
            TableLayoutPanel.SetColumnSpan(btn_OpenFile, 2);
            btn_OpenFile.Anchor = AnchorStyles.None;

            //Label e ProgressBar
            lbl_Barra2 = new Label();
            lbl_Barra2.Text = "ProgressBar";
            lbl_Barra2.Location = new Point(260, 230);
            lbl_Barra2.AutoSize = true;
            lbl_Barra2.Font = new Font(lbl_Barra2.Font, FontStyle.Bold);
            lbl_Barra2.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_Barra2, 0, 5);
            lbl_Barra2.Anchor = AnchorStyles.None;

            pb_Barra = new ProgressBar();
            pb_Barra.Size = new Size(300, 20);
            pb_Barra.Visible = true;
            pb_Barra.Value = 0;
            //pb_Barra.Minimum = 0;   
            pb_Barra.Maximum = 100;
            pb_Barra.Step = 1;
            pb_Barra.Style = ProgressBarStyle.Marquee;
            pb_Barra.MarqueeAnimationSpeed = 100;
            this.TableLayoutPanel.Controls.Add(this.pb_Barra, 1, 5);
            TableLayoutPanel.SetColumnSpan(pb_Barra, 2);
            pb_Barra.Anchor = AnchorStyles.None;

            // Label e DateTimePicker - Data específica
            lbl_DataTP = new Label();
            lbl_DataTP.Text = "DateTimePicker";
            lbl_DataTP.AutoSize = true;
            lbl_DataTP.Font = new Font(lbl_DataTP.Font, FontStyle.Bold);
            lbl_DataTP.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_DataTP, 0, 7);
            lbl_DataTP.Anchor = AnchorStyles.None;

            dp_DataTP = new DateTimePicker();
            dp_DataTP.Size = new Size(300, 20);
            dp_DataTP.Format = DateTimePickerFormat.Time;
            dp_DataTP.Format = DateTimePickerFormat.Custom;
            dp_DataTP.CustomFormat = "dd MMMM yyyy - dddd";
            // dt_DataLocacao.ShowCheckBox = true;
            // dt_DataLocacao.ShowUpDown = true;
            this.TableLayoutPanel.Controls.Add(this.dp_DataTP, 1, 7);
            TableLayoutPanel.SetColumnSpan(dp_DataTP, 2);
            dp_DataTP.Anchor = AnchorStyles.None;

            // Labels E TrackBar
            lbl_TrackB = new Label();
            lbl_TrackB.Text = "TrackBar";
            lbl_TrackB.AutoSize = true;
            lbl_TrackB.Font = new Font(lbl_TrackB.Font, FontStyle.Bold);
            lbl_TrackB.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_TrackB, 0, 9);
            lbl_TrackB.Anchor = AnchorStyles.None;

            lbl_TrackBar = new Label();
            lbl_TrackBar.Text = "   0% <---------------------------> 100%";
            lbl_TrackBar.AutoSize = true;
            lbl_TrackBar.Font = new Font(lbl_TrackBar.Font, FontStyle.Italic);
            this.lbl_TrackBar.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_TrackBar, 1, 9);
            TableLayoutPanel.SetColumnSpan(lbl_TrackBar, 2);
            lbl_TrackBar.Anchor = AnchorStyles.None;

            // Barra de seleção gradual
            tb_ExTrackBar = new TrackBar();
            tb_ExTrackBar.Size = new System.Drawing.Size(200, 45);
            tb_ExTrackBar.Maximum = 100;
            tb_ExTrackBar.TickFrequency = 10;
            tb_ExTrackBar.LargeChange = 10;
            tb_ExTrackBar.SmallChange = 10;
            tb_ExTrackBar.Scroll += new EventHandler(tb_ExTrackBar_Scroll);
            this.TableLayoutPanel.Controls.Add(this.tb_ExTrackBar, 1, 10);
            TableLayoutPanel.SetColumnSpan(tb_ExTrackBar, 2);
            tb_ExTrackBar.Anchor = AnchorStyles.None;

            // Display do numérico do TrackBar 
            tb_TrackBar = new TextBox();
            tb_TrackBar.Size = new System.Drawing.Size(50, 40);
            this.TableLayoutPanel.Controls.Add(this.tb_TrackBar, 1, 11);
            TableLayoutPanel.SetColumnSpan(tb_TrackBar, 2);
            tb_TrackBar.Anchor = AnchorStyles.Top;

            // Label e ErrorProvider - 1 coluna
            lbl_Error = new Label();
            lbl_Error.Text = "   ErrorProvider\n(Somente Letras)";
            lbl_Error.AutoSize = true;
            lbl_Error.Font = new Font(lbl_Error.Font, FontStyle.Bold);
            this.TableLayoutPanel.Controls.Add(this.lbl_Error, 0, 13);
            lbl_Error.Anchor = AnchorStyles.None;

            this.txt_ErrorBox = new TextBox();
            this.txt_ErrorBox.Size = new Size(100, 40);
            this.TextError = new ErrorProvider();
            this.TextError.SetIconAlignment(this.txt_ErrorBox, ErrorIconAlignment.MiddleRight);
            this.TextError.SetIconPadding(this.txt_ErrorBox, 25);
            this.TextError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.TableLayoutPanel.Controls.Add(this.txt_ErrorBox, 1, 13);
            txt_ErrorBox.Anchor = AnchorStyles.Left;

            // Botões de decisões
            btn_TesteErro = new Button();
            btn_TesteErro.Text = "TESTAR ERRO";
            btn_TesteErro.Size = new Size(100, 40);
            this.btn_TesteErro.BackColor = ColorTranslator.FromHtml("#4e4786");
            this.btn_TesteErro.Font = new Font(btn_TesteErro.Font, FontStyle.Bold);
            this.btn_TesteErro.ForeColor = Color.White;
            btn_TesteErro.Click += new EventHandler(this.btn_TesteErro_Click);
            this.TableLayoutPanel.Controls.Add(this.btn_TesteErro, 2, 13);
            btn_TesteErro.Anchor = AnchorStyles.None;

            this.Controls.Add(this.TableLayoutPanel);
        }
    }
}
