namespace bdd_5to_3parcial.clases
{
    partial class Editar_Nota
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
            txtTitulo = new TextBox();
            txtContenido = new RichTextBox();
            txtTags = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(53, 39);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(270, 27);
            txtTitulo.TabIndex = 0;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(53, 72);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(399, 243);
            txtContenido.TabIndex = 1;
            txtContenido.Text = "";
            // 
            // txtTags
            // 
            txtTags.Location = new Point(53, 321);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(270, 27);
            txtTags.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(395, 319);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 4;
            label1.Text = "Vista De Nota";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 328);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 9;
            label3.Text = "Tag:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 8;
            label2.Text = "Texto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 39);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Titulo:";
            // 
            // Editar_Nota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(518, 390);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtTags);
            Controls.Add(txtContenido);
            Controls.Add(txtTitulo);
            Name = "Editar_Nota";
            Text = "Editar_Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private RichTextBox txtContenido;
        private TextBox txtTags;
        private Button btnGuardar;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}