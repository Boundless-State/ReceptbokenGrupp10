using ReceptbokenGrupp10.Classes;

namespace ReceptbokenGrupp10
{
    public partial class FormRecipe : Form
    {
        List<Recipe> recipeList = new List<Recipe>();
        Filehandler filehandler = new Filehandler();


        ErrorLogger errorLogger = new ErrorLogger();

        List<string> categories = new List<string>();


        public FormRecipe()
        {
            InitializeComponent();

            recipeList = filehandler.ReadAllRecepies();

            UpdateUI();
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBoxUser.Text;
            string enteredPassword = textBoxPassword.Text;

            string correctUsername = "Admin";
            string correctPassword = "Password";

            try
            {
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
            catch (Exception ex)
            {

                Console.WriteLine($"Login Error: {ex.Message}");
                errorLogger.LogCustomError(ex);
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
            try
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
            catch (Exception s)
            {

                Console.WriteLine($"Search error: {s.Message}" );
                errorLogger.LogCustomError(s);
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
            catch (Exception i)
            {
                Console.WriteLine($"Invalid seleted index {i.Message}");
                errorLogger.LogCustomError(i);

            }
        }

        private void buttonNewRecipe_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;
            FormNewRecipe newRecipe = new FormNewRecipe(recipeList, categories);
            newRecipe.ShowDialog();
            UpdateUI();
        }

        private void buttonEditRecipe_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)listBoxResult.SelectedItem;
            FormNewRecipe editRecipe = new FormNewRecipe(selectedRecipe, recipeList, categories);
            editRecipe.ShowDialog();
            UpdateUI();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteRecipe_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception d)
            {
                Console.WriteLine($"Delete error {d.Message}");
                errorLogger.LogCustomError(d);
            }
           
           
        }

        public List<string> GetAllCategories()
        {
            List <string> categories = new List<string>();

            categories.Add("Alla");

            foreach (Recipe recipe in recipeList)
            {
                if (!categories.Contains(recipe.Category))
                {
                    categories.Add(recipe.Category);
                }

            }

            return categories;
        }
        
        public void UpdateUI()
        {
            categories = GetAllCategories();
            recipeList = recipeList.OrderBy(recipe => recipe.Title).ToList();

            comboBoxCategory.Items.Clear();
            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }

            listBoxResult.Items.Clear();
            Search();


        }
    
    
    }


    
}
