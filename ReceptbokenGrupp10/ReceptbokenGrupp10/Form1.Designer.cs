﻿namespace ReceptbokenGrupp10
{
    partial class FormRecipe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxCategory = new ComboBox();
            textBoxSearch = new TextBox();
            listBoxResult = new ListBox();
            buttonSearch = new Button();
            textBoxRecipeTitle = new TextBox();
            buttonLogIn = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxIngredients = new TextBox();
            labelLogin = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 31);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 23);
            comboBoxCategory.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 79);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(446, 23);
            textBoxSearch.TabIndex = 3;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(12, 119);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(546, 214);
            listBoxResult.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(464, 79);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxRecipeTitle
            // 
            textBoxRecipeTitle.Location = new Point(184, 31);
            textBoxRecipeTitle.Name = "textBoxRecipeTitle";
            textBoxRecipeTitle.Size = new Size(374, 23);
            textBoxRecipeTitle.TabIndex = 6;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(705, 119);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(94, 29);
            buttonLogIn.TabIndex = 7;
            buttonLogIn.Text = "Logga in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(674, 32);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(125, 23);
            textBoxUser.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(674, 76);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 23);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(588, 35);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 15);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Användare:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(598, 79);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(59, 15);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Lösenord:";
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(12, 349);
            textBoxIngredients.Multiline = true;
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.ReadOnly = true;
            textBoxIngredients.Size = new Size(546, 264);
            textBoxIngredients.TabIndex = 12;
            textBoxIngredients.Text = "7";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(598, 119);
            labelLogin.Margin = new Padding(2, 0, 2, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(0, 15);
            labelLogin.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(571, 582);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 31);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            // 
            // FormRecipe
            // 
            ClientSize = new Size(832, 633);
            Controls.Add(buttonSave);
            Controls.Add(labelLogin);
            Controls.Add(textBoxIngredients);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxRecipeTitle);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxResult);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxCategory);
            Name = "FormRecipe";
            Text = "Receptboken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxCategory;
        private TextBox textBoxSearch;
        private ListBox listBoxResult;
        private Button buttonSearch;
        private TextBox textBoxRecipeTitle;
        private Button buttonLogIn;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxIngredients;
        private Label labelLogin;
        private Button buttonSave;
    }
}
