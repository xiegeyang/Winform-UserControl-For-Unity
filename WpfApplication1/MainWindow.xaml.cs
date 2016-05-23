using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AxUnityWebPlayerAXLib.AxUnityWebPlayer axUnityWebPlayer1;
        string src ;
        public MainWindow()
        {
            InitializeComponent();
            src = @"C:\Users\xiegeyang\Documents\GitHub\SpaceFight_Winform_Project\bin\Debug\SpaceFight(WebPlay).unity3d";
        }

        private void mainLoaded(object sender, RoutedEventArgs e)
        {
            Assembly gamAssembly = Assembly.LoadFrom(@"D:\Documents\GitHub\WPFDll_test\Wpfdongraijiazai\WindowsFormsApplication2\bin\Debug\WindowsFormsApplication2.dll");
            Type typeGame = gamAssembly.GetType("WindowsFormsApplication2.UnityControl");
            System.Windows.Forms.UserControl rehabGame = Activator.CreateInstance(typeGame) as System.Windows.Forms.UserControl;            
            host.Visibility = Visibility.Collapsed;  // Trick to avoid initialization exception
            host.Child = rehabGame;            
            host.Visibility = Visibility.Visible;
            System.Diagnostics.Debug.Print("Done");

            
            //host.Visibility = Visibility.Collapsed;
            //axUnityWebPlayer1 = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            //host.Child = (this.axUnityWebPlayer1);
            //((System.ComponentModel.ISupportInitialize)(this.axUnityWebPlayer1)).EndInit();
            //axUnityWebPlayer1.src = src;
            //System.Windows.Forms.AxHost.State _state = axUnityWebPlayer1.OcxState;
            //axUnityWebPlayer1.Dispose();

            //axUnityWebPlayer1 = new AxUnityWebPlayerAXLib.AxUnityWebPlayer();
            //((System.ComponentModel.ISupportInitialize)(axUnityWebPlayer1)).BeginInit();
            ////this.SuspendLayout();
            //axUnityWebPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //axUnityWebPlayer1.Name = "Unity3D";
            //axUnityWebPlayer1.OcxState = _state;
            //axUnityWebPlayer1.Size = new System.Drawing.Size(691, 418);
            //axUnityWebPlayer1.TabIndex = 0;
            ////Controls.Add(axUnityWebPlayer1);
            //((System.ComponentModel.ISupportInitialize)(axUnityWebPlayer1)).EndInit();
            ////this.ResumeLayout(false);
            //this.axUnityWebPlayer1.OnExternalCall += new AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEventHandler(this.axUnityWebPlayer1_OnExternalCall);
            //host.Visibility = Visibility.Visible;
            //System.Diagnostics.Debug.Print("Done");

        }

        private void axUnityWebPlayer1_OnExternalCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {

        }
    }
}
