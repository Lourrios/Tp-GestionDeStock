using GestionDeStock;
using GestionDeStock.Business.Autenticacion;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GestionStock
{
    public partial class login : Form
    {
        private readonly ILoginUsuario _loginUsuario;
        //private readonly IUsuarioRepository _usuarioRepository;
        //private readonly IPasswordHasher _passwordHasher;
        public login(ILoginUsuario loginUsuario)
        {
            InitializeComponent();
            //_usuarioRepository = usuarioRepository;
            //_passwordHasher = passwordHasher;
            _loginUsuario = loginUsuario;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string contrasenia = txtContrasenia.Text;


            bool loginResult = _loginUsuario.VerificarUsuario(usuario, contrasenia);


            if (loginResult == true)
            {

                Menu form2 = Program.ServiceProvider.GetRequiredService<Menu>();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string usuario =txtusuario.Text;
            string contrasenia = txtContrasenia.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                 Nombre = usuario,
                Hash = contrasenia,
                // Añade otros campos necesarios si los hay
            };

            string mensaje = _loginUsuario.RegistrarUsuario(nuevoUsuario, contrasenia);
            MessageBox.Show(mensaje);
        }
    }


        //private bool Autenticar(string usuario, string contraseña)
        //{
        //    var user = _usuarioRepository.GetUsuarioByNombre(usuario);

        //    if (user == null)
        //        return false;

        //    var hashedPassword = _passwordHasher.GenerateHashPassword(contraseña, user.Salt);

        //    return hashedPassword.SequenceEqual(user.Hash);
        //}
    }




