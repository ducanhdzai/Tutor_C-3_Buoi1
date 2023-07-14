using System.Windows.Forms;

namespace Tutor_C_3_Buoi1
{
    public partial class FormTutor1 : Form
    {
        public FormTutor1()
        {
            //tb_1.Text = DateTime.Now.ToString("HH:MM:SS");
            // Tại sao để ở đây nó lại hi sinh
            InitializeComponent();
        }

        private void btn_avt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files |*.png|*jpeg|*jpg";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                ptb_avt.Image = Image.FromFile(fileName);
            }
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButtons.OK);
        }

        private void FormTutor1_Load(object sender, EventArgs e)
        {
            tb_1.Enabled = false;
            tb_1.Text = DateTime.Now.ToString("dddd dd/MM/yyyy HH:mm:ss tt");
            cb_1.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tb_1.Text = DateTime.Now.ToString("dddd dd/MM/yyyy HH:mm:ss tt");
        }

        private void openNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTutor1 form = new FormTutor1();
            form.ShowDialog();
        }
    }
}