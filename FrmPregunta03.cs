using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pregunta03
{
    public partial class FrmPregunta03 : Form
    {
        private int cr, cg, cb, crt, cgt, cbt,segmento, nrosegmento, posicion;
        private int[] colores;

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, c.G ,0));
                }
            }
            imagen2.Image = bmp2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, 0, c.B));
                }
            }
            imagen2.Image = bmp2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 200; i < 600; i++)
            {
                for (int j = 200; j < 400; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, c);
                }
            }
            imagen2.Image = bmp2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (c.R != cr && c.G != cg && c.B != cb)
                    {
                        bmp2.SetPixel(i, j, c);
                    }
                    else
                    {
                        bmp2.SetPixel(i, j, Color.Green);
                    }

                    
                }
            }
            imagen2.Image = bmp2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (((cr - 10 <= c.R) && (c.R <= cr + 10)) && ((cg - 10 <= c.G) && (c.G <= cg + 10)) && ((cb - 10 <= c.B) && (c.B <= cb + 10)))
                    {
                        bmp2.SetPixel(i, j, Color.Green);
                        
                    }
                    else
                    {
                        bmp2.SetPixel(i, j, c);
                    }


                }
            }
            imagen2.Image = bmp2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //marcando segmentos de 10x10
            segmento = Convert.ToInt32(txtsegmento.Text);
            int crto, cgto, cbto;
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width-segmento; i=i+segmento)
            {
                for (int j = 0; j < bmp.Height-segmento; j=j+segmento)
                {
                    crto = 0;
                    cgto = 0;
                    cbto = 0;
                    for(int k=i;k<i+segmento;k++)
                    {
                        for(int l = j; l < j + segmento; l++) 
                        {
                            c = bmp.GetPixel(k, l);
                            crto = crto + c.R;
                            cgto = cgto + c.G;
                            cbto = cbto + c.B;
                        }                                               
                    }
                    //dividimos entre 100 por que el segmento es de 10x10=100
                    crto = crto / (segmento * segmento);
                    cgto = cgto / (segmento * segmento);
                    cbto = cbto / (segmento * segmento);
                    c = bmp.GetPixel(i, j);
                    if (((crt - segmento <= crto) && (crto <= crt + segmento)) && ((cgto - segmento <= cgt) && (cgt <= cgto + segmento)) && ((cbto - segmento <= cbt) && (cbt <= cbto + segmento))) 
                    {
                        for (int k = i; k < i + segmento; k++) 
                        {
                            for (int l = j; l < j + segmento; l++)
                            {
                                bmp2.SetPixel(k, l, Color.Green);
                            }
                        }                           
                    }
                    else 
                    {
                        for (int k = i; k < i + segmento; k++)
                        {
                            for (int l = j; l < j + segmento; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                bmp2.SetPixel(k, l, c);
                            }
                        }
                    }           
                }
            }
            imagen2.Image = bmp2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //marcando varios segmentos
            Color[] colorfondo = new Color[10];
            colorfondo[1] = Color.Green;
            colorfondo[2] = Color.Blue;
            colorfondo[3] = Color.Red;
            colorfondo[4] = Color.Yellow;
            colorfondo[5] = Color.Black;
            colorfondo[6] = Color.White;
            colorfondo[7] = Color.Pink;
            colorfondo[8] = Color.Orange;
            colorfondo[9] = Color.SkyBlue;
            
            int crto, cgto, cbto,posicionvector=0;          
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for(int m = 1; m <= nrosegmento; m++)
            {
                
                crt = colores[posicionvector]; posicionvector = posicionvector +1;
                cgt = colores[posicionvector]; posicionvector = posicionvector +1;
                cbt = colores[posicionvector]; posicionvector = posicionvector +1;
                segmento = colores[posicionvector]; posicionvector = posicionvector + 1;

                for (int i = 0; i < bmp.Width - segmento; i = i + segmento)
                {
                    for (int j = 0; j < bmp.Height - segmento; j = j + segmento)
                    {
                        crto = 0;
                        cgto = 0;
                        cbto = 0;
                        for (int k = i; k < i + segmento; k++)
                        {
                            for (int l = j; l < j + segmento; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                crto = crto + c.R;
                                cgto = cgto + c.G;
                                cbto = cbto + c.B;
                            }
                        }
                        //dividimos entre 100 por que el segmento es de 10x10=100
                        crto = crto / (segmento * segmento);
                        cgto = cgto / (segmento * segmento);
                        cbto = cbto / (segmento * segmento);
                        c = bmp.GetPixel(i, j);
                        if (((crt - segmento <= crto) && (crto <= crt + segmento)) && ((cgto - segmento <= cgt) && (cgt <= cgto + segmento)) && ((cbto - segmento <= cbt) && (cbt <= cbto + segmento)))
                        {
                            for (int k = i; k < i + segmento; k++)
                            {
                                for (int l = j; l < j + segmento; l++)
                                {
                                    bmp2.SetPixel(k, l, colorfondo[m]);
                                }
                            }
                        }
                        else
                        {
                            for (int k = i; k < i + segmento; k++)
                            {
                                for (int l = j; l < j + segmento; l++)
                                {
                                    c = bmp.GetPixel(k, l);
                                    bmp2.SetPixel(k, l, c);
                                }
                            }
                        }
                    }
                }
                imagen2.Image = bmp2;
                //MessageBox.Show("Uno");
                bmp = bmp2;
               
            }         
           
            imagen2.Image = bmp2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nrosegmento = 0;
            posicion = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagen.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                }
            }
            imagen2.Image = bmp2;
        }

        public FrmPregunta03()
        {
            InitializeComponent();
            posicion = 0;
            colores = new int[100];
            nrosegmento = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir.ShowDialog();
            Bitmap bmp = new Bitmap(abrir.FileName);
            imagen.Image = bmp;
        }

        private void imagen_MouseClick(object sender, MouseEventArgs e)
        {                       
            segmento = Convert.ToInt32(txtsegmento.Text);
            Bitmap bmp = new Bitmap(imagen.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cr = c.R;
            cg = c.G;
            cb = c.B;
            crt = 0;
            cgt = 0;
            cbt = 0;
            for (int i=e.X;i<e.X+segmento;i++) 
            {
                for (int j = e.Y; j < e.Y + segmento; j++)
                {
                    c = bmp.GetPixel(i, j);
                    crt = c.R + crt;
                    cgt = c.G + cgt; 
                    cbt = c.B + cbt;
                }
            }
            crt = crt / (segmento * segmento);
            cgt = cgt / (segmento * segmento);
            cbt = cbt / (segmento * segmento);
            r.Text = c.R.ToString() + " " + crt.ToString();
            g.Text = c.G.ToString() + " " + cgt.ToString();
            b.Text = c.B.ToString() + " " + cbt.ToString();

            colores[posicion] = crt;
            posicion = posicion + 1;
            colores[posicion] = cgt;
            posicion = posicion + 1;
            colores[posicion] = cbt;
            posicion = posicion + 1;            
            String valor = "";
            InputBox("Valor de Ingreso", "Ingrese valor de segmento:", ref valor);
            colores[posicion] = Convert.ToInt32(valor);
            posicion = posicion + 1;
            nrosegmento = nrosegmento + 1;
            MessageBox.Show("Marco el color y tamaño del segmento numero :" + Convert.ToString(nrosegmento));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imagen.Image);
            Color c = new Color();
            c = bmp.GetPixel(0, 0);
            r.Text = c.R.ToString();
            g.Text = c.G.ToString();
            b.Text = c.B.ToString();
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
