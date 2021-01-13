using System;
using System.Data;
using System.Windows.Forms;

namespace AppFerroviario
{
    public partial class Form1 : Form
    {
        string consulta = "";
        DataSet ds = new DataSet();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM Maquinista WHERE estatus=1";
            Datos.AgregarDataTable(ds, consulta, "ListaMaquinistaActivas");
            dataGridView1.DataSource = ds.Tables["ListaMaquinistaActivas"];
            MessageBox.Show("Se selecciono la tabla maquinista");
        }
        private void btnElimina_Click(object sender, EventArgs e)
        {
            consulta = "DELETE FROM Trucks WHERE idTrucks=4";
            
            Datos.AgregarDataTable(ds, consulta, "ListaMaquinistaActivas");
            dataGridView1.DataSource = ds.Tables["ListaMaquinistaActivas"];
            MessageBox.Show("Se elimino en Trucks");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            consulta = "UPDATE Maquinista SET nombre='Cesar' WHERE idMaquinista=4";
          
            Datos.AgregarDataTable(ds, consulta, "ListaMaquinistaActivas");
            dataGridView1.DataSource = ds.Tables["ListaMaquinistaActivas"];
            MessageBox.Show("Se actualizo tabla Maquinista");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            consulta = "INSERT INTO Trucks(descripcion,idMotor,idFlujoAire,idAceite) VALUES('Trucks 100','4','4','4');";
            Datos.AgregarDataTable(ds, consulta, "ListaMaquinistaActivas");
            dataGridView1.DataSource = ds.Tables["ListaMaquinistaActivas"];
            MessageBox.Show("Se inserto en tabla trucks");
        }
    }
}
