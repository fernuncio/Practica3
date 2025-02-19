namespace Practica3
{
    partial class Fechas
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
            dtpNacimiento = new DateTimePicker();
            dtpCalculo = new DateTimePicker();
            buttonCalcular = new Button();
            label3 = new Label();
            textBoxCurp = new TextBox();
            buttonDatos = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelNac = new Label();
            labelSexo = new Label();
            labelEdo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 0;
            label1.Text = "FECHA DE NACIMIENTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 1;
            label2.Text = "FECHA DE CALCULO:";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNacimiento.Location = new Point(12, 48);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 23);
            dtpNacimiento.TabIndex = 2;
            // 
            // dtpCalculo
            // 
            dtpCalculo.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCalculo.Location = new Point(12, 123);
            dtpCalculo.Name = "dtpCalculo";
            dtpCalculo.Size = new Size(200, 23);
            dtpCalculo.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.SaddleBrown;
            buttonCalcular.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcular.ForeColor = Color.White;
            buttonCalcular.Location = new Point(246, 70);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(122, 40);
            buttonCalcular.TabIndex = 4;
            buttonCalcular.Text = "CALCULAR";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += CALCULAR_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 5;
            label3.Text = "CURP:";
            // 
            // textBoxCurp
            // 
            textBoxCurp.CharacterCasing = CharacterCasing.Upper;
            textBoxCurp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCurp.Location = new Point(75, 177);
            textBoxCurp.MaxLength = 18;
            textBoxCurp.Name = "textBoxCurp";
            textBoxCurp.Size = new Size(182, 29);
            textBoxCurp.TabIndex = 6;
            // 
            // buttonDatos
            // 
            buttonDatos.BackColor = Color.SaddleBrown;
            buttonDatos.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDatos.ForeColor = Color.White;
            buttonDatos.Location = new Point(277, 171);
            buttonDatos.Name = "buttonDatos";
            buttonDatos.Size = new Size(91, 40);
            buttonDatos.TabIndex = 7;
            buttonDatos.Text = "DATOS";
            buttonDatos.UseVisualStyleBackColor = false;
            buttonDatos.Click += buttonDatos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 9;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(12, 296);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Estado:";
            // 
            // labelNac
            // 
            labelNac.AutoSize = true;
            labelNac.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNac.ForeColor = Color.SaddleBrown;
            labelNac.Location = new Point(158, 230);
            labelNac.Name = "labelNac";
            labelNac.Size = new Size(13, 20);
            labelNac.TabIndex = 11;
            labelNac.Text = ".";
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSexo.ForeColor = Color.SaddleBrown;
            labelSexo.Location = new Point(63, 263);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(13, 20);
            labelSexo.TabIndex = 12;
            labelSexo.Text = ".";
            // 
            // labelEdo
            // 
            labelEdo.AutoSize = true;
            labelEdo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdo.ForeColor = Color.SaddleBrown;
            labelEdo.Location = new Point(75, 296);
            labelEdo.Name = "labelEdo";
            labelEdo.Size = new Size(13, 20);
            labelEdo.TabIndex = 13;
            labelEdo.Text = ".";
            // 
            // Fechas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(386, 325);
            Controls.Add(labelEdo);
            Controls.Add(labelSexo);
            Controls.Add(labelNac);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonDatos);
            Controls.Add(textBoxCurp);
            Controls.Add(label3);
            Controls.Add(buttonCalcular);
            Controls.Add(dtpCalculo);
            Controls.Add(dtpNacimiento);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Fechas";
            Text = "Fechas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpNacimiento;
        private DateTimePicker dtpCalculo;
        private Button buttonCalcular;
        private Label label3;
        private TextBox textBoxCurp;
        private Button buttonDatos;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelNac;
        private Label labelSexo;
        private Label labelEdo;
    }
}