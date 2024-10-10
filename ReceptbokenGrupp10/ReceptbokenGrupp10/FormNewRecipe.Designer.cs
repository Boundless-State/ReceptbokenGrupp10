namespace ReceptbokenGrupp10
{
    partial class FormNewRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelDescription = new Label();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            buttonSave = new Button();
            textBoxRecipe = new RichTextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(46, 32);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(44, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Titel";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(46, 61);
            textBoxTitle.Margin = new Padding(4, 4, 4, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Titel";
            textBoxTitle.Size = new Size(508, 31);
            textBoxTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(46, 144);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(69, 25);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Recept:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(585, 31);
            labelCategory.Margin = new Padding(4, 0, 4, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(78, 25);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Kategori";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(585, 60);
            comboBoxCategory.Margin = new Padding(4, 4, 4, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(188, 33);
            comboBoxCategory.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(656, 625);
            buttonSave.Margin = new Padding(4, 4, 4, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(118, 36);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxRecipe
            // 
            textBoxRecipe.Location = new Point(46, 172);
            textBoxRecipe.Margin = new Padding(4, 4, 4, 4);
            textBoxRecipe.Name = "textBoxRecipe";
            textBoxRecipe.Size = new Size(726, 444);
            textBoxRecipe.TabIndex = 7;
            textBoxRecipe.Text = "";
            // 
            // FormNewRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 692);
            Controls.Add(textBoxRecipe);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(labelDescription);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormNewRecipe";
            Text = "Nytt recept";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelDescription;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Button buttonSave;
        private RichTextBox textBoxRecipe;
    }
}