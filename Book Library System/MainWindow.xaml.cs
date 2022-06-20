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

namespace Book_Library_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            // --------------Below 2 wayss to cover width and height of the screen.-----------------

            // Makes the height of the screen in Maximized mode not go over the taskbar.
            // We also subtract 8 pixels because it disapears under the taskbar otherwise.
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight - 8;
            // Sets the MaxWidth to the WorkArea of the screen.
            // The + 6 pixels is To fully cover the width of the screen.
            MaxWidth = SystemParameters.WorkArea.Width + 6;
        }



        /// <summary>
        /// If user holds down left mouse button, we can drag the window.
        /// </summary>
        private void MouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        
        // Buttons to Minimize / shutdown the Application
        #region Buttons Min/Max/Quit

        
        // Minimizes the Window to the taskbar.
        private void Button_Minimize_Window_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // Shutdown the Application.
        private void Button_Close_Window_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }



        #endregion


        /// <summary>
        /// Opens the Library page.
        /// </summary>
        private void Button_Library_Click(object sender, RoutedEventArgs e)
        {
            Frame_Main.Content = new Library();
        }

        /// <summary>
        /// Opens the Whish List page.
        /// </summary>
        private void Button_WhishList_Click(object sender, RoutedEventArgs e)
        {
            Frame_Main.Content = new Whish_List();
        }

        /// <summary>
        /// Opens the Add Items page.
        /// </summary>
        private void Button_AddItems_Click(object sender, RoutedEventArgs e)
        {
            Frame_Main.Content = new Add_Items();
        }

        
    }
}
