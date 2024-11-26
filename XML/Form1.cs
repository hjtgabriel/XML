using System.Xml.Serialization;

namespace XML
{
    public partial class Form1 : Form
    {
        // Ruta predeterminada para el archivo XML donde se almacenará el menú
        private string ruta = @"C:\Users\DELL 5590\source\repos\XML\menu.xml";
        private List<Platillo> menu;

        public Form1()
        {
            InitializeComponent();
            menu = new List<Platillo>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtPlatillo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que el precio sea un número válido
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea un nuevo objeto Platillo con los valores ingresados
            Platillo platillo = new Platillo
            {
                Nombre = txtPlatillo.Text,
                Precio = precio,
                Descripcion = txtDescripcion.Text
            };

            menu.Add(platillo);
            GuardarEnXML(menu, ruta);
            LimpiarCampos();

            MessageBox.Show("Platillo agregado correctamente.");
        }
      //Metodo para limpiar campos
        private void LimpiarCampos()
        {
            txtPlatillo.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
        }

        // Metodo para Serealizar y guardar 
        private void GuardarEnXML(List<Platillo> menu, string ruta)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Platillo>));
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                serializer.Serialize(writer, menu); // Serializa y escribe la lista en el archivo
            }
        }

        // Metodo para leer y desiarilizar
        private List<Platillo> LeerDesdeXML(string ruta)
        {
            // Verifica si el archivo XML existe antes de intentar leerlo
            if (File.Exists(ruta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Platillo>));
                using (StreamReader reader = new StreamReader(ruta))
                {
                    return (List<Platillo>)serializer.Deserialize(reader);  // Devuelve la lista deserializada
                }
            }
            return new List<Platillo>(); // Devuelve una lista vacía si el archivo no existe
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            try
            {
                menu = LeerDesdeXML(ruta); // Carga los platillos desde el archivo XML
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = menu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            // Verifica que haya una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                menu.RemoveAt(index); ///Elimina el platillo de la lista
                GuardarEnXML(menu, ruta); // Actualiza el archivo XML

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = menu; // Refresca el DataGridView con la lista actualizada

                MessageBox.Show("Platillo eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un platillo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

