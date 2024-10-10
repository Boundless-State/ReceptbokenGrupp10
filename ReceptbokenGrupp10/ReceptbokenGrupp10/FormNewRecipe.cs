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
        public FormNewRecipe(Recipe newRecipe,List<Recipe> recipeList, string[] categories)
        {
            InitializeComponent();
            Recipe recipe = new Recipe();
            recipe = newRecipe;
            textBoxTitle.Text = recipe.Title;
            textBoxRecipe.Text = recipe.Description;
            comboBoxCategory.Text = recipe.Category;

            foreach (string category in categories)
            {
                comboBoxCategory.Items.Add(category);
                
            }
            
        }
    }
}
