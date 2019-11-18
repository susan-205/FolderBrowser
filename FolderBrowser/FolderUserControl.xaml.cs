using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para FolderUserControl.xaml
    /// </summary>
    public partial class FolderUserControl : System.Windows.Controls.UserControl
    {
        public FolderUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(FolderUserControl), new PropertyMetadata(""));




        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texto.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextoProperty =
            DependencyProperty.Register("Texto", typeof(string), typeof(FolderUserControl), new PropertyMetadata(""));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogo = new FolderBrowserDialog();

            //Mostramos el diálogo
            DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                string ruta = dialogo.SelectedPath;
                Texto = ruta;
            }
        }
    }
}
