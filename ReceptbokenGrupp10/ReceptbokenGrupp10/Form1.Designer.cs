namespace ReceptbokenGrupp10
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
            label2 = new Label();
            textBoxIngredients = new TextBox();
            labelLogin = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(18, 46);
            comboBoxCategory.Margin = new Padding(4, 4, 4, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(224, 38);
            comboBoxCategory.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(18, 118);
            textBoxSearch.Margin = new Padding(4, 4, 4, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(667, 35);
            textBoxSearch.TabIndex = 3;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 30;
            listBoxResult.Location = new Point(18, 178);
            listBoxResult.Margin = new Padding(4, 4, 4, 4);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(817, 334);
            listBoxResult.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(696, 118);
            buttonSearch.Margin = new Padding(4, 4, 4, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(141, 44);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxRecipeTitle
            // 
            textBoxRecipeTitle.Location = new Point(276, 46);
            textBoxRecipeTitle.Margin = new Padding(4, 4, 4, 4);
            textBoxRecipeTitle.Name = "textBoxRecipeTitle";
            textBoxRecipeTitle.Size = new Size(559, 35);
            textBoxRecipeTitle.TabIndex = 6;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(1058, 178);
            buttonLogIn.Margin = new Padding(4, 4, 4, 4);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(141, 44);
            buttonLogIn.TabIndex = 7;
            buttonLogIn.Text = "Logga in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(1011, 48);
            textBoxUser.Margin = new Padding(4, 4, 4, 4);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(186, 35);
            textBoxUser.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(1011, 114);
            textBoxPassword.Margin = new Padding(4, 4, 4, 4);
            textBoxPassword.Name = "textBoxPassword";

            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(125, 27);

            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(882, 52);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(118, 30);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Användare:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(897, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 11;
            label2.Text = "Lösenord:";
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(18, 524);
            textBoxIngredients.Margin = new Padding(4, 4, 4, 4);
            textBoxIngredients.Multiline = true;
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.ReadOnly = true;
            textBoxIngredients.Size = new Size(817, 394);
            textBoxIngredients.TabIndex = 12;
            textBoxIngredients.Text = "7";
            
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(598, 152);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(0, 20);
            labelLogin.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(577, 584);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            // 
            // FormRecipe
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(832, 633);
            Controls.Add(buttonSave);
            Controls.Add(labelLogin);


            Controls.Add(textBoxIngredients);
            Controls.Add(label2);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxRecipeTitle);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxResult);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxCategory);
            Margin = new Padding(4, 4, 4, 4);
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
        private Label label2;
        private TextBox textBoxIngredients;
        private Label labelLogin;
        private Button buttonSave;
    }
}
