using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Atividade_Interface
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
            // Text for Guidance
            Label lbl_Nome;
            Label lbl_DataNasc;
            Label lbl_CPF;
            Label lbl_DiasDevol;
            Label lbl_Tipo;
            Label lbl_NewLetter;

            // Data entry boxes
            TextBox txt_Nome;
            TextBox txt_DataNasc;
            TextBox txt_CPF;

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

            // Buttons Print or Close
            Button button_Confirmar;
            Button button_Cancelar; 


            public Formulario ()
            {
                /// <summary>
                /// Main window text
                /// </summary>
                this.Text = "CADASTRO CLIENTE";
                this.BackColor = Color.WhiteSmoke;
                
                // Registration Labels
                lbl_Nome = new Label();
                lbl_Nome.Text = "Nome :";
                lbl_Nome.Location = new Point (20, 20);
                this.Controls.Add(lbl_Nome);

                lbl_DataNasc = new Label();
                lbl_DataNasc.Text = "Data de Nascimento :";
                lbl_DataNasc.AutoSize = true;
                lbl_DataNasc.Location = new Point (20, 60);
                this.Controls.Add(lbl_DataNasc);              

                lbl_CPF = new Label();
                lbl_CPF.Text = "CPF :";
                lbl_CPF.Location = new Point (20, 100);
                this.Controls.Add(lbl_CPF);

                lbl_DiasDevol = new Label();
                lbl_DiasDevol.Text = "Dias P/ Devolução :";
                lbl_DiasDevol.AutoSize = true;
                lbl_DiasDevol.Location = new Point (20, 140);
                this.Controls.Add(lbl_DiasDevol);

                lbl_Tipo = new Label();
                lbl_Tipo.Text = "Tipo de Cliente :";
                lbl_Tipo.AutoSize = true;
                lbl_Tipo.Location = new Point (20, 190); 
                this.Controls.Add(lbl_Tipo); 

                lbl_NewLetter = new Label();
                lbl_NewLetter.Text = "Boletim Informativo :";
                lbl_NewLetter.AutoSize = true;
                lbl_NewLetter.Location = new Point (20, 300); 
                this.Controls.Add(lbl_NewLetter);  

                // Registration entry boxes
                txt_Nome = new TextBox();
                txt_Nome.Location = new Point (150, 20);    
                txt_Nome.Size = new Size(300, 20);                
                this.Controls.Add(txt_Nome);

                txt_DataNasc = new TextBox();
                txt_DataNasc.Location = new Point (150, 60);    
                txt_DataNasc.Size = new Size(150, 20);
                this.Controls.Add(txt_DataNasc);

                txt_CPF = new TextBox();
                txt_CPF.Location = new Point (150, 100);    
                txt_CPF.Size = new Size(300, 20);
                this.Controls.Add(txt_CPF);

                // Three options - Single choice
                rb_Basic = new RadioButton();
                rb_Basic.Location = new Point (180, 180);
                rb_Basic.Size = new Size (180, 30);
                rb_Basic.Text = "BASIC - 5% Desc"; 
                this.Controls.Add(rb_Basic);

                rb_Class = new RadioButton();
                rb_Class.Location = new Point (180, 210);
                rb_Class.Size = new Size (180, 30);
                rb_Class.Text = "CLASS - 10% Desc"; 
                this.Controls.Add(rb_Class);

                rb_Premium = new RadioButton();
                rb_Premium.Location = new Point (180, 240);
                rb_Premium.Size = new Size (180, 30);
                rb_Premium.Text = "PREMIUM - 15% Desc"; 
                this.Controls.Add(rb_Premium);

                // Five options - Single choice
                cb_DiasDevol = new ComboBox();
                cb_DiasDevol.Items.Add("2 Dias");
                cb_DiasDevol.Items.Add("3 Dias");
                cb_DiasDevol.Items.Add("4 Dias");
                cb_DiasDevol.Items.Add("5 Dias");
                cb_DiasDevol.Items.Add("PLUS Plan");
                cb_DiasDevol.AutoCompleteMode = AutoCompleteMode.Append;
                cb_DiasDevol.Location = new Point (150, 140);    
                cb_DiasDevol.Size = new Size(150, 20);
                this.Controls.Add(cb_DiasDevol);

                // Three options - Multiple choice
                chk_SMS = new CheckBox();
                chk_SMS.Location = new Point (180, 290);
                chk_SMS.Size = new Size (180, 30);
                chk_SMS.Text = "NewLetter Via SMS"; 
                this.Controls.Add(chk_SMS);

                chk_Email = new CheckBox();
                chk_Email.Location = new Point (180, 320);
                chk_Email.Size = new Size (180, 30);
                chk_Email.Text = "NewLetter Via E-mail"; 
                this.Controls.Add(chk_Email);

                chk_WhatsApp = new CheckBox();
                chk_WhatsApp.Location = new Point (180, 350);
                chk_WhatsApp.Size = new Size (180, 30);
                chk_WhatsApp.Text = "NewLetter Via WhatsApp"; 
                this.Controls.Add(chk_WhatsApp);

                // Location (X = Horizontal - Y = Vertical)
                // Size     (X = Largura    - Y = Altura)

                // Finishing buttons
                button_Confirmar = new Button();
                button_Confirmar.Text = "CONFIRMAR";
                button_Confirmar.Size = new Size(150, 40);
                button_Confirmar.Location = new Point(80, 410);
                button_Confirmar.Click += new EventHandler (this.button_ConfirmarClick);
                this.Controls.Add(button_Confirmar);

                button_Cancelar = new Button();
                button_Cancelar.Text = "CANCELAR";
                button_Cancelar.Size = new Size(150, 40);
                button_Cancelar.Location = new Point(260, 410);
                button_Cancelar.Click += new EventHandler (this.button_CancelarClick);
                this.Controls.Add(button_Cancelar);  
                
                this.Size = new Size (500, 550);
            }

            // Confirm button - Printing of inserted data
            private void button_ConfirmarClick (object sender, EventArgs e)
            {
                MessageBox.Show (
                    $"Nome:> {txt_Nome.Text}\n" +
                    $"Data Nascimento:> {txt_DataNasc.Text}\n" +
                    $"C.P.F.:> {txt_CPF.Text}\n" +
                    $"Dias Devolução:> {cb_DiasDevol.Text}\n" +
                    $"Tipo CLiente:> {(this.rb_Basic.Checked == true ? "BASIC - 5%" : this.rb_Class.Checked ? "CLASS - 10%" : "PREMIUM - 15%")}\n" +
                    $"NewLetter:> {(this.chk_SMS.Checked == true ? "SMS " : this.chk_Email.Checked == true ? "E-Email" : this.chk_WhatsApp.Checked == true ? "WhatsApp" : "Indefinido")}\n",
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