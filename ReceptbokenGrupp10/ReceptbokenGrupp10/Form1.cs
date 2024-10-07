using ReceptbokenGrupp10.Classes;

namespace ReceptbokenGrupp10
{
    public partial class FormRecipe : Form
    {
 

        public FormRecipe()
        {
            InitializeComponent();
           
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        { 
            string enteredUsername = textBoxUser.Text;
            string enteredPassword = textBoxPassword.Text;

            string correctUsername = "Admin";
            string correctPassword = "Password";

            

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                labelLogin.Text = "Inloggning lyckades!";
                labelLogin.ForeColor = Color.Green;
                textBoxIngredients.ReadOnly = false;
                buttonSave.Visible = true;

                //h�r l�gger vi in Visible = true p �samtliga funktioner och knappar som ska visas n�r man �r inloggad
            }
            else
            {
                labelLogin.Text = "Inloggning misslyckades";
                labelLogin.ForeColor = Color.Red;
            }
        }
       

    }
}
