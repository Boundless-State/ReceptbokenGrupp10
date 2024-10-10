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
            labelTitle.Location = new Point(37, 26);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Titel";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(37, 49);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Titel";
            textBoxTitle.Size = new Size(407, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(37, 115);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(58, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Recept:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(468, 25);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(66, 20);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Kategori";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(468, 48);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(525, 500);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxRecipe
            // 
            textBoxRecipe.Location = new Point(37, 138);
            textBoxRecipe.Name = "textBoxRecipe";
            textBoxRecipe.Size = new Size(582, 356);
            textBoxRecipe.TabIndex = 7;
            textBoxRecipe.Text = "";
            // 
            // FormNewRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 554);
            Controls.Add(textBoxRecipe);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(labelDescription);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
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