namespace ProyectoUnida_
{
    partial class Converiones
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
            Medidas = new ListBox();
            Datos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Medidas
            // 
            Medidas.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Medidas.FormattingEnabled = true;
            Medidas.Items.AddRange(new object[] { "Litros a mililitros", "Mililitros a litros", "Pintas a tazas", "Tazas a pintas", "Cucharadas a onzas líquidas", "Onzas líquidas a cucharadas", "Pies cúbicos a metros cúbicos", "Metros cúbicos a pies cúbicos", "Yardas cúbicas a litros", "Litros a yardas cúbicas" });
            Medidas.Location = new Point(287, 91);
            Medidas.Name = "Medidas";
            Medidas.Size = new Size(212, 180);
            Medidas.TabIndex = 1;
            Medidas.SelectedIndexChanged += Medidas_SelectedIndexChanged;
            // 
            // Datos
            // 
            Datos.Location = new Point(309, 318);
            Datos.Name = "Datos";
            Datos.Size = new Size(171, 23);
            Datos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 41);
            label1.Name = "label1";
            label1.Size = new Size(300, 21);
            label1.TabIndex = 3;
            label1.Text = "Conversiones De Medida De Volumen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtG", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(662, 9);
            label2.Name = "label2";
            label2.Size = new Size(126, 16);
            label2.TabIndex = 4;
            label2.Text = "Oscar Letrán VC";
            // 
            // Converiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Datos);
            Controls.Add(Medidas);
            Name = "Converiones";
            Text = "Conversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Medidas;
        private TextBox Datos;
        private Label label1;
        private Label label2;
    }
}
