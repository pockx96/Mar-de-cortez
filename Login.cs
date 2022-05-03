using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarDeCortezDsk
{
    public partial class Login : Form
    {
        //metodos
        Dictionary<string, string> Usuarios = new Dictionary<string, string>(){    {"useremp", "empleado"},{"passwordemp", "empleado123"}, { "userad", "admin" }, { "passwordad", "admin123" }, { "tester", "Usuario" }, { "testercont", "Contraseña" } };

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void txtBox_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            if (Usuarios["useremp"] == txtBox_user.Text && Usuarios["passwordemp"] == txtBox_psswrd.Text)
            {
                Form bttaeleemp = new MenuElecc();
                this.Hide();
                bttaeleemp.Show();
                lklb_createacoount.Visible = true;

            }
            if (Usuarios["userad"] == txtBox_user.Text && Usuarios["passwordad"] == txtBox_psswrd.Text) {
                Form bttaeleccad = new MenuCotroller();
                this.Hide();
                bttaeleccad.Show();
                lklb_createacoount.Visible = true;
            }
            if (Usuarios["tester"] == txtBox_user.Text && Usuarios["testercont"] == txtBox_psswrd.Text)
            {
                Form bttatester = new TesterScreen();
                this.Hide();
                bttatester.Show();
            }
            else {
                lb_alert.Visible = true;
                lklb_createacoount.Visible = false;
            }
        }
    }
}
