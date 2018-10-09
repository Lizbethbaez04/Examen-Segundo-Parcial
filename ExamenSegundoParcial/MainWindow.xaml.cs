using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            controlInformacionPersonal.Visibility = Visibility.Collapsed;
            controlContacto.Visibility = Visibility.Collapsed;
            controlInformacionPago.Visibility = Visibility.Collapsed;

            panelConfiguracion.Children.Clear();
            switch(btnSiguiente.TabIndex)
            {
                case 0:
                    controlInformacionPersonal.Visibility = Visibility.Visible;
                    panelConfiguracion.Children.Add(new ControlInformacionPersonal());
                    break;
                case 1:
                    controlContacto.Visibility = Visibility.Visible;
                    panelConfiguracion.Children.Add(new ControlContacto());
                    break;
                case 2:
                    controlInformacionPago.Visibility = Visibility.Visible;
                    panelConfiguracion.Children.Add(new ControlInformacionPago());
                    break;
                default:
                    break;
            }
            if (string.IsNullOrEmpty(controlInformacionPersonal.txtNombre.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlInformacionPersonal.txtApellidoP.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlInformacionPersonal.txtApellidoM.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlInformacionPersonal.txtEdad.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlContacto.txtCorreo.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlContacto.txtTelefono.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlContacto.txtCelular.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            //float numTarjeta;
            //controlInformacionPago.txtNumTarjeta.Text = numTarjeta.ToString();
            //if (string.IsNullOrEmpty(numTarjeta) && numTarjeta !=16)
            //{
                //MessageBox.Show("Es necesario llenar todos los campos");
            //}
            if (string.IsNullOrEmpty(controlInformacionPago.txtCVV.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlInformacionPago.txtMesExpiracion.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
            if (string.IsNullOrEmpty(controlInformacionPago.txtAñoExpiracion.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
        }
    }
}
