using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

using WinForms = System.Windows.Forms;

namespace Book_Library_System
{
    /// <summary>
    /// Interaction logic for Add_Items.xaml
    /// </summary>
    public partial class Add_Items : Page
    {
        // Fields used to store the information from Textboxes.
        // Aswell used to send to Database through the correct Buttons.
        private string title;
        private string author;
        private string isbn;
        private string genre;
        private string langauge;
        private string date;
        private byte[] image;

        public Add_Items()
        {
            InitializeComponent();
        }

        #region Textboxes.

        private void TextBox_Title_TextChanged(object sender, TextChangedEventArgs e)
        {
            title = TextBox_Title.Text;
        }

        private void TextBox_Author_TextChanged(object sender, TextChangedEventArgs e)
        {
            author = TextBox_Author.Text;
        }

        private void TextBox_ISBN_TextChanged(object sender, TextChangedEventArgs e)
        {
            isbn = TextBox_ISBN.Text;
        }

        private void TextBox_Genre_TextChanged(object sender, TextChangedEventArgs e)
        {
            genre = TextBox_Genre.Text;
        }

        private void TextBox_Langauge_TextChanged(object sender, TextChangedEventArgs e)
        {
            langauge = TextBox_Langauge.Text;
        }

        private void TextBox_Date_Of_Release_TextChanged(object sender, TextChangedEventArgs e)
        {
            date = TextBox_Date_Of_Release.Text;
        }

        #endregion


        #region Buttons

        /// <summary>
        /// Adds the items to the library.
        /// </summary>
        private void Button_Add_Item_To_Library_Click(object sender, RoutedEventArgs e)
        {
            string library = "Library";
            string connectionStringToPick = "connectionLibrary";

            if(CheckTextboxesAreFilled())
            {
                ToDatabase toDatabase = new ToDatabase();
                toDatabase.RecieveDatabaseInformation(title, author, isbn, genre, langauge, date, image, library, connectionStringToPick);

                MessageBox.Show("Saved to your Library!");
            }
        }

        /// <summary>
        /// Opens a FileDialog.
        /// And add this image to the Image_Books Element.
        /// </summary>
        private void Button_Add_Image_Click(object sender, RoutedEventArgs e)
        {
            WinForms.OpenFileDialog dialog = new WinForms.OpenFileDialog();
            dialog.Filter = "Image files (*.jpg)|*.jpg";

            if (dialog.ShowDialog() == WinForms.DialogResult.OK)
            {
                // The Image Element in XML
                Image_Books.Source = new BitmapImage(new Uri(dialog.FileName));

                // Filestream which turns the image into a byte[].
                FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                // Makes a byte[] with the proper length.
                byte[] data = new byte[fs.Length];
                // Reads the dialog.Filename into data.
                //Starting at 0. 
                // With fs.Length giving us the Max number of bytes to read.
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                fs.Close();

                image = data; // Put the data into a byte[] field.
            }
        }

        // Deletes the image in the Image_Books element
        private void Button_Delete_Image_Click(object sender, RoutedEventArgs e)
        {
            Image_Books.Source = null;
        }

        /// <summary>
        /// Saves the items to the Whish List
        /// </summary>
        private void Button_Save_To_Whish_Click(object sender, RoutedEventArgs e)
        {
            string library = "WhishList";
            string connectionStringToPick = "connectionWhishList";


            if(CheckTextboxesAreFilled())
            {
                ToDatabase toDatabase = new ToDatabase();
                toDatabase.RecieveDatabaseInformation(title, author, isbn, genre, langauge, date, image, library, connectionStringToPick);

                MessageBox.Show("Saved to your Whish List!");
            }

        }

        #endregion


        /// <summary>
        /// Checks or the Textboxes are filled.
        /// If not sets a null value, or error message depending on the Textboxes.
        /// </summary>
        private bool CheckTextboxesAreFilled()
        {
            bool oke = true;

            if(title == null || author == null || isbn == null)
            {
                Label_Error.Content = "Title, Author & ISBN forms need to be filled!";

                oke = false;
            }
            
            if(genre == null || langauge == null || date == null)
            {
                genre = DBNull.Value.ToString();
                langauge = DBNull.Value.ToString();
                date = DBNull.Value.ToString();

            }

            return oke;
        }


        /// <summary>
        /// If user clicks on this label, we clear the content.
        /// </summary>
        private void Label_Error_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label_Error.Content = "";
        }

        
    }
}
