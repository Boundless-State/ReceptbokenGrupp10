using ReceptbokenGrupp10.Classes;

namespace ReceptbokenGrupp10
{
    public partial class FormRecipe : Form
    {
        List<Recipe> recipeList = new List<Recipe>();
        Filehandler filehandler = new Filehandler();
        string[] categories = { "Kött", "Fisk", "Sallad", "Soppa", "Dessert" };

        public FormRecipe()
        {
            InitializeComponent();


            recipeList = filehandler.ReadAllRecepies();
            

            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }

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
                textBoxRecipe.ReadOnly = true;
                buttonNewRecipe.Visible = true;
                buttonEditRecipe.Visible = true;

                //h�r l�gger vi in Visible = true p �samtliga funktioner och knappar som ska visas n�r man �r inloggad
            }
            else
            {
                labelLogin.Text = "Inloggning misslyckades";
                labelLogin.ForeColor = Color.Red;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            string searchCategory = comboBoxCategory.Text;

            listBoxResult.Items.Clear();

            foreach (Recipe recipe in recipeList)
            {
                if (string.IsNullOrEmpty(searchCategory))
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



        //string searchText = textBoxSearch.Text;
        //string searchCategory = comboBoxCategory.Text;

        //listBoxResult.Items.Clear();

        //if (textBoxSearch.Text == null)
        //{
        //    textBoxSearch.Text = "";

        //}

        //foreach (Recipe recipe in recipeList)
        //{
        //    if (searchCategory == "")
        //    {
        //        if (recipe.Title.ToLower().Contains(searchText.ToLower()))
        //        {
        //            listBoxResult.Items.Add(recipe.Title);

        //        }
        //    }
        //    if (recipe.Category == searchCategory && recipe.Title.ToLower().Contains(searchText.ToLower()))
        //    {
        //        listBoxResult.Items.Add(recipe.Title);
        //    }

        //}



        //}

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;
            textBoxRecipeTitle.Text = selectedRecipe.Title;
            textBoxRecipe.Text = selectedRecipe.Description;
        }


        private void buttonNewRecipe_Click(object sender, EventArgs e)
        {
           

        }


        private void buttonEditRecipe_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;
            FormNewRecipe editRecipe = new FormNewRecipe(selectedRecipe, recipeList, categories);
            editRecipe.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
