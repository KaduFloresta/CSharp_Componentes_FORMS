using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Atividade_Interface
{
    public class Program : System.Windows.Forms.Form
    {
        
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        }

        public class Formulario : Form
        {
            // Controle de Abas
            TabControl tc_LabControl;
            TabPage tp_PageOne;
            TabPage tp_PageTwo;

            // Texto de Orientação 
            ToolTip tt_Exemplo = new ToolTip();

            //Imagem da Janela
            PictureBox pb_Imagem1;
            
            // Label e Texto "Rico" - Editado
            Label lbl_Rich;
            RichTextBox rtxt_Nome;

            // Labels e NumericUpDown
            Label lbl_NumericUd;
            Label lbl_ExUm;
            Label lbl_ExDois;
            Label lbl_ExTres;
            NumericUpDown num_Numeric1;
            NumericUpDown num_Numeric2;
            NumericUpDown num_Numeric3;

            // Label e Texto com máscara de orientação
            Label lbl_Masked;
            MaskedTextBox rtxt_Masked;

            // Label e ComboBox (Cascata)
            Label lbl_Combo;
            ComboBox cb_Combo;

            // Linklabel - Link de acesso           
            LinkLabel link_help;

            // Caixa GrupoBox e Seleção RadioButton (Apenas 1 opção)
            GroupBox gb_Radio; 
            RadioButton rb_RadioUm;
            RadioButton rb_RadioDois;
            RadioButton rb_RadioTres;

            // Caixa GrupoBox e Seleção CheckBox (nenhuma, 1 ou mais opções)
            GroupBox gb_Check;
            CheckBox chk_Um; 
            CheckBox chk_Dois;
            CheckBox chk_Tres;

            // Label e ListBox (1 Coluna)
            Label lbl_ListBox;
            ListBox lb_ListBox;

            // Label e ListView (1 ou mais Colunas)
            Label lbl_ListView;
            ListView lv_ListView;

            // Label e CheckedListBox (Colunas c/ caixas de seleção)
            Label lbl_CheckedListBox;
            CheckedListBox clb_CheckedLB;

            // Calendário para selecionar (Ínicio e Fim)
            Label lb_MonthCalendar;
            MonthCalendar mc_MonthCal;

            // Caixa GrupoBox, Label, TrackBar e Display de Progresso
            Label lbl_TrackBar;
            TrackBar tb_ExTrackBar;            
            TextBox tb_TrackBar;
            GroupBox gb_TrackBar;

            // Botão p/ abrir arquivo e TextBox para exibição
            Button btn_OpenFile;

            // Caixa GrupoBox e DataTimePicker (Selelção data específica)
            GroupBox gb_DataTP;
            DateTimePicker dp_DataTP;

            // Caixa GrupoBox e ProgressBar (Barra de Progresso)
            GroupBox gb_Barra;
            ProgressBar pb_Barra;

            // Busca na Web
            WebBrowser wb_ExWebBrowser;

            // Botões de decisões da janela
            Button btn_Confirmar;
            Button btn_Cancelar; 

            public Formulario ()
            {
                // Título da janela e cor do fundo
                this.Text = "COMPONENTES DE WINDOWS FORMS";
                this.BackColor = ColorTranslator.FromHtml("#0fe3ef");

                // Aba  #1
                tp_PageOne = new TabPage();
                tp_PageOne.Text = "Page 1";
                tp_PageOne.Size = new Size(450, 700);
                tp_PageOne.BackColor = ColorTranslator.FromHtml("#0fe3ef");

                // Aba  #2
                tp_PageTwo = new TabPage();
                tp_PageTwo.Text = "Page 2";
                tp_PageTwo.Size = new Size(500, 700);
                tp_PageTwo.BackColor = ColorTranslator.FromHtml("#0fe3ef");

                // Imagem da Janela
                pb_Imagem1 = new PictureBox();
                pb_Imagem1.Location = new Point (10, 10);    
                pb_Imagem1.Size = new Size(460 , 100);
                pb_Imagem1.ClientSize = new Size (460 , 100);
                pb_Imagem1.Load ("Imagem.jpg");
                pb_Imagem1.SizeMode = PictureBoxSizeMode.StretchImage;
                tp_PageOne.Controls.Add(pb_Imagem1);

                // Controle das Abas
                tc_LabControl = new TabControl();
                tc_LabControl.Location = new Point(0, 25);
                tc_LabControl.Size = new Size(500, 700);
                tc_LabControl.Controls.Add(tp_PageOne);
                tc_LabControl.Controls.Add(tp_PageTwo);
                this.Controls.Add(tc_LabControl);

                // Textos de Orientação
                tt_Exemplo.AutoPopDelay = 10000;
                tt_Exemplo.InitialDelay = 100;
                tt_Exemplo.ReshowDelay = 500;
                tt_Exemplo.ShowAlways = true;
                
                lbl_Rich = new Label();
                lbl_Rich.Text = "RichTextBox";
                lbl_Rich.Location = new Point (30, 130);
                lbl_Rich.Size = new Size(120, 40);
                lbl_Rich.Font = new Font(lbl_Rich.Font, FontStyle.Bold);
                this.lbl_Rich.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_Rich);

                // Texto com edição
                rtxt_Nome = new RichTextBox();
                rtxt_Nome.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);  
                rtxt_Nome.SelectionColor = System.Drawing.Color.Blue;
                rtxt_Nome.Font = new Font(rtxt_Nome.Font, FontStyle.Bold);
                rtxt_Nome.Location = new Point (150, 120);    
                rtxt_Nome.Size = new Size(300, 20);                
                tp_PageOne.Controls.Add(rtxt_Nome);
                tt_Exemplo.SetToolTip(rtxt_Nome, "Informe o nome");

                lbl_NumericUd = new Label();
                lbl_NumericUd.Text = "NumericUpDown: ";
                lbl_NumericUd.Location = new Point (30, 175);
                lbl_NumericUd.AutoSize = true;
                lbl_NumericUd.Font = new Font(lbl_NumericUd.Font, FontStyle.Bold);
                lbl_NumericUd.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_NumericUd); 

                lbl_ExUm = new Label();
                lbl_ExUm.Text = "Ex.:1";
                lbl_ExUm.Location = new Point (160, 175);
                lbl_ExUm.AutoSize = true;
                lbl_ExUm.Font = new Font(lbl_ExUm.Font, FontStyle.Bold);
                lbl_ExUm.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_ExUm);

                // Seleção de números - Casa 1
                num_Numeric1 = new NumericUpDown();
                num_Numeric1.Location = new Point (200, 170);    
                num_Numeric1.Size = new Size(50, 20);
                num_Numeric1.ForeColor = Color.Black;
                num_Numeric1.Minimum = 1;
                num_Numeric1.Maximum = 99;
                tp_PageOne.Controls.Add(num_Numeric1);

                lbl_ExDois = new Label();
                lbl_ExDois.Text = "Ex.:2";
                lbl_ExDois.Location = new Point (260, 175);
                lbl_ExDois.AutoSize = true;
                lbl_ExDois.Font = new Font(lbl_ExDois.Font, FontStyle.Bold);
                lbl_ExDois.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_ExDois);

                // Seleção de números - Casa 2
                num_Numeric2 = new NumericUpDown();
                num_Numeric2.Location = new Point (300, 170);    
                num_Numeric2.Size = new Size(50, 20);
                num_Numeric2.ForeColor = Color.Black;
                num_Numeric2.Minimum = 100;
                num_Numeric2.Maximum = 999;
                tp_PageOne.Controls.Add(num_Numeric2); 

                lbl_ExTres = new Label();
                lbl_ExTres.Text = "Ex.: 3";
                lbl_ExTres.Location = new Point (360, 175);
                lbl_ExTres.AutoSize = true;
                lbl_ExTres.Font = new Font(lbl_ExTres.Font, FontStyle.Bold);
                lbl_ExTres.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_ExTres); 

                // Seleção de números - Casa 3
                num_Numeric3 = new NumericUpDown();
                num_Numeric3.Location = new Point (400, 170);    
                num_Numeric3.Size = new Size(50, 20);
                num_Numeric3.ForeColor = Color.Black;
                num_Numeric3.Minimum = 1000;
                num_Numeric3.Maximum = 9999;
                tp_PageOne.Controls.Add(num_Numeric3); 

                lbl_Masked = new Label();
                lbl_Masked.Text = "MaskedTextBox";
                lbl_Masked.Location = new Point (30, 220);
                lbl_Masked.Font = new Font(lbl_Masked.Font, FontStyle.Bold);
                lbl_Masked.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_Masked);

                // Texto com máscara guia
                rtxt_Masked = new MaskedTextBox();
                rtxt_Masked.Mask = "000,000,000-00";
                rtxt_Masked.Location = new Point (150, 220);    
                rtxt_Masked.Size = new Size(150, 20);
                rtxt_Masked.Font = new Font(rtxt_Masked.Font, FontStyle.Bold);
                rtxt_Masked.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(rtxt_Masked);

                lbl_Combo = new Label();
                lbl_Combo.Text = "ComboBox";
                lbl_Combo.Location = new Point (30, 260);
                lbl_Combo.AutoSize = true;
                lbl_Combo.Font = new Font(lbl_Combo.Font, FontStyle.Bold);
                lbl_Combo.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(lbl_Combo);

                // ComboBox - Seleção Cascata
                cb_Combo = new ComboBox();
                cb_Combo.Items.Add("Ítem 1");
                cb_Combo.Items.Add("Ítem 2");
                cb_Combo.Items.Add("Ítem 3");
                cb_Combo.Items.Add("Ítem 4");
                cb_Combo.Items.Add("Ítem 5");
                cb_Combo.AutoCompleteMode = AutoCompleteMode.Append;
                cb_Combo.Location = new Point (150, 260);    
                cb_Combo.Size = new Size(150, 20);
                cb_Combo.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(cb_Combo);

                // LinkLabel - Link de acesso
                this.link_help = new System.Windows.Forms.LinkLabel();
                this.link_help.Location = new System.Drawing.Point (320, 240);
                this.link_help.AutoSize = true;
                this.ClientSize = new System.Drawing.Size(292, 266);
                this.link_help.Font = new Font(link_help.Font, FontStyle.Bold);
                this.link_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForHelp_LinkClicked);
                this.link_help.Text = "Ajuda com LinkLabel";
                tp_PageOne.Controls.AddRange(new System.Windows.Forms.Control[] { this.link_help });

                // RadioButton - Seleciona 1 opção
                rb_RadioUm = new RadioButton();                
                rb_RadioUm.Location = new Point (40, 315);
                rb_RadioUm.Size = new Size (80, 20);
                rb_RadioUm.Text = "Ítem - 1"; 
                tp_PageOne.Controls.Add(rb_RadioUm);

                rb_RadioDois = new RadioButton();
                rb_RadioDois.Location = new Point (40, 335);
                rb_RadioDois.Size = new Size (80, 20);
                rb_RadioDois.Text = "Ítem - 2"; 
                tp_PageOne.Controls.Add(rb_RadioDois);

                rb_RadioTres = new RadioButton();
                rb_RadioTres.Location = new Point (40, 355);
                rb_RadioTres.Size = new Size (80, 20);
                rb_RadioTres.Text = "Ítem - 3";
                tp_PageOne.Controls.Add(rb_RadioTres);

                // Caixa para agrupamento de informações
                gb_Radio = new GroupBox();
                gb_Radio.Text = "RadioButton";
                gb_Radio.Location = new Point (30, 295); 
                gb_Radio.Size = new Size (180, 90);
                gb_Radio.Font = new Font(gb_Radio.Font, FontStyle.Bold);
                gb_Radio.ForeColor = Color.Black;
                tp_PageOne.Controls.Add(gb_Radio);               

                // CheckBob - Múltiplas escolhas
                chk_Um = new CheckBox();
                chk_Um.Location = new Point (270, 315);
                chk_Um.Size = new Size (160, 20);
                chk_Um.Text = "Opção - X"; 
                tp_PageOne.Controls.Add(chk_Um);

                chk_Dois = new CheckBox();
                chk_Dois.Location = new Point (270, 335);
                chk_Dois.Size = new Size (160, 20);
                chk_Dois.Text = "Opção - Y"; 
                tp_PageOne.Controls.Add(chk_Dois);

                chk_Tres = new CheckBox();
                chk_Tres.Location = new Point (270, 355);
                chk_Tres.Size = new Size (160, 20);
                chk_Tres.Text = "Opção - Z"; 
                tp_PageOne.Controls.Add(chk_Tres);                   

                gb_Check = new GroupBox();
                gb_Check.Text = "CheckBox";
                gb_Check.Location = new Point (260, 295);
                gb_Check.Font = new Font(gb_Check.Font, FontStyle.Bold); 
                gb_Check.Size = new Size (180, 90);
                tp_PageOne.Controls.Add(gb_Check); 

                lbl_ListBox = new Label();
                lbl_ListBox.Text = "ListBox";
                lbl_ListBox.Location = new Point (60, 390); 
                lbl_ListBox.AutoSize = true;
                lbl_ListBox.Font = new Font(lbl_ListBox.Font, FontStyle.Bold);
                tp_PageOne.Controls.Add(lbl_ListBox);

                // ListBox - 1 coluna
                lb_ListBox = new ListBox();
                lb_ListBox.Location = new Point (40, 410);
                lb_ListBox.Size = new Size (100, 120);
                lb_ListBox.Items.Add ("Ítem - A");
                lb_ListBox.Items.Add ("Ítem - B");
                lb_ListBox.Items.Add ("Ítem - C");
                lb_ListBox.Items.Add ("Ítem - D");
                lb_ListBox.Items.Add ("Ítem - E");
                lb_ListBox.SelectionMode = SelectionMode.MultiExtended;
                lb_ListBox.MultiColumn = true;
                tp_PageOne.Controls.Add(lb_ListBox);

                lbl_ListView = new Label();
                lbl_ListView.Text = "ListView";
                lbl_ListView.Location = new Point (200, 390); 
                lbl_ListView.AutoSize = true;
                lbl_ListView.Font = new Font(lbl_ListView.Font, FontStyle.Bold);
                tp_PageOne.Controls.Add(lbl_ListView);

                // ListView - 1 ou mais colunas
                lv_ListView = new ListView();
                lv_ListView.Location = new Point(160, 410);
                lv_ListView.Size = new Size(160, 120);
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
                lv_ListView.Items.AddRange(new ListViewItem[]{desc1, desc2, desc3, desc4, desc5});
                lv_ListView.FullRowSelect = true;
                lv_ListView.GridLines = true;
                lv_ListView.AllowColumnReorder = true;
                lv_ListView.Sorting = SortOrder.Ascending;
                lv_ListView.Columns.Add("Coluna 1", -2, HorizontalAlignment.Left);
                lv_ListView.Columns.Add("Coluna 2", -2, HorizontalAlignment.Left);
                tp_PageOne.Controls.Add(lv_ListView);

                lbl_CheckedListBox = new Label();
                lbl_CheckedListBox.Text = "CheckedListBox";
                lbl_CheckedListBox.Location = new Point (350, 390); 
                lbl_CheckedListBox.AutoSize = true;
                lbl_CheckedListBox.Font = new Font(lbl_CheckedListBox.Font, FontStyle.Bold);
                tp_PageOne.Controls.Add(lbl_CheckedListBox);

                // CheckedListBox - Coluna com caixa de seleção
                clb_CheckedLB = new CheckedListBox();
                clb_CheckedLB.Location = new Point(340, 410);
                clb_CheckedLB.Size = new Size(100, 120);
                string[] pagtos = { "Opção A", "Opção B", "Opção C", "Opção D", "Opção E"};
                clb_CheckedLB.Items.AddRange (pagtos);
                clb_CheckedLB.ItemCheck += new ItemCheckEventHandler(this.clb_CheckedLB_ItemCheck);
                clb_CheckedLB.SelectionMode = SelectionMode.One;
                clb_CheckedLB.CheckOnClick = true;
                tp_PageOne.Controls.Add(clb_CheckedLB); 

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

                lb_MonthCalendar = new Label();
                lb_MonthCalendar.Text = "MonthCalendar";
                lb_MonthCalendar.Location = new Point (30, 25); 
                lb_MonthCalendar.AutoSize = true;
                lb_MonthCalendar.Font = new Font(lb_MonthCalendar.Font, FontStyle.Bold);
                tp_PageTwo.Controls.Add(lb_MonthCalendar);
                
                // Calendário p/ escolha de um período
                DateTime dt_DataLocacao = new DateTime(2020,05,16);
                mc_MonthCal = new MonthCalendar();
                mc_MonthCal.Location = new Point(20, 45);
                mc_MonthCal.MaxSelectionCount = 10;
                mc_MonthCal.MinDate = new DateTime(2019,01,01);
                mc_MonthCal.MaxDate = new DateTime(2020,12,31);
                mc_MonthCal.SelectionRange = new SelectionRange(dt_DataLocacao, new DateTime(2020,05,19));
                tp_PageTwo.Controls.Add(mc_MonthCal);               

                 // Label de orientação do TrackBar
                lbl_TrackBar = new Label();
                lbl_TrackBar.Text = "0%  <---------------->  100%";
                lbl_TrackBar.Location = new Point (287, 45);
                lbl_TrackBar.Size = new Size(200, 20);
                lbl_TrackBar.Font = new Font(lbl_TrackBar.Font, FontStyle.Italic);
                this.lbl_TrackBar.ForeColor = Color.Black;
                tp_PageTwo.Controls.Add(lbl_TrackBar);
                
                // Barra de seleção gradual
                tb_ExTrackBar = new TrackBar();
                tb_ExTrackBar.Location = new System.Drawing.Point(280, 60);
                tb_ExTrackBar.Size = new System.Drawing.Size(160, 45);
                tb_ExTrackBar.Maximum = 100;
                tb_ExTrackBar.TickFrequency = 10;
                tb_ExTrackBar.LargeChange = 10;
                tb_ExTrackBar.SmallChange = 10;
                tb_ExTrackBar.Scroll += new EventHandler(tb_ExTrackBar_Scroll);
                tp_PageTwo.Controls.Add(tb_ExTrackBar);

                // Display do numérico do TrackBar 
                tb_TrackBar = new TextBox();
			    tb_TrackBar.Location = new System.Drawing.Point(335, 105);
                tb_TrackBar.Size = new System.Drawing.Size(50, 40);
                tp_PageTwo.Controls.Add(tb_TrackBar);

                gb_TrackBar = new GroupBox();
                gb_TrackBar.Text = "TrackBar";
                gb_TrackBar.Location = new Point (260, 25); 
                gb_TrackBar.Size = new Size (200, 120);
                gb_TrackBar.Font = new Font(gb_TrackBar.Font, FontStyle.Bold);
                gb_TrackBar.ForeColor = Color.Black;
                tp_PageTwo.Controls.Add(gb_TrackBar); 

                // Botão p/ abrir arquivos
                btn_OpenFile = new Button();
                btn_OpenFile.Text = "OPEN FILE";
                btn_OpenFile.Location = new Point(285, 170);
                btn_OpenFile.Size = new Size(150, 40);
                btn_OpenFile.BackColor = ColorTranslator.FromHtml("#4e4786");
                this.btn_OpenFile.Font = new Font(btn_OpenFile.Font, FontStyle.Bold);
                this.btn_OpenFile.ForeColor = Color.White;
                btn_OpenFile.Click += new EventHandler(this.btn_OpenFileClick);
                tp_PageTwo.Controls.Add(btn_OpenFile); 

                // Barra com a escolha de uma data específica
                dp_DataTP = new DateTimePicker();
                dp_DataTP.Location = new Point(30, 250);
                dp_DataTP.Size = new Size(205, 20);
                dp_DataTP.Format = DateTimePickerFormat.Time;
                dp_DataTP.Format = DateTimePickerFormat.Custom;
                dp_DataTP.CustomFormat = "dd MMMM yyyy - dddd";
                // dt_DataLocacao.ShowCheckBox = true;
                // dt_DataLocacao.ShowUpDown = true;
                tp_PageTwo.Controls.Add(dp_DataTP); 

                gb_DataTP = new GroupBox();
                gb_DataTP.Text = "DateTimePicker";
                gb_DataTP.Location = new Point (20, 230); 
                gb_DataTP.Size = new Size (225, 50);
                gb_DataTP.Font = new Font(gb_DataTP.Font, FontStyle.Bold);
                gb_DataTP.ForeColor = Color.Black;
                tp_PageTwo.Controls.Add(gb_DataTP);

                // Barra de progresso "loading"
                pb_Barra = new ProgressBar();
                pb_Barra.Location  = new Point (270, 250);
                pb_Barra.Size = new Size (180, 20);
                pb_Barra.Visible = true;
                pb_Barra.Value = 0;
                //pb_Barra.Minimum = 0;   
                pb_Barra.Maximum = 100;    
                pb_Barra.Step = 1;
                pb_Barra.Style = ProgressBarStyle.Marquee;
                pb_Barra.MarqueeAnimationSpeed = 100;
                tp_PageTwo.Controls.Add(pb_Barra); 

                gb_Barra = new GroupBox();
                gb_Barra.Text = "ProgressBar";
                gb_Barra.Location = new Point (260, 230); 
                gb_Barra.Size = new Size (200, 50);
                gb_Barra.Font = new Font(gb_Barra.Font, FontStyle.Bold);
                gb_Barra.ForeColor = Color.Black;
                tp_PageTwo.Controls.Add(gb_Barra);

                // ...
                wb_ExWebBrowser = new WebBrowser();
                wb_ExWebBrowser.Location = new Point(500, 200);
                wb_ExWebBrowser.Size = new Size(200, 500);
                wb_ExWebBrowser.Navigate("https://www.google.com");
                tp_PageTwo.Controls.Add(wb_ExWebBrowser);

                // Botões de decisão
                btn_Confirmar = new Button();
                btn_Confirmar.Text = "CONFIRMAR";
                btn_Confirmar.Location = new Point(70, 550);
                btn_Confirmar.Size = new Size(150, 40);
                this.btn_Confirmar.BackColor = ColorTranslator.FromHtml("#4e4786");
                this.btn_Confirmar.Font = new Font(btn_Confirmar.Font, FontStyle.Bold);
                this.btn_Confirmar.ForeColor = Color.White; 
                btn_Confirmar.Click += new EventHandler (this.btn_ConfirmarClick);
                tp_PageOne.Controls.Add(btn_Confirmar);

                btn_Cancelar = new Button();
                btn_Cancelar.Text = "CANCELAR";
                btn_Cancelar.Location = new Point(260, 550);
                btn_Cancelar.Size = new Size(150, 40);
                this.btn_Cancelar.BackColor = ColorTranslator.FromHtml("#4e4786");
                this.btn_Cancelar.Font = new Font(btn_Cancelar.Font, FontStyle.Bold);
                this.btn_Cancelar.ForeColor = Color.White;
                btn_Cancelar.Click += new EventHandler (this.btn_CancelarClick);
                tp_PageOne.Controls.Add(btn_Cancelar); 
                this.Size = new Size (500, 700);

                // GUIDE FOR LOCATION n SIZE (X Y) 
                // Location (X = Horizontal - Y = Vertical)
                // Size     (X = Largura    - Y = Altura)
            }

            /// <summary>
            /// Evento MessageBox - Botão NEW do submenu do MenuStrip
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void windowNewMenu_Click(object sender, EventArgs e)
            {
                MessageBox.Show("New!!!!");
            }

            /// <summary>
            /// Evento MessageBox - Botão SAVE do submenu do MenuStrip
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void windowSaveMenu_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Save!!!!");
            }
            
            /// <summary>
            /// Evento Scroll do TrackBar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void tb_ExTrackBar_Scroll(object sender, EventArgs e)
            { // Display the trackbar value in the text box. 
			    tb_TrackBar.Text = "" + tb_ExTrackBar.Value;
		    }

            /// <summary>
            /// Evento LinkLabel - Acesso á página de web
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void linkForHelp_LinkClicked (object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
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

            /// <summary>
            /// Método CheckedListBox - Laço
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void clb_CheckedLB_ItemCheck(object sender,ItemCheckEventArgs e)
                {
                    for(int i = 0; i < clb_CheckedLB.Items.Count; i ++)
                        if (i != e.Index) clb_CheckedLB.SetItemChecked(i, false);
                }

            /// <summary>
            /// Evento OpenFile - Abrir conteúdo (txt)
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btn_OpenFileClick(object sender, EventArgs e)
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

            /// <summary>
            /// Botão de Confirmar - MessageBox dados inseridos e seleções do sistema
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btn_ConfirmarClick (object sender, EventArgs e)
            {
                string filmes = "";
                string promocoes = "";
                string pagtos = "";

                foreach (string filme in lb_ListBox.SelectedItems)
                    filmes += " " + filme;

                foreach (ListViewItem promocao in lv_ListView.SelectedItems)
                    promocoes += " " + promocao.Text;

                foreach (string pagto in clb_CheckedLB.CheckedItems)
                    pagtos += " " + pagto;

                MessageBox.Show (
                    $"Nome:> {rtxt_Nome.Text}\n" +
                    $"Data Nascimento:> {num_Numeric1.Value + "/" + num_Numeric2.Value + "/" +  num_Numeric3.Value}\n" +
                    $"C.P.F.:> {rtxt_Masked.Text}\n" +
                    $"Dias Devolução:> {cb_Combo.Text}\n" +
                    $"Tipo CLiente:> {(this.rb_RadioUm.Checked == true ? "CLIENTE BASICO" : this.rb_RadioDois.Checked ? "CLIENTE REGULAR" : this.rb_RadioTres.Checked ? "CLIENTE PREMIUM" : "")}\n" +
                    $"NewLetter:> {(this.chk_Um.Checked == true ? "SMS -" : "")}" +
                    $" {(this.chk_Dois.Checked == true ? "E-mail -" : "")}" +
                    $" {(this.chk_Tres.Checked == true ? "WhatsApp" : "")}\n" +
                    $"Especial Inicio:> {this.mc_MonthCal.SelectionRange.Start}\n" +
                    $"Especial Final:> {this.mc_MonthCal.SelectionRange.End}\n" +
                    $"Data Locação:> {this.dp_DataTP.Value}\n" +
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
            private void btn_CancelarClick (object sender, EventArgs e) 
            {
                this.Close();
            }
        }
    }
}