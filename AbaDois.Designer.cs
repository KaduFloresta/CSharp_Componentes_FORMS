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
        private Library.Label lbl_ListBox;
        private ListBox lb_ListBox;

        // Label e ListView (1 ou mais Colunas)
        private Library.Label lbl_ListView;
        private ListView lv_ListView;

        // Label e CheckedListBox (Colunas c/ caixas de seleção)
        private Library.Label lbl_CheckedListBox;
        private CheckedListBox clb_CheckedLB;

        // Caixa GrupoBox, Label, TrackBar e Display de Progresso
        private Library.Label lbl_TrackB;
        private TrackBar tb_ExTrackBar;
        private TextBox tb_TrackBar;
        private Label lbl_TrackBar;

        // Botão p/ abrir arquivo e TextBox para exibição
        private Library.Label lbl_Open;
        private Button btn_OpenFile;

        // Caixa GrupoBox e DataTimePicker (Selelção data específica)
        private Library.Label lbl_DataTP;
        private DateTimePicker dp_DataTP;

        // Label e ProgressBar (Barra de Progresso)
        private Library.Label lbl_Barra2;
        private ProgressBar pb_Barra;

        private Library.Label lbl_Error;
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
            this.TableLayoutPanel.BackColor = ColorTranslator.FromHtml("#8f8caf");
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
            this.lbl_ListBox = new Library.Label();
            this.lbl_ListBox.Text = "ListBox";
            this.TableLayoutPanel.Controls.Add(this.lbl_ListBox, 0, 0);

            this.lb_ListBox = new ListBox();
            this.lb_ListBox.Size = new Size(100, 120);
            this.lb_ListBox.Items.Add("Ítem - A");
            this.lb_ListBox.Items.Add("Ítem - B");
            this.lb_ListBox.Items.Add("Ítem - C");
            this.lb_ListBox.Items.Add("Ítem - D");
            this.lb_ListBox.Items.Add("Ítem - E");
            this.lb_ListBox.SelectionMode = SelectionMode.MultiExtended;
            this.lb_ListBox.MultiColumn = true;
            this.lb_ListBox.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lb_ListBox, 0, 1);

            // Label e ListView - 1 ou mais colunas
            this.lbl_ListView = new Library.Label();
            this.lbl_ListView.Text = "ListView";
            this.TableLayoutPanel.Controls.Add(this.lbl_ListView, 1, 0);

            this.lv_ListView = new ListView();
            this.lv_ListView.Size = new Size(150, 120);
            this.lv_ListView.View = View.Details;
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
            this.lv_ListView.Items.AddRange(new ListViewItem[] { desc1, desc2, desc3, desc4, desc5 });
            this.lv_ListView.FullRowSelect = true;
            this.lv_ListView.GridLines = true;
            this.lv_ListView.AllowColumnReorder = true;
            this.lv_ListView.Sorting = SortOrder.Ascending;
            this.lv_ListView.Columns.Add("Coluna 1", -2, HorizontalAlignment.Left);
            this.lv_ListView.Columns.Add("Coluna 2", -2, HorizontalAlignment.Left);
            this.lv_ListView.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.lv_ListView, 1, 1);

            // Label e CheckedListBox - Coluna com caixa de seleção
            this.lbl_CheckedListBox = new Library.Label();
            this.lbl_CheckedListBox.Text = "CheckedListBox";
            this.TableLayoutPanel.Controls.Add(this.lbl_CheckedListBox, 2, 0);

            this.clb_CheckedLB = new CheckedListBox();
            this.clb_CheckedLB.Size = new Size(100, 120);
            string[] pagtos = { "Opção A", "Opção B", "Opção C", "Opção D", "Opção E" };
            this.clb_CheckedLB.Items.AddRange(pagtos);
            this.clb_CheckedLB.ItemCheck += new ItemCheckEventHandler(this.Clb_CheckedLB_ItemCheck);
            this.clb_CheckedLB.SelectionMode = SelectionMode.One;
            this.clb_CheckedLB.CheckOnClick = true;
            this.clb_CheckedLB.Anchor = AnchorStyles.None;
            this.TableLayoutPanel.Controls.Add(this.clb_CheckedLB, 2, 1);

            // Label e "OpenFile" Button - Abrir arquivos
            this.lbl_Open = new Library.Label();
            this.lbl_Open.Text = "Button Open File";
            this.TableLayoutPanel.Controls.Add(this.lbl_Open, 0, 3);

            this.btn_OpenFile = new Button();
            this.btn_OpenFile.Text = "OPEN FILE";
            this.btn_OpenFile.Size = new Size(180, 40);
            this.btn_OpenFile.BackColor = ColorTranslator.FromHtml("#4e4786");
            this.btn_OpenFile.Font = new Font(btn_OpenFile.Font, FontStyle.Bold);
            this.btn_OpenFile.ForeColor = Color.White;
            this.btn_OpenFile.Click += new EventHandler(this.Btn_OpenFileClick);
            this.TableLayoutPanel.Controls.Add(this.btn_OpenFile, 1, 3);
            this.TableLayoutPanel.SetColumnSpan(btn_OpenFile, 2);
            this.btn_OpenFile.Anchor = AnchorStyles.None;

            //Label e ProgressBar
            this.lbl_Barra2 = new Library.Label();
            this.lbl_Barra2.Text = "ProgressBar";
            this.TableLayoutPanel.Controls.Add(this.lbl_Barra2, 0, 5);

            this.pb_Barra = new ProgressBar();
            this.pb_Barra.Size = new Size(300, 20);
            this.pb_Barra.Visible = true;
            this.pb_Barra.Value = 0;
            //this.pb_Barra.Minimum = 0;   
            this.pb_Barra.Maximum = 100;
            this.pb_Barra.Step = 1;
            this.pb_Barra.Style = ProgressBarStyle.Marquee;
            this.pb_Barra.MarqueeAnimationSpeed = 100;
            this.TableLayoutPanel.Controls.Add(this.pb_Barra, 1, 5);
            this.TableLayoutPanel.SetColumnSpan(pb_Barra, 2);
            this.pb_Barra.Anchor = AnchorStyles.None;

            // Label e DateTimePicker - Data específica
            this.lbl_DataTP = new Library.Label();
            this.lbl_DataTP.Text = "DateTimePicker";
            this.TableLayoutPanel.Controls.Add(this.lbl_DataTP, 0, 7);

            this.dp_DataTP = new DateTimePicker();
            this.dp_DataTP.Size = new Size(300, 20);
            this.dp_DataTP.Format = DateTimePickerFormat.Time;
            this.dp_DataTP.Format = DateTimePickerFormat.Custom;
            this.dp_DataTP.CustomFormat = "dd MMMM yyyy - dddd";
            // this.dt_DataLocacao.ShowCheckBox = true;
            // this.dt_DataLocacao.ShowUpDown = true;
            this.TableLayoutPanel.Controls.Add(this.dp_DataTP, 1, 7);
            this.TableLayoutPanel.SetColumnSpan(dp_DataTP, 2);
            this.dp_DataTP.Anchor = AnchorStyles.None;

            // Labels E TrackBar
            this.lbl_TrackB = new Library.Label();
            this.lbl_TrackB.Text = "TrackBar";
            this.TableLayoutPanel.Controls.Add(this.lbl_TrackB, 0, 9);

            this.lbl_TrackBar = new Label();
            this.lbl_TrackBar.Text = "   0% <---------------------------> 100%";
            this.lbl_TrackBar.AutoSize = true;
            this.lbl_TrackBar.Font = new Font(lbl_TrackBar.Font, FontStyle.Italic);
            this.lbl_TrackBar.ForeColor = Color.Black;
            this.TableLayoutPanel.Controls.Add(this.lbl_TrackBar, 1, 9);
            this.TableLayoutPanel.SetColumnSpan(lbl_TrackBar, 2);
            this.lbl_TrackBar.Anchor = AnchorStyles.None;

            // Barra de seleção gradual
            this.tb_ExTrackBar = new TrackBar();
            this.tb_ExTrackBar.Size = new System.Drawing.Size(200, 45);
            this.tb_ExTrackBar.Maximum = 100;
            this.tb_ExTrackBar.TickFrequency = 10;
            this.tb_ExTrackBar.LargeChange = 10;
            this.tb_ExTrackBar.SmallChange = 10;
            this.tb_ExTrackBar.Scroll += new EventHandler(Tb_ExTrackBar_Scroll);
            this.TableLayoutPanel.Controls.Add(this.tb_ExTrackBar, 1, 10);
            this.TableLayoutPanel.SetColumnSpan(tb_ExTrackBar, 2);
            this.tb_ExTrackBar.Anchor = AnchorStyles.None;

            // Display do numérico do TrackBar 
            this.tb_TrackBar = new TextBox();
            this.tb_TrackBar.Size = new System.Drawing.Size(50, 40);
            this.TableLayoutPanel.Controls.Add(this.tb_TrackBar, 1, 11);
            this.TableLayoutPanel.SetColumnSpan(tb_TrackBar, 2);
            this.tb_TrackBar.Anchor = AnchorStyles.Top;

            // Label e ErrorProvider - 1 coluna
            this.lbl_Error = new Library.Label();
            this.lbl_Error.Text = "   ErrorProvider\n(Somente Letras)";
            this.TableLayoutPanel.Controls.Add(this.lbl_Error, 0, 13);

            this.txt_ErrorBox = new TextBox();
            this.txt_ErrorBox.Size = new Size(100, 40);
            this.TextError = new ErrorProvider();
            this.TextError.SetIconAlignment(this.txt_ErrorBox, ErrorIconAlignment.MiddleRight);
            this.TextError.SetIconPadding(this.txt_ErrorBox, 25);
            this.TextError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.TableLayoutPanel.Controls.Add(this.txt_ErrorBox, 1, 13);
            this.txt_ErrorBox.Anchor = AnchorStyles.Left;

            // Botões de decisões
            this.btn_TesteErro = new Button();
            this.btn_TesteErro.Text = "TESTAR ERRO";
            this.btn_TesteErro.Size = new Size(100, 40);
            this.btn_TesteErro.BackColor = ColorTranslator.FromHtml("#4e4786");
            this.btn_TesteErro.Font = new Font(btn_TesteErro.Font, FontStyle.Bold);
            this.btn_TesteErro.ForeColor = Color.White;
            this.btn_TesteErro.Click += new EventHandler(this.Btn_TesteErro_Click);
            this.TableLayoutPanel.Controls.Add(this.btn_TesteErro, 2, 13);
            this.btn_TesteErro.Anchor = AnchorStyles.None;

            this.Controls.Add(this.TableLayoutPanel);
        }
    }
}
