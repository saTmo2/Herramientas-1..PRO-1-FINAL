using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proyecto_final__respaldo_.Biblioteca;



namespace proyecto_final__respaldo_
{
    public partial class Form2 : Form
    {
        private List<Persona> personas; // Lista de personas que se pasará desde Form1

        // Constructor que recibe la lista de personas
        public Form2(List<Persona> personas)
        {
            InitializeComponent();
            this.personas = personas;
            MessageBox.Show("Base de Datos"); // Mensaje de bienvenida

            // Limpiar el DataGridView antes de actualizarlo
            dataGridView.Rows.Clear();

            // Recorrer la lista de personas y agregar sus datos al DataGridView
            foreach (var persona in personas)
            {
                // Crear una fila para la persona
                var personaFila = new DataGridViewRow();
                personaFila.Cells.Add(new DataGridViewTextBoxCell() { Value = persona.Nombre });
                personaFila.Cells.Add(new DataGridViewTextBoxCell() { Value = persona.Cedula });

                // Agregar la fila de la persona al DataGridView
                dataGridView.Rows.Add(personaFila);

                // Mostrar los materiales de esa persona
                foreach (var material in persona.Materiales)
                {
                    // Crear una fila para el material
                    var materialFila = new DataGridViewRow();
                    materialFila.Cells.Add(new DataGridViewTextBoxCell() { Value = persona.Nombre }); // Nombre de la persona
                    materialFila.Cells.Add(new DataGridViewTextBoxCell() { Value = persona.Cedula }); // Cédula de la persona
                    materialFila.Cells.Add(new DataGridViewTextBoxCell() { Value = material.Identificador }); // Identificador del material
                    materialFila.Cells.Add(new DataGridViewTextBoxCell() { Value = material.Titulo }); // Título del material
                    materialFila.Cells.Add(new DataGridViewTextBoxCell() { Value = material.dateTimePicker1.ToShortDateString() }); // Fecha del material
                    materialFila.Cells.Add(new DataGridViewTextBoxCell() { Value = material.CantidadRegistrada }); // Cantidad registrada del material

                    // Agregar la fila del material al DataGridView
                    dataGridView.Rows.Add(materialFila);
                }
            }
        }

        // Evento de clic en las celdas del DataGridView (si lo necesitas)
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar código si necesitas realizar alguna acción cuando se hace clic en una celda.
            // Actualmente está vacío, pero puedes agregar lógica aquí según lo que necesites.
        }
    }
}
