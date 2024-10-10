using ReceptbokenGrupp10.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptbokenGrupp10
{
    public partial class FormNewRecipe : Form
    {

        private List<Recipe> _recipeList;
        public FormNewRecipe(Recipe newRecipe, List<Recipe> recipeList, string[] categories)
        {
            InitializeComponent();
            Recipe recipe = new Recipe();
            recipe = newRecipe;
            _recipeList = recipeList;
            textBoxTitle.Text = recipe.Title;
            textBoxRecipe.Text = recipe.Description;
            comboBoxCategory.Text = recipe.Category;

            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);

            }

            recipeList.Remove(recipe);




        }

        public FormNewRecipe(List<Recipe> recipeList, string[] categories)
        {
            InitializeComponent();
            
            _recipeList = recipeList;

            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);

            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Recipe newRecipe = new Recipe();
            Filehandler filehandler = new Filehandler();
            newRecipe.Title = textBoxTitle.Text;
            newRecipe.Description = textBoxRecipe.Text;
            newRecipe.Category = comboBoxCategory.Text;

            _recipeList.Add(newRecipe);
            filehandler.WriteToFile(_recipeList);

        }
    }
}
