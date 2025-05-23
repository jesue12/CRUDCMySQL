using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using MaxMind.Db;

namespace Vista
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            LlenarCmbMarcas();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal || 
                WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        void LlenarCmbMarcas()
        {
            /*try
            {
                DataTable retornarProducto;
                retornarProducto = ControllerProductos.obtenerMarcas();
                cmbMarca = retornarProducto;
                cmbMarca.DisplayMember = "Marca";
                cmbMarca.ValueMember = "IdMarca";

            }
            catch (Exception) {
                MessageBox.Show("Error al cargar registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text.Trim();
                string descripcion = richTextdescrip.Text.Trim();
            if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                return;
            }

            ControllerMarca controller = new ControllerMarca(marca,descripcion, 0);

                bool resultado = controller.RegistrarMarca();

                if (resultado)
                {
                    MessageBox.Show("Marca registrada correctamente.");
                    txtMarca.Clear();
                    richTextdescrip.Clear();
                }
                else
                {
                    MessageBox.Show("Error al registrar la marca.");
                }
           


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int IdMarca = int.Parse(txtId.Text);
            string marca = txtMarca.Text.Trim();
            string descripcion = richTextdescrip.Text.Trim();
            ControllerMarca controller = new ControllerMarca(marca, descripcion, IdMarca);

            bool Actualizacion = controller.ActualizarMarca();
            
            if(Actualizacion)
            {
                MessageBox.Show("Información actualizada");
                txtId.Clear();
                txtMarca.Clear();
                richTextdescrip.Clear();
            }
            else
            {
                MessageBox.Show("Error al actualizar datos");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)

        {

            int IdMarca;
            string marca = txtMarca.Text.Trim();
            string descripcion = richTextdescrip.Text.Trim();

            if (!int.TryParse(txtId.Text.Trim(), out IdMarca))
            {
                MessageBox.Show("No hay datos por eliminar");
                return;
            }

            ControllerMarca controller = new ControllerMarca(marca, descripcion, IdMarca);

            bool resultado = controller.EliminarRegistro();

            if (resultado)
            {
                MessageBox.Show("Registro Eliminado.");
                txtId.Clear();
                txtMarca.Clear();
                richTextdescrip.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar.");
            }


        }

        private void richtxtDescrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int IdMarca = int.Parse(txtId.Text);
            string marca = txtMarca.Text.Trim();
            string descripcion = richTextdescrip.Text.Trim();

            ControllerMarca controller = new ControllerMarca(marca, descripcion, IdMarca);

            bool resultado = controller.BuscarMarca();

            if (resultado)
            {
                txtId.Text = controller.IdMarca.ToString();
                txtMarca.Text = controller.Marca;
                richTextdescrip.Text = controller.Descripcion;
            }
            else
            {
                MessageBox.Show("No se encontraron registros.");
            }
        }

        private void txtCodigoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            string CodigoProducto = txtCodigoP.Text.Trim();
            string Producto = txtNmProduc.Text.Trim();
            string Descripcion = richtxtDescrip.Text.Trim();
            string Fecha = dateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrWhiteSpace(CodigoProducto) ||
                string.IsNullOrWhiteSpace(Producto) ||
                string.IsNullOrWhiteSpace(Descripcion) ||
                string.IsNullOrWhiteSpace(txtExis.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtIdMarcaP.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!int.TryParse(txtExis.Text.Trim(), out int Existencias))
            {
                MessageBox.Show("Las existencias deben ser un número válido.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal Precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtIdMarcaP.Text.Trim(), out int IdMarca))
            {
                MessageBox.Show("El IdMarca debe ser un número válido.");
                return;
            }

            ControllerProductos controller = new ControllerProductos(0,CodigoProducto, Existencias, Producto,Precio, Descripcion, IdMarca, Fecha,"");

            bool resultado = controller.EnviarProducto();

            if (resultado)
            {
                MessageBox.Show("Producto registrado correctamente.");
                txtCodigoP.Clear();
                txtNmProduc.Clear();
                richtxtDescrip.Clear();
                txtExis.Clear();
                txtPrecio.Clear();
                txtIdMarcaP.Clear();
            }
            else
            {
                MessageBox.Show("Error al registrar el producto.");
            }
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            
                int IdProducto;
                if (!int.TryParse(txtIdProduct.Text.Trim(), out IdProducto))
                {
                    MessageBox.Show("Inserte  un Id");
                    return;
                }
              




                ControllerProductos controller = new ControllerProductos(IdProducto, "",0,"",0,"",0,"","");

                bool resultado = controller.BuscarProducto();

                if (resultado)
                {
                    txtIdProduct.Text = controller.IdProducto.ToString();
                    txtCodigoP.Text = controller.CodigoProducto;
                    txtExis.Text = controller.Existencias.ToString();
                    txtNmProduc.Text = controller.Producto;
                    txtPrecio.Text = controller.Precio.ToString();
                    richtxtDescrip.Text =controller.Descripcion;
                    txtIdMarcaP.Text = controller.IdMarca.ToString();
                    dateTime.Text = controller.Fecha;
                cmbMarca.Text = controller.Marca;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.");
                }
            }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            {
                int IdProducto;
                string CodigoProducto = txtCodigoP.Text.Trim();
                int Existencias = int.Parse(txtExis.Text);
                string Producto = txtNmProduc.Text.Trim();
                int Precio = int.Parse(txtPrecio.Text);
                string Descripcion = richtxtDescrip.Text.Trim();
                int IdMarca = int.Parse(txtIdMarcaP.Text);
                string Fecha = dateTime.Text.Trim();

                if (!int.TryParse(txtIdProduct.Text.Trim(), out IdProducto))
                {
                    MessageBox.Show("No hay datos por eliminar");
                    return;
                }

                ControllerProductos controller = new ControllerProductos(IdProducto,CodigoProducto, Existencias, Producto, Precio, Descripcion, IdMarca, Fecha,"");

                bool resultado = controller.ElimarProducto();

                if (resultado)
                {
                    MessageBox.Show("Registro Eliminado.");
                    txtIdProduct.Clear();
                    txtCodigoP.Clear();
                    txtExis.Clear();
                    txtNmProduc.Clear();
                    txtPrecio.Clear();
                    richtxtDescrip.Clear();
                    txtIdMarcaP.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Error al eliminar.");
                }


            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)

        {

            int IdProducto = int.Parse(txtIdProduct.Text);
            string CodigoProducto = txtCodigoP.Text.Trim();
            int Existencias = int.Parse(txtExis.Text);
            string Producto = txtNmProduc.Text.Trim();
            decimal Precio = decimal.Parse(txtPrecio.Text);
            string Descripcion = richtxtDescrip.Text.Trim();
            int IdMarca = int.Parse(txtIdMarcaP.Text);
            string Fecha = dateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");

            ControllerProductos controller = new ControllerProductos(IdProducto, CodigoProducto, Existencias, Producto, Precio, Descripcion, IdMarca, Fecha,"");

            bool resultado = controller.ActualizarProducto();

            if (resultado)
            {
                MessageBox.Show("Registro actualizado.");
                txtIdProduct.Clear();
                txtCodigoP.Clear();
                txtExis.Clear();
                txtNmProduc.Clear();
                txtPrecio.Clear();
                richtxtDescrip.Clear();
                txtIdMarcaP.Clear();
            }
            else
            {
                MessageBox.Show("Error al actualizar.");

            }

        }
    }
    }



    



