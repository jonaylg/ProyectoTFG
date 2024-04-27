namespace ProyectoTFG
{
    partial class FrmRegistroUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxUsuario = new TextBox();
            textBoxClave2 = new TextBox();
            textBoxClave = new TextBox();
            textBoxPregPers = new TextBox();
            textBoxRespuesta = new TextBox();
            textBoxRespuesta2 = new TextBox();
            buttonCrear = new Button();
            buttonAyuda = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 91);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 140);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 189);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Repetir Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 238);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Pregunta Personal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 288);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Respuesta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 339);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 5;
            label6.Text = "Repetir Respuesta";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(283, 88);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(125, 27);
            textBoxUsuario.TabIndex = 6;
            // 
            // textBoxClave2
            // 
            textBoxClave2.Location = new Point(283, 186);
            textBoxClave2.Name = "textBoxClave2";
            textBoxClave2.Size = new Size(125, 27);
            textBoxClave2.TabIndex = 7;
            // 
            // textBoxClave
            // 
            textBoxClave.Location = new Point(283, 137);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(125, 27);
            textBoxClave.TabIndex = 8;
            // 
            // textBoxPregPers
            // 
            textBoxPregPers.Location = new Point(283, 235);
            textBoxPregPers.Name = "textBoxPregPers";
            textBoxPregPers.Size = new Size(316, 27);
            textBoxPregPers.TabIndex = 9;
            // 
            // textBoxRespuesta
            // 
            textBoxRespuesta.Location = new Point(283, 285);
            textBoxRespuesta.Name = "textBoxRespuesta";
            textBoxRespuesta.Size = new Size(125, 27);
            textBoxRespuesta.TabIndex = 10;
            // 
            // textBoxRespuesta2
            // 
            textBoxRespuesta2.Location = new Point(283, 336);
            textBoxRespuesta2.Name = "textBoxRespuesta2";
            textBoxRespuesta2.Size = new Size(125, 27);
            textBoxRespuesta2.TabIndex = 11;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(636, 307);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(99, 52);
            buttonCrear.TabIndex = 12;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonAyuda
            // 
            buttonAyuda.BackColor = Color.PaleGreen;
            buttonAyuda.Location = new Point(243, 234);
            buttonAyuda.Name = "buttonAyuda";
            buttonAyuda.Size = new Size(28, 28);
            buttonAyuda.TabIndex = 13;
            buttonAyuda.Text = "?";
            buttonAyuda.UseVisualStyleBackColor = false;
            buttonAyuda.Click += buttonAyuda_Click;
            // 
            // FrmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAyuda);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxRespuesta2);
            Controls.Add(textBoxRespuesta);
            Controls.Add(textBoxPregPers);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxClave2);
            Controls.Add(textBoxUsuario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistroUsuario";
            Text = "FrmRegistroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxUsuario;
        private TextBox textBoxClave2;
        private TextBox textBoxClave;
        private TextBox textBoxPregPers;
        private TextBox textBoxRespuesta;
        private TextBox textBoxRespuesta2;
        private Button buttonCrear;
        private Button buttonAyuda;
    }
}