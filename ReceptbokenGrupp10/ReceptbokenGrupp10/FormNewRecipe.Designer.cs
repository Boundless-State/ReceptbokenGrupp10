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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelDescription = new Label();
            labelCategory = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(37, 26);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 138);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(582, 339);
            textBox2.TabIndex = 3;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(37, 115);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(57, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Recipe:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(468, 25);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 20);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(468, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // FormNewRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 575);
            Controls.Add(comboBox1);
            Controls.Add(labelCategory);
            Controls.Add(textBox2);
            Controls.Add(labelDescription);
            Controls.Add(textBox1);
            Controls.Add(labelTitle);
            Name = "FormNewRecipe";
            Text = "FormNewRecipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelDescription;
        private Label labelCategory;
        private ComboBox comboBox1;
    }
}