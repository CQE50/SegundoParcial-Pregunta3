
namespace Pregunta03
{
    partial class FrmPregunta03
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.imagen2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtsegmento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // abrir
            // 
            this.abrir.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hallar RGB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imagen
            // 
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen.Location = new System.Drawing.Point(186, 86);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(649, 485);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            this.imagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagen_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "R:";
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(40, 122);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(115, 22);
            this.r.TabIndex = 4;
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(40, 150);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(115, 22);
            this.g.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "G:";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(40, 178);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(115, 22);
            this.b.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "B:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pintar Solo R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imagen2
            // 
            this.imagen2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen2.Location = new System.Drawing.Point(841, 86);
            this.imagen2.Name = "imagen2";
            this.imagen2.Size = new System.Drawing.Size(649, 485);
            this.imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen2.TabIndex = 10;
            this.imagen2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = "Pintar Solo G";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 45);
            this.button5.TabIndex = 12;
            this.button5.Text = "Pintar Solo B";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 373);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 45);
            this.button6.TabIndex = 13;
            this.button6.Text = "Copiar parte de Imagen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 424);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 45);
            this.button7.TabIndex = 14;
            this.button7.Text = "Cambiar color de un Pixel a verde";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 475);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 45);
            this.button8.TabIndex = 15;
            this.button8.Text = "Cambiar color de matriz de pixeles\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 577);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 45);
            this.button9.TabIndex = 16;
            this.button9.Text = "Cambiar color - Segmento\r\n";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtsegmento
            // 
            this.txtsegmento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegmento.ForeColor = System.Drawing.Color.Maroon;
            this.txtsegmento.Location = new System.Drawing.Point(15, 549);
            this.txtsegmento.Name = "txtsegmento";
            this.txtsegmento.Size = new System.Drawing.Size(143, 22);
            this.txtsegmento.TabIndex = 18;
            this.txtsegmento.Text = "10";
            this.txtsegmento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tamaño de segmento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(650, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "PROGRAMACION MULTIMEDIAL (INF-324)\r\nExamen Segundo Parcial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 678);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(292, 45);
            this.button10.TabIndex = 20;
            this.button10.Text = "Salir\r\n";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Maroon;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(12, 628);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 45);
            this.button11.TabIndex = 21;
            this.button11.Text = "Marcar Segmentos\r\n";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Maroon;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(161, 628);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(143, 45);
            this.button12.TabIndex = 22;
            this.button12.Text = "Resetear Valores";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 735);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsegmento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.imagen2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.g);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.r);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "INF-324 (Segundo Parcial - Pregunta 3)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.TextBox g;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox imagen2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtsegmento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

