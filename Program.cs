using System;
using System.Linq;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using System.Threading.Tasks;
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
            //Image for window
            PictureBox pb_Imagem;

            // Text for Guidance
            Label lbl_Nome;
            // Data entry boxes with rich way
            RichTextBox rtxt_Nome;
            Label lbl_DataNasc;
            // Labels date of birth
            Label lbl_Dia;
            Label lbl_Mes;
            Label lbl_Ano;
            // Data entry numeric system selection up/down
            NumericUpDown num_DataNascDia;
            NumericUpDown num_DataNascMes;
            NumericUpDown num_DataNascAno;            
            // Label for the mask
            Label lbl_CPF;
            // Data entry boxes masked
            MaskedTextBox rtxt_CPF;
            Label lbl_DiasDevol;
            // Selection Box  - Single Selection
            ComboBox cb_DiasDevol;
            // Link for help            
            LinkLabel link_help;
            GroupBox gb_Tipo;            
            // Single Selection Button
            RadioButton rb_Simples;
            RadioButton rb_Normal;
            RadioButton rb_Premium;
            GroupBox gb_NewLetter;
            // Selection multiple options
            CheckBox chk_SMS; 
            CheckBox chk_Email;
            CheckBox chk_WhatsApp;
            Label lb_DataLocacao;
            // Specific date Selection
            MonthCalendar mc_DataLocacao;
            GroupBox gb_DataLocacao;
            // Date Picker
            DateTimePicker dp_DataLocacao;
            GroupBox gb_Barra;
            ProgressBar pb_Barra;
            Label lbl_ListBox;
            // List of movies to view
            ListBox lb_Filmes;
            Label lbl_ListView;
            // List of promotions to select
            ListView lv_Promocoes;
            Label lbl_CheckedListBox;
            // List of films to select
            CheckedListBox clb_Pgto;
            // Buttons Print or Close
            Button btn_Confirmar;
            Button btn_Cancelar; 

            public Formulario ()
            {
                // Main window text
                this.Text = "CADASTRO CLIENTE - BLOCKBUSTER";
                this.BackColor = ColorTranslator.FromHtml("#0fe3ef");

                // Image by Senac 
                pb_Imagem = new PictureBox();
                pb_Imagem.Location = new Point (10, 10);    
                pb_Imagem.Size = new Size(460 , 100);
                pb_Imagem.ClientSize = new Size (460 , 100);
                pb_Imagem.Load ("Imagem.jpg");
                pb_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pb_Imagem);
                
                // Registration Labels
                lbl_Nome = new Label();
                lbl_Nome.Text = "Nome :";
                lbl_Nome.Location = new Point (20, 120);
                lbl_Nome.Font = new Font(lbl_Nome.Font, FontStyle.Bold);
                this.lbl_Nome.ForeColor = Color.Black;
                this.Controls.Add(lbl_Nome);

                // Registration entry boxes
                rtxt_Nome = new RichTextBox();
                rtxt_Nome.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);  
                rtxt_Nome.SelectionColor = System.Drawing.Color.Blue;
                rtxt_Nome.Font = new Font(rtxt_Nome.Font, FontStyle.Bold);
                rtxt_Nome.Location = new Point (150, 120);    
                rtxt_Nome.Size = new Size(300, 20);                
                this.Controls.Add(rtxt_Nome);

                lbl_DataNasc = new Label();
                lbl_DataNasc.Text = "Data de Nascimento :";
                lbl_DataNasc.Location = new Point (20, 155);
                lbl_DataNasc.AutoSize = true;
                lbl_DataNasc.Font = new Font(lbl_DataNasc.Font, FontStyle.Bold);
                lbl_DataNasc.ForeColor = Color.Black;
                this.Controls.Add(lbl_DataNasc); 

                lbl_Dia = new Label();
                lbl_Dia.Text = "DIA";
                lbl_Dia.Location = new Point (150, 155);
                lbl_Dia.AutoSize = true;
                lbl_Dia.Font = new Font(lbl_Dia.Font, FontStyle.Bold);
                lbl_Dia.ForeColor = Color.Black;
                this.Controls.Add(lbl_Dia);

                // Numeric Up and Down - Date of birth selection
                num_DataNascDia = new NumericUpDown();
                num_DataNascDia.Location = new Point (180, 150);    
                num_DataNascDia.Size = new Size(50, 20);
                num_DataNascDia.ForeColor = Color.Black;
                num_DataNascDia.Minimum = 1;
                num_DataNascDia.Maximum = 31;
                this.Controls.Add(num_DataNascDia);

                lbl_Mes = new Label();
                lbl_Mes.Text = "MÊS";
                lbl_Mes.Location = new Point (240, 155);
                lbl_Mes.AutoSize = true;
                lbl_Mes.Font = new Font(lbl_Mes.Font, FontStyle.Bold);
                lbl_Mes.ForeColor = Color.Black;
                this.Controls.Add(lbl_Mes);

                num_DataNascMes = new NumericUpDown();
                num_DataNascMes.Location = new Point (270, 150);    
                num_DataNascMes.Size = new Size(50, 20);
                num_DataNascMes.ForeColor = Color.Black;
                num_DataNascMes.Minimum = 1;
                num_DataNascMes.Maximum = 12;
                this.Controls.Add(num_DataNascMes); 

                lbl_Ano = new Label();
                lbl_Ano.Text = "ANO";
                lbl_Ano.Location = new Point (330, 155);
                lbl_Ano.AutoSize = true;
                lbl_Ano.Font = new Font(lbl_Ano.Font, FontStyle.Bold);
                lbl_Ano.ForeColor = Color.Black;
                this.Controls.Add(lbl_Ano);  

                num_DataNascAno = new NumericUpDown();
                num_DataNascAno.Location = new Point (365, 150);    
                num_DataNascAno.Size = new Size(50, 20);
                num_DataNascAno.ForeColor = Color.Black;
                num_DataNascAno.Minimum = 1950;
                num_DataNascAno.Maximum = 2020;
                this.Controls.Add(num_DataNascAno);           
                
                lbl_CPF = new Label();
                lbl_CPF.Text = "CPF :";
                lbl_CPF.Location = new Point (20, 185);
                lbl_CPF.Font = new Font(lbl_CPF.Font, FontStyle.Bold);
                lbl_CPF.ForeColor = Color.Black;
                this.Controls.Add(lbl_CPF);

                // MaskedTextBox - Data editing interface
                rtxt_CPF = new MaskedTextBox();
                rtxt_CPF.Mask = "000,000,000-00";
                rtxt_CPF.Location = new Point (150, 185);    
                rtxt_CPF.Size = new Size(300, 20);
                rtxt_CPF.Font = new Font(rtxt_CPF.Font, FontStyle.Bold);
                rtxt_CPF.ForeColor = Color.Black;
                this.Controls.Add(rtxt_CPF);

                lbl_DiasDevol = new Label();
                lbl_DiasDevol.Text = "Dias P/ Devolução :";
                lbl_DiasDevol.Location = new Point (20, 215);
                lbl_DiasDevol.AutoSize = true;
                lbl_DiasDevol.Font = new Font(lbl_DiasDevol.Font, FontStyle.Bold);
                lbl_DiasDevol.ForeColor = Color.Black;
                this.Controls.Add(lbl_DiasDevol);

                // ComboBox - Five options - Single choice
                cb_DiasDevol = new ComboBox();
                cb_DiasDevol.Items.Add("2 Dias");
                cb_DiasDevol.Items.Add("3 Dias");
                cb_DiasDevol.Items.Add("4 Dias");
                cb_DiasDevol.Items.Add("5 Dias");
                cb_DiasDevol.Items.Add("PLUS Plan - 10 Dias");
                cb_DiasDevol.AutoCompleteMode = AutoCompleteMode.Append;
                cb_DiasDevol.Location = new Point (150, 215);    
                cb_DiasDevol.Size = new Size(150, 20);
                cb_DiasDevol.ForeColor = Color.Black;
                this.Controls.Add(cb_DiasDevol);

                // LinkLabel - Access to site for help 
                this.link_help = new System.Windows.Forms.LinkLabel();
                this.link_help.Location = new System.Drawing.Point (320, 220);
                this.link_help.AutoSize = true;
                this.ClientSize = new System.Drawing.Size(292, 266);
                this.link_help.Font = new Font(link_help.Font, FontStyle.Bold);
                this.link_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForHelp_LinkClicked);
                this.link_help.Text = "Ajuda com Link Label";
                this.Controls.AddRange(new System.Windows.Forms.Control[] { this.link_help });
                this.Text = "Simple Link Label Example";      

                // RadioButton - Three options - Single choice
                rb_Simples = new RadioButton();
                rb_Simples.Location = new Point (30, 265);
                rb_Simples.Size = new Size (80, 20);
                rb_Simples.Text = "Básico"; 
                this.Controls.Add(rb_Simples);

                rb_Normal = new RadioButton();
                rb_Normal.Location = new Point (30, 285);
                rb_Normal.Size = new Size (80, 20);
                rb_Normal.Text = "Regular"; 
                this.Controls.Add(rb_Normal);

                rb_Premium = new RadioButton();
                rb_Premium.Location = new Point (30, 305);
                rb_Premium.Size = new Size (80, 20);
                rb_Premium.Text = "Premium"; 
                this.Controls.Add(rb_Premium);     

                gb_Tipo = new GroupBox();
                gb_Tipo.Text = "TIPO DE CLIENTE";
                gb_Tipo.Location = new Point (20, 245); 
                gb_Tipo.Size = new Size (180, 90);
                gb_Tipo.Font = new Font(gb_Tipo.Font, FontStyle.Bold);
                gb_Tipo.ForeColor = Color.Black;
                this.Controls.Add(gb_Tipo);               

                // CheckBob - Three options - Multiple choice
                chk_SMS = new CheckBox();
                chk_SMS.Location = new Point (30, 360);
                chk_SMS.Size = new Size (160, 20);
                chk_SMS.Text = "NewLetter Via SMS"; 
                this.Controls.Add(chk_SMS);

                chk_Email = new CheckBox();
                chk_Email.Location = new Point (30, 380);
                chk_Email.Size = new Size (160, 20);
                chk_Email.Text = "NewLetter Via E-mail"; 
                this.Controls.Add(chk_Email);

                chk_WhatsApp = new CheckBox();
                chk_WhatsApp.Location = new Point (30, 400);
                chk_WhatsApp.Size = new Size (160, 20);
                chk_WhatsApp.Text = "NewLetter Via WhatsApp"; 
                this.Controls.Add(chk_WhatsApp);                   

                gb_NewLetter = new GroupBox();
                gb_NewLetter.Text = "BOLETIM INFORMATIVO";
                gb_NewLetter.Location = new Point (20, 340);
                gb_NewLetter.Font = new Font(gb_NewLetter.Font, FontStyle.Bold); 
                gb_NewLetter.Size = new Size (180, 90);
                this.Controls.Add(gb_NewLetter); 

                lb_DataLocacao = new Label();
                lb_DataLocacao.Text = "DATA DEVOLUÇÃO ESPECIAL";
                lb_DataLocacao.Location = new Point (230, 245); 
                lb_DataLocacao.AutoSize = true;
                lb_DataLocacao.Font = new Font(lb_DataLocacao.Font, FontStyle.Bold);
                this.Controls.Add(lb_DataLocacao);

                DateTime dt_DataLocacao = new DateTime(2020,05,16);
                mc_DataLocacao = new MonthCalendar();
                mc_DataLocacao.Location = new Point(230, 265);
                mc_DataLocacao.MaxSelectionCount = 10;
                mc_DataLocacao.MinDate = new DateTime(2019,01,01);
                mc_DataLocacao.MaxDate = new DateTime(2020,12,31);
                mc_DataLocacao.SelectionRange = new SelectionRange(dt_DataLocacao, new DateTime(2020,05,19));
                this.Controls.Add(mc_DataLocacao);               

                dp_DataLocacao = new DateTimePicker();
                dp_DataLocacao.Location = new Point(30, 460);
                dp_DataLocacao.Size = new Size(215, 20);
                //dp_DataLocacao.Format = DateTimePickerFormat.Time;
                dp_DataLocacao.Format = DateTimePickerFormat.Custom;
                dp_DataLocacao.CustomFormat = "dd MMMM yyyy - dddd";
                // dt_DataLocacao.ShowCheckBox = true;
                // dt_DataLocacao.ShowUpDown = true;
                this.Controls.Add(dp_DataLocacao);

                gb_DataLocacao = new GroupBox();
                gb_DataLocacao.Text = "DATA LOCAÇÃO";
                gb_DataLocacao.Location = new Point (20, 440); 
                gb_DataLocacao.Size = new Size (235, 50);
                gb_DataLocacao.Font = new Font(gb_DataLocacao.Font, FontStyle.Bold);
                gb_DataLocacao.ForeColor = Color.Black;
                this.Controls.Add(gb_DataLocacao); 

                pb_Barra = new ProgressBar();
                pb_Barra.Location  = new Point (280, 460);
                pb_Barra.Size = new Size (180, 20);
                pb_Barra.Minimum = 0;   
                pb_Barra.Maximum = 100;    
                //pb_Barra.Step = 1;
                //pb_Barra.Value = 50;
                pb_Barra.Style = ProgressBarStyle.Marquee;
                // pb_Barra.MarqueeAnimationSpeed = 30;
                
                // for (int i = 0; i <= 10; i++)  
                //     {  
                //         pb_Barra.PerformStep();  
                //         rtxt_Nome.Text = "" + pb_Barra.Value.ToString(); 

                //     } 
                    this.Controls.Add(pb_Barra); 

                gb_Barra = new GroupBox();
                gb_Barra.Text = "BARRA DE PROGRESSO";
                gb_Barra.Location = new Point (270, 440); 
                gb_Barra.Size = new Size (200, 50);
                gb_Barra.Font = new Font(gb_Barra.Font, FontStyle.Bold);
                gb_Barra.ForeColor = Color.Black;
                this.Controls.Add(gb_Barra);

                lbl_ListBox = new Label();
                lbl_ListBox.Text = "FILMES";
                lbl_ListBox.Location = new Point (60, 500); 
                lbl_ListBox.AutoSize = true;
                lbl_ListBox.Font = new Font(lbl_ListBox.Font, FontStyle.Bold);
                this.Controls.Add(lbl_ListBox);

                // ListBox
                lb_Filmes = new ListBox();
                lb_Filmes.Items.Add ("Gretta");
                lb_Filmes.Items.Add ("Divinos Segredos");
                lb_Filmes.Items.Add ("Flores de Aço");
                lb_Filmes.Items.Add ("Olhos Famintos");
                lb_Filmes.Items.Add ("Robocop");
                lb_Filmes.Location = new Point (40, 520);
                lb_Filmes.Size = new Size (100, 120);
                lb_Filmes.SelectionMode = SelectionMode.MultiExtended;
                lb_Filmes.MultiColumn = true;
                this.Controls.Add(lb_Filmes);

                lbl_ListView = new Label();
                lbl_ListView.Text = "DESCONTOS";
                lbl_ListView.Location = new Point (200, 500); 
                lbl_ListView.AutoSize = true;
                lbl_ListView.Font = new Font(lbl_ListView.Font, FontStyle.Bold);
                this.Controls.Add(lbl_ListView);

                // ListView
                lv_Promocoes = new ListView();
                lv_Promocoes.Location = new Point(160, 520);
                lv_Promocoes.Size = new Size(160, 120);
                lv_Promocoes.View = View.Details;
                ListViewItem desc1 = new ListViewItem("5% Desc");
                desc1.SubItems.Add("2 Filmes");
                ListViewItem desc2 = new ListViewItem("10% Desc");
                desc2.SubItems.Add("3 Filmes");
                ListViewItem desc3 = new ListViewItem("15% Desc");
                desc3.SubItems.Add("4 Filmes");
                ListViewItem desc4 = new ListViewItem("20% Desc");
                desc4.SubItems.Add("5 Filmes");
                ListViewItem desc5 = new ListViewItem("25% Desc");
                desc5.SubItems.Add("6 Filmes");
                lv_Promocoes.Items.AddRange(new ListViewItem[]{desc1, desc2, desc3, desc4, desc5});
                lv_Promocoes.FullRowSelect = true;
                lv_Promocoes.GridLines = true;
                lv_Promocoes.AllowColumnReorder = true;
                lv_Promocoes.Sorting = SortOrder.Ascending;
                lv_Promocoes.Columns.Add("Desconto", -2, HorizontalAlignment.Left);
                lv_Promocoes.Columns.Add("Quantidade", -2, HorizontalAlignment.Left);
                this.Controls.Add(lv_Promocoes);

                lbl_CheckedListBox = new Label();
                lbl_CheckedListBox.Text = "PAGAMENTO";
                lbl_CheckedListBox.Location = new Point (350, 500); 
                lbl_CheckedListBox.AutoSize = true;
                lbl_CheckedListBox.Font = new Font(lbl_CheckedListBox.Font, FontStyle.Bold);
                this.Controls.Add(lbl_CheckedListBox);

                // CheckedListBox
                clb_Pgto = new CheckedListBox();
                clb_Pgto.Location = new Point(340, 520);
                clb_Pgto.Size = new Size(100, 120);
                string[] pagtos = { "Dinheiro", "Cartão Débito", "Cartão Crédito", "Boleto", "Cheque"};
                clb_Pgto.Items.AddRange (pagtos);
                clb_Pgto.ItemCheck += new ItemCheckEventHandler(this.clb_Pgto_ItemCheck);
                clb_Pgto.SelectionMode = SelectionMode.One;
                clb_Pgto.CheckOnClick = true;
                this.Controls.Add(clb_Pgto); 

                // Finishing buttons
                btn_Confirmar = new Button();
                btn_Confirmar.Text = "CONFIRMAR";
                btn_Confirmar.Location = new Point(80, 650);
                btn_Confirmar.Size = new Size(150, 40);
                this.btn_Confirmar.BackColor = ColorTranslator.FromHtml("#4e4786");
                this.btn_Confirmar.Font = new Font(btn_Confirmar.Font, FontStyle.Bold);
                this.btn_Confirmar.ForeColor = Color.White; 
                btn_Confirmar.Click += new EventHandler (this.btn_ConfirmarClick);
                this.Controls.Add(btn_Confirmar);

                btn_Cancelar = new Button();
                btn_Cancelar.Text = "CANCELAR";
                btn_Cancelar.Location = new Point(260, 650);
                btn_Cancelar.Size = new Size(150, 40);
                this.btn_Cancelar.BackColor = ColorTranslator.FromHtml("#4e4786");
                this.btn_Cancelar.Font = new Font(btn_Cancelar.Font, FontStyle.Bold);
                this.btn_Cancelar.ForeColor = Color.White;
                btn_Cancelar.Click += new EventHandler (this.btn_CancelarClick);
                this.Controls.Add(btn_Cancelar);  

                this.Size = new Size (500, 800);

                // GUIDE FOR LOCATION n SIZE (X Y) 
                // Location (X = Horizontal - Y = Vertical)
                // Size     (X = Largura    - Y = Altura)
            }
            
            // Link for help
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

            private void VisitLink()
            {
                this.link_help.LinkVisited = true;
                System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe",
                "https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.linklabel.linkclicked?view=netcore-3.1");
            }

            private void clb_Pgto_ItemCheck(object sender,ItemCheckEventArgs e)
                {
                    for(int i = 0; i < clb_Pgto.Items.Count; i ++)
                        if (i != e.Index) clb_Pgto.SetItemChecked(i, false);
                }

            // Confirm button - Printing of inserted data
            private void btn_ConfirmarClick (object sender, EventArgs e)
            {
                string filmes = "";
                string promocoes = "";
                string pagtos = "";

                foreach (string filme in lb_Filmes.SelectedItems)
                    filmes += " " + filme;

                foreach (ListViewItem promocao in lv_Promocoes.SelectedItems)
                    promocoes += " " + promocao.Text;

                foreach (string pagto in clb_Pgto.CheckedItems)
                    pagtos += " " + pagto;

                MessageBox.Show (
                    $"Nome:> {rtxt_Nome.Text}\n" +
                    $"Data Nascimento:> {num_DataNascDia.Value + "/" + num_DataNascMes.Value + "/" +  num_DataNascAno.Value}\n" +
                    $"C.P.F.:> {rtxt_CPF.Text}\n" +
                    $"Dias Devolução:> {cb_DiasDevol.Text}\n" +
                    $"Tipo CLiente:> {(this.rb_Simples.Checked == true ? "CLIENTE BASICO" : this.rb_Normal.Checked ? "CLIENTE REGULAR" : this.rb_Premium.Checked ? "CLIENTE PREMIUM" : "")}\n" +
                    $"NewLetter:> {(this.chk_SMS.Checked == true ? "SMS -" : "")}" +
                    $" {(this.chk_Email.Checked == true ? "E-mail -" : "")}" +
                    $" {(this.chk_WhatsApp.Checked == true ? "WhatsApp" : "")}\n" +
                    $"Especial Inicio:> {this.mc_DataLocacao.SelectionRange.Start}\n" +
                    $"Especial Final:> {this.mc_DataLocacao.SelectionRange.End}\n" +
                    $"Data Locação:> {this.dp_DataLocacao.Value}\n" +
                    $"Filmes:> {filmes}\n" +
                    $"Promoção:> {promocoes}\n" +
                    $"Forma de Pagto:> {pagtos}\n",
                    "Cliente",
                    MessageBoxButtons.OK
                );
            }

            // Cancel button - Close the window
            private void btn_CancelarClick (object sender, EventArgs e) 
            {
                this.Close();
            }
        }
    }
}