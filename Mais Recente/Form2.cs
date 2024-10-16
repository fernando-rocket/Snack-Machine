using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Double valor_inserido = 0.0;
        List<PictureBox> pictures = new List<PictureBox>();
        List<Produto> produtos = new List<Produto>();
        public Form2()
        {
            InitializeComponent();
            
            pictures.Add(pictureBox1);
            pictures.Add(pictureBox2);
            pictures.Add(pictureBox3);
            pictures.Add(pictureBox4);
            pictures.Add(pictureBox5);
            pictures.Add(pictureBox6);
            pictures.Add(pictureBox7);
            pictures.Add(pictureBox8);
            pictures.Add(pictureBox9);
            
            produtos.Add(new Produto(3.90, 1, false));
            produtos.Add(new Produto(4.90, 2, false));
            produtos.Add(new Produto(2.90, 3, false));
            produtos.Add(new Produto(1.90, 4, false));
            produtos.Add(new Produto(0.90, 5, false));
            produtos.Add(new Produto(2.50, 6, false));
            produtos.Add(new Produto(3.80, 7, false));
            produtos.Add(new Produto(2.00, 8, false));
            produtos.Add(new Produto(1.50, 9, false));

            testProducts();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void testProducts()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.Write(valor_inserido);
                if(produtos[i].getValor() > valor_inserido)
                {
                    pictures[i].Visible = false;
                    produtos[i].setEnable(false);
                }
                else
                {
                    pictures[i].Visible = true;
                    produtos[i].setEnable(true);
                    pictures[i].Cursor = Cursors.Hand;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor_inserido = Convert.ToDouble(textBox1.Text);
            testProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Produto
    {
        Double valor;
        int id;
        Boolean enable;

        public Produto(Double valor, int id, Boolean enable)
        {
            setValor(valor);
            setId(id);
            setEnable(enable);
        }

        public Double getValor()
        {
            return this.valor;
        }

        public Double getId()
        {
            return this.id;
        }

        public Boolean getEnable()
        {
            return this.enable;
        }

        public void setValor(Double valor)
        {
            this.valor = valor;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setEnable(Boolean enable)
        {
            this.enable = enable;
        }
    }
}
