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
using System.Windows.Forms.Integration;
using AxUnityWebPlayerAXLib;
using System.Reflection;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Unity_Loaded(object sender, RoutedEventArgs e)
        {
            Assembly gamAssembly = Assembly.LoadFrom(@"D:\Documents\GitHub\WPFDll_test\WpfApplication1\WindowsFormsApplication2\bin\Debug\WindowsFormsApplication2.dll");
            Type typeGame = gamAssembly.GetType("WindowsFormsApplication2.ClassName.Form1");
            System.Windows.Forms.Control rehabGame = Activator.CreateInstance(typeGame) as System.Windows.Forms.Control;

            WindowsFormsHost host = new WindowsFormsHost();
            //AxUnityWebPlayer axUnity = new AxUnityWebPlayer();
            host.Visibility = Visibility.Collapsed;  // Trick to avoid initialization exception
            host.Child = rehabGame;

            //ComponentResourceManager resources = new ComponentResourceManager(typeof(AxShockwaveFlashObjects.AxShockwaveFlash));
            //axFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFlash.OcxState")));
            //((ISupportInitialize)(axFlash)).EndInit();


            host.Visibility = Visibility.Visible;
            gridUnity.Children.Add(host);

            

        }
    }
}
