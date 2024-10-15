using ReceptbokenGrupp10.Classes;

namespace ReceptbokenGrupp10
{
    public partial class FormRecipe : Form
    {
        List<Recipe> recipeList = new List<Recipe>();
        Filehandler filehandler = new Filehandler();
        string[] categories = { "Alla", "Kött", "Fisk", "Sallad", "Soppa", "Dessert" };

        public FormRecipe()
        {
            InitializeComponent();


            recipeList = filehandler.ReadAllRecepies();

            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }

            Search();
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
                textBoxRecipe.ReadOnly = false;
                buttonNewRecipe.Visible = true;
                buttonEditRecipe.Visible = true;
                buttonDeleteRecipe.Visible = true;

                //h�r l�gger vi in Visible = true p �samtliga funktioner och knappar som ska visas n�r man �r inloggad
            }
            else
            {
                labelLogin.Text = "Inloggning misslyckades";
                labelLogin.ForeColor = Color.Red;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            string searchText = textBoxSearch.Text;
            string searchCategory = comboBoxCategory.Text;

            listBoxResult.Items.Clear();

            foreach (Recipe recipe in recipeList)
            {
                if (string.IsNullOrEmpty(searchCategory) || searchCategory == "Alla")
                {
                    if (recipe.Title.ToLower().Contains(searchText.ToLower()))
                    {
                        listBoxResult.Items.Add(recipe);  // Add full Recipe object
                    }
                }
                else if (recipe.Category == searchCategory && recipe.Title.ToLower().Contains(searchText.ToLower()))
                {
                    listBoxResult.Items.Add(recipe);  // Add full Recipe object
                }
            }
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;

                textBoxRecipeTitle.Text = selectedRecipe.Title;
                textBoxRecipe.Text = selectedRecipe.Description;
                buttonEditRecipe.Enabled = true;
                buttonDeleteRecipe.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonNewRecipe_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;
            FormNewRecipe newRecipe = new FormNewRecipe(recipeList, categories);
            newRecipe.ShowDialog();
        }

        private void buttonEditRecipe_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;
            FormNewRecipe editRecipe = new FormNewRecipe(selectedRecipe, recipeList, categories);
            editRecipe.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {
            
            // Kontrollera att ett recept är valt i listBox
            if (listBoxResult.SelectedItem != null)
            {
                
                Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;

                
                DialogResult dialogResult = MessageBox.Show(
                    $"Är du säker på att du vill ta bort receptet '{selectedRecipe.Title}'?",
                    "Bekräfta borttagning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                
                if (dialogResult == DialogResult.Yes)
                {
                    
                    recipeList.Remove(selectedRecipe);
                    Filehandler filehandler = new Filehandler();
                    filehandler.WriteToFile(recipeList);
                    listBoxResult.Items.Remove(selectedRecipe);

                    // Eventuell feedback till användaren om att borttagningen lyckades
                    MessageBox.Show("Receptet har tagits bort.", "Borttagning klar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
