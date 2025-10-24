using ev3.Services;

namespace ev3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly UserRepository _repo = new();

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;
            if (_repo.Validate(email, password))
            {
                MessageBox.Show("Iniciaste sesi�n correctamente", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Credenciales inv�lidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Completa correo y contrase�a", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_repo.Register(email, password))
            {
                MessageBox.Show("Usuario registrado correctamente", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ya existe un usuario con ese correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
