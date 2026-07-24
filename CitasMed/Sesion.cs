using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMed
{
    public static class Sesion
    {
        public static string perfil { get; set; } = string.Empty;

        public static void AbrirFormularioSegunRol()
        {
            switch (perfil)
            {
                case "Admin":
                    FormAdministrador admin = new FormAdministrador();
                    admin.Show();
                    break;

                case "Empleado":
                    FormEmpleado empleado = new FormEmpleado();
                    empleado.Show();
                    break;

                case "Doctor":
                    FormDoctor doctor = new FormDoctor();
                    doctor.Show();
                    break;

                default:
                    MessageBox.Show("Rol no reconocido o sesión no iniciada.");
                    break;
            }
        }
    }
}