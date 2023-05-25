using ApiExamenDll;

namespace Vista
{
    public partial class Form1 : Form
    {
        private DataAccess Da { get; }
        public Form1()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            var dt = Da.GetExamenes(NombreTb.Text,DescripcionTb.Text);
            Grid.DataSource = dt;
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            var message = Da.AgregarExamen(Convert.ToInt32(IdTb.Text), NombreTb.Text, DescripcionTb.Text);
            var dt = Da.GetExamenes(NombreTb.Text, DescripcionTb.Text);
            Grid.DataSource = dt;
        }



        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            var message = Da.EliminarExamen(Convert.ToInt32(IdTb.Text));

        }



        private void Actualizarbtn_Click(object sender, EventArgs e)
        {
            var message = Da.ActualizarExamen(Convert.ToInt32(IdTb.Text), NombreTb.Text, DescripcionTb.Text);
            var dt = Da.GetExamenes(NombreTb.Text, DescripcionTb.Text);
            Grid.DataSource = dt;
        }





    }
}