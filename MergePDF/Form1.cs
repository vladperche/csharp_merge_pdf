using MergePDF.Resources;

namespace MergePDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyResources();
        }

        private void ApplyResources()
        {
            lblFolder.Text = Messages.LABEL_FOLDER;
            btnFolder.Text = Messages.BUTTON_FOLDER_OPEN;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPath.Text))
            {
                txtPath.Text = Environment.CurrentDirectory;
            }
        }
    }
}
