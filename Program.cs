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
            Label lbl_DataNasc;
            Label lbl_Dia;
            Label lbl_Mes;
            Label lbl_Ano;
            Label lbl_CPF;
            Label lbl_DiasDevol;
            Label lbl_Tipo;
            Label lbl_NewLetter;

            // Data entry boxes with rich way
            RichTextBox txt_Nome;
            // Data entry numeric system selection up/down
            NumericUpDown num_DataNascDia;
            NumericUpDown num_DataNascMes;
            NumericUpDown num_DataNascAno;

            // Data entry boxes masked
            MaskedTextBox txt_CPF;

            // Single Selection Button
            RadioButton rb_Basic;
            RadioButton rb_Class;
            RadioButton rb_Premium;

            // Selection Box  - Single Selection
            ComboBox cb_DiasDevol;

            // Selection multiple options
            CheckBox chk_Email;
            CheckBox chk_WhatsApp;
            CheckBox chk_SMS; 

            // Link for help
            LinkLabel link_help;

            // Buttons Print or Close
            Button button_Confirmar;
            Button button_Cancelar; 

            // GUIDE FOR LOCATION n SIZE (X Y) 
            // Location (X = Horizontal - Y = Vertical)
            // Size     (X = Largura    - Y = Altura)
            public Formulario ()
            {
                // Main window text
                this.Text = "CADASTRO CLIENTE - BLOCKBUSTER";
                this.BackColor = Color.WhiteSmoke;

                // Image by Senac 
                pb_Imagem = new PictureBox();
                pb_Imagem.Location = new Point (200, 10);    
                pb_Imagem.Size = new Size(120, 100);
                pb_Imagem.ClientSize = new Size (120 , 100);
                pb_Imagem.Load ("Imagem.jpg");
                pb_Imagem.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pb_Imagem);
                
                // Registration Labels
                lbl_Nome = new Label();
                lbl_Nome.Text = "Nome :";
                lbl_Nome.Location = new Point (20, 120);
                this.Controls.Add(lbl_Nome);

                lbl_DataNasc = new Label();
                lbl_DataNasc.Text = "Data de Nascimento :";
                lbl_DataNasc.AutoSize = true;
                lbl_DataNasc.Location = new Point (20, 160);
                this.Controls.Add(lbl_DataNasc);

                lbl_Dia = new Label();
                lbl_Dia.Text = "DIA";
                lbl_Dia.AutoSize = true;
                lbl_Dia.Location = new Point (150, 160);
                this.Controls.Add(lbl_Dia);

                lbl_Mes = new Label();
                lbl_Mes.Text = "MÊS";
                lbl_Mes.AutoSize = true;
                lbl_Mes.Location = new Point (200, 160);
                this.Controls.Add(lbl_Mes);

                lbl_Ano = new Label();
                lbl_Ano.Text = "ANO";
                lbl_Ano.AutoSize = true;
                lbl_Ano.Location = new Point (250, 160);
                this.Controls.Add(lbl_Ano);        

                lbl_CPF = new Label();
                lbl_CPF.Text = "CPF :";
                lbl_CPF.Location = new Point (20, 220);
                this.Controls.Add(lbl_CPF);

                lbl_DiasDevol = new Label();
                lbl_DiasDevol.Text = "Dias P/ Devolução :";
                lbl_DiasDevol.AutoSize = true;
                lbl_DiasDevol.Location = new Point (20, 260);
                this.Controls.Add(lbl_DiasDevol);

                lbl_Tipo = new Label();
                lbl_Tipo.Text = "Tipo de Cliente :";
                lbl_Tipo.AutoSize = true;
                lbl_Tipo.Location = new Point (20, 300); 
                this.Controls.Add(lbl_Tipo); 

                lbl_NewLetter = new Label();
                lbl_NewLetter.Text = "Boletim Informativo :";
                lbl_NewLetter.AutoSize = true;
                lbl_NewLetter.Location = new Point (20, 400); 
                this.Controls.Add(lbl_NewLetter);

                // Registration entry boxes
                txt_Nome = new RichTextBox();
                txt_Nome.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);  
                txt_Nome.SelectionColor = System.Drawing.Color.Blue;
                txt_Nome.Location = new Point (150, 120);    
                txt_Nome.Size = new Size(300, 20);                
                this.Controls.Add(txt_Nome);

                // Numeric Up and Down - Date of birth selection
                num_DataNascDia = new NumericUpDown();
                num_DataNascDia.Location = new Point (150, 180);    
                num_DataNascDia.Size = new Size(50, 20);
                num_DataNascDia.Minimum = 1;
                num_DataNascDia.Maximum = 31;
                this.Controls.Add(num_DataNascDia);

                num_DataNascMes = new NumericUpDown();
                num_DataNascMes.Location = new Point (200, 180);    
                num_DataNascMes.Size = new Size(50, 20);
                num_DataNascMes.Minimum = 1;
                num_DataNascMes.Maximum = 12;
                this.Controls.Add(num_DataNascMes);

                num_DataNascAno = new NumericUpDown();
                num_DataNascAno.Location = new Point (250, 180);    
                num_DataNascAno.Size = new Size(50, 20);
                num_DataNascAno.Minimum = 1950;
                num_DataNascAno.Maximum = 2020;
                this.Controls.Add(num_DataNascAno);

                // MaskedTextBox - Data editing interface
                txt_CPF = new MaskedTextBox();
                txt_CPF.Location = new Point (150, 220);    
                txt_CPF.Size = new Size(300, 20);
                txt_CPF.Mask = "000,000,000-00";
                this.Controls.Add(txt_CPF);

                // ComboBox - Five options - Single choice
                cb_DiasDevol = new ComboBox();
                cb_DiasDevol.Items.Add("2 Dias");
                cb_DiasDevol.Items.Add("3 Dias");
                cb_DiasDevol.Items.Add("4 Dias");
                cb_DiasDevol.Items.Add("5 Dias");
                cb_DiasDevol.Items.Add("PLUS Plan");
                cb_DiasDevol.AutoCompleteMode = AutoCompleteMode.Append;
                cb_DiasDevol.Location = new Point (150, 260);    
                cb_DiasDevol.Size = new Size(150, 20);
                this.Controls.Add(cb_DiasDevol);

                // RadioButton - Three options - Single choice
                rb_Basic = new RadioButton();
                rb_Basic.Location = new Point (160, 290);
                rb_Basic.Size = new Size (180, 30);
                rb_Basic.Text = "BASIC - 5% Desc"; 
                this.Controls.Add(rb_Basic);

                rb_Class = new RadioButton();
                rb_Class.Location = new Point (160, 320);
                rb_Class.Size = new Size (180, 30);
                rb_Class.Text = "CLASS - 10% Desc"; 
                this.Controls.Add(rb_Class);

                rb_Premium = new RadioButton();
                rb_Premium.Location = new Point (160, 350);
                rb_Premium.Size = new Size (180, 30);
                rb_Premium.Text = "PREMIUM - 15% Desc"; 
                this.Controls.Add(rb_Premium);

                // CheckBob - Three options - Multiple choice
                chk_SMS = new CheckBox();
                chk_SMS.Location = new Point (160, 390);
                chk_SMS.Size = new Size (180, 30);
                chk_SMS.Text = "NewLetter Via SMS"; 
                this.Controls.Add(chk_SMS);

                chk_Email = new CheckBox();
                chk_Email.Location = new Point (160, 420);
                chk_Email.Size = new Size (180, 30);
                chk_Email.Text = "NewLetter Via E-mail"; 
                this.Controls.Add(chk_Email);

                chk_WhatsApp = new CheckBox();
                chk_WhatsApp.Location = new Point (160, 450);
                chk_WhatsApp.Size = new Size (180, 30);
                chk_WhatsApp.Text = "NewLetter Via WhatsApp"; 
                this.Controls.Add(chk_WhatsApp);

                // LinkLabel - Access to site for help 
                this.link_help = new System.Windows.Forms.LinkLabel();
                this.link_help.Location = new System.Drawing.Point (180, 480);
                this.link_help.AutoSize = true;
                this.link_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForHelp_LinkClicked);
                this.link_help.Text = "Ajuda com Link Label";
                this.ClientSize = new System.Drawing.Size(292, 266);
                this.Controls.AddRange(new System.Windows.Forms.Control[] { this.link_help });
                this.Text = "Simple Link Label Example";

                // Finishing buttons
                button_Confirmar = new Button();
                button_Confirmar.Text = "CONFIRMAR";
                button_Confirmar.Size = new Size(150, 40);
                button_Confirmar.Location = new Point(80, 510);
                button_Confirmar.Click += new EventHandler (this.button_ConfirmarClick);
                this.Controls.Add(button_Confirmar);

                button_Cancelar = new Button();
                button_Cancelar.Text = "CANCELAR";
                button_Cancelar.Size = new Size(150, 40);
                button_Cancelar.Location = new Point(260, 510);
                button_Cancelar.Click += new EventHandler (this.button_CancelarClick);
                this.Controls.Add(button_Cancelar);  
                
                this.Size = new Size (500, 600);
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
                   MessageBox.Show("Unable to open link that was clicked."); 
                }
            }
            private void VisitLink()
            {
                this.link_help.LinkVisited = true;
                System.Diagnostics.Process.Start("https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.linklabel.linkclicked?view=netcore-3.1");
            }

            // Confirm button - Printing of inserted data
            private void button_ConfirmarClick (object sender, EventArgs e)
            {
                MessageBox.Show (
                    $"Nome:> {txt_Nome.Text}\n" +
                    $"Data Nascimento:> {num_DataNascDia.Value + "/" + num_DataNascMes.Value + "/" +  num_DataNascAno.Value}\n" +
                    $"C.P.F.:> {txt_CPF.Text}\n" +
                    $"Dias Devolução:> {cb_DiasDevol.Text}\n" +
                    $"Tipo CLiente:> {(this.rb_Basic.Checked == true ? "BASIC - 5%" : this.rb_Class.Checked ? "CLASS - 10%" : this.rb_Premium.Checked ? "PREMIUM - 15%" : "")}\n" +
                    $"NewLetter:> {(this.chk_SMS.Checked == true ? "SMS -" : "")}" +
                    $" {(this.chk_Email.Checked == true ? "E-mail -" : "")}" +
                    $" {(this.chk_WhatsApp.Checked == true ? "WhatsApp" : "")}\n",
                    "Cliente",
                    MessageBoxButtons.OK
                );
            }

            // Cancel button - Close the window
            private void button_CancelarClick (object sender, EventArgs e) 
            {
                this.Close();
            }
        }
    }
}