using SistemaHotel.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    public partial class loginDlg : Form
    {
        public loginDlg()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void msgerr(String msg)
        {
            if(MessageBox.Show(this, msg, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
            {
                return;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usrname = usrnameTxt.Text, pswd = pswdTxt.Text;
            if(usrname == "" || pswd== "")
            {
                msgerr("Rellene todos los campos!");
                return;
            }
            try
            {
                string ans=Clogin.log_in(usrname, pswd);
                if (ans.Equals("GRANTED"))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show(this, "Bienvenido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    msgerr("Usuario o Contraseña Incorrecta");
                }
            }
            catch(Exception ex)
            {
                msgerr(ex.Message);
            }

        }
    }
}
