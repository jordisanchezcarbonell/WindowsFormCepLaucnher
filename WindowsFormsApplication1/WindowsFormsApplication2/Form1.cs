using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BespokeFusion;

namespace WindowsFormsApplication2
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, Primary.Blue100,
                Primary.Blue100, Accent.LightBlue100,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(materialContextMenuStrip1.Text == "admin" || textboxcontra.Text == "1")
            {
                Form2 p = new Form2();
                p.Show();
            }
            else
            {
                //MaterialM.Show("Your cool message here", "The awesome message title");
                MaterialMessageBox.ShowError("Error el usuario");


            }
        }
    }
}
