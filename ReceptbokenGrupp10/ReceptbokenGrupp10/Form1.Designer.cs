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
            textBoxRecipeTitle = new TextBox();
            buttonLogIn = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            labelLogin = new Label();

            textBoxRecipe = new RichTextBox();
            buttonNewRecipe = new Button();
            buttonEditRecipe = new Button();
            buttonClose = new Button();

            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 31);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(225, 38);
            comboBoxCategory.TabIndex = 2;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 74);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Sök";
            textBoxSearch.Size = new Size(225, 35);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;

            listBoxResult.Location = new Point(12, 131);


            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(225, 404);
            listBoxResult.TabIndex = 4;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // textBoxRecipeTitle
            // 
            textBoxRecipeTitle.Font = new Font("Segoe UI", 14F);
            textBoxRecipeTitle.Location = new Point(269, 31);
            textBoxRecipeTitle.Name = "textBoxRecipeTitle";
            textBoxRecipeTitle.PlaceholderText = "Titel";
            textBoxRecipeTitle.Size = new Size(374, 51);
            textBoxRecipeTitle.TabIndex = 6;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(936, 19);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(94, 29);
            buttonLogIn.TabIndex = 7;
            buttonLogIn.Text = "Logga in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(777, 16);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(125, 35);
            textBoxUser.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(777, 60);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 35);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(691, 19);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(118, 30);
            labelUsername.TabIndex = 10;
            labelUsername.Text = "Användare:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(701, 63);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(103, 30);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Lösenord:";
            // 
            // textBoxRecipe
            // 
            textBoxRecipe.Location = new Point(269, 102);
            textBoxRecipe.Multiline = true;
            textBoxRecipe.Name = "textBoxRecipe";
            textBoxRecipe.ReadOnly = true;
            textBoxRecipe.Size = new Size(761, 419);
            textBoxRecipe.TabIndex = 12;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(936, 63);
            labelLogin.Margin = new Padding(2, 0, 2, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(0, 30);
            labelLogin.TabIndex = 13;
            // 

            // textBoxRecipe
            // 
            textBoxRecipe.Location = new Point(287, 131);
            textBoxRecipe.Name = "textBoxRecipe";
            textBoxRecipe.Size = new Size(708, 404);
            textBoxRecipe.TabIndex = 17;
            textBoxRecipe.Text = "";

            // 
            // buttonNewRecipe
            // 
            buttonNewRecipe.Location = new Point(620, 541);
            buttonNewRecipe.Margin = new Padding(2);
            buttonNewRecipe.Name = "buttonNewRecipe";
            buttonNewRecipe.Size = new Size(133, 31);
            buttonNewRecipe.TabIndex = 14;
            buttonNewRecipe.Text = "Nytt Recept";
            buttonNewRecipe.UseVisualStyleBackColor = true;
            buttonNewRecipe.Visible = false;
            buttonNewRecipe.Click += buttonNewRecipe_Click;
            // 
            // buttonEditRecipe
            // 
            buttonEditRecipe.Location = new Point(758, 542);
            buttonEditRecipe.Name = "buttonEditRecipe";
            buttonEditRecipe.Size = new Size(133, 29);
            buttonEditRecipe.TabIndex = 15;
            buttonEditRecipe.Text = "Redigera Recept";
            buttonEditRecipe.UseVisualStyleBackColor = true;
            buttonEditRecipe.Visible = false;
            buttonEditRecipe.Click += buttonEditRecipe_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(897, 542);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(133, 29);
            buttonClose.TabIndex = 16;
            buttonClose.Text = "Stäng";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormRecipe
            // 
            ClientSize = new Size(1042, 594);

            Controls.Add(buttonClose);
            Controls.Add(buttonEditRecipe);
            Controls.Add(buttonNewRecipe);
            Controls.Add(textBoxRecipe);
            Controls.Add(labelLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxRecipeTitle);
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
        private TextBox textBoxRecipeTitle;
        private Button buttonLogIn;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelLogin;
        private Button buttonEditRecipe;
        private Button buttonClose;
        private RichTextBox textBoxRecipe;
        private Button buttonNewRecipe;

    }
}
