using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace Book_Library_System
{
    /// <summary>
    /// Interaction logic for Whish_List.xaml
    /// </summary>
    public partial class Whish_List : Page
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["Connection_WhishList_Database"].ConnectionString;

        readonly DeleteFromDatabase deleteFromDatabase = new DeleteFromDatabase();

        private readonly List<BookInformation> bookList = new List<BookInformation>();

        public Whish_List()
        {
            InitializeComponent();

            GetTitleInformationFromDatabase();
        }

        /// <summary>
        /// Gets all the Title's of all books stored in the WhishList database.
        /// </summary>
        private void GetTitleInformationFromDatabase()
        {
            string query = "SELECT Title,Author,ISBN,Genre,Langauge,Date,Image FROM WhishList";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Puts all the database information in a book object.
                while (reader.Read())
                {
                    BookInformation book = new BookInformation();
                    book.Title = reader.GetString(0);
                    book.Author = reader.GetString(1);
                    book.Isbn = reader.GetString(2);
                    book.Genre = reader.GetString(3);
                    book.Langauge = reader.GetString(4);
                    book.Date = reader.GetString(5);
                    // If the value of Column 6 (image) is not empty.
                    if(reader[6] != DBNull.Value)
                    {
                        book.Image = (byte[])reader[6];
                    }
                    

                    // Adds all book information to the bookList as a book object
                    bookList.Add(book);

                }


                command.Dispose();



                FillListBox();
            }
        }


        /// <summary>
        /// Fills the ListBox with objects of type BookInformation.
        /// We give each item an insert index.
        /// Which is used to find the correct information with.
        /// </summary>
        private void FillListBox()
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                ListBox_Whish_List.Items.Insert(i, bookList[i].Title);
            }
        }


        
        /// <summary>
        /// If any ListBox item is clicked (Selection has Changed)
        /// Then we load that item into all Placeholder labels.
        /// </summary>
        private void ListBox_Whish_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var whichBookWePick = ListBox_Whish_List.SelectedIndex;

            BitmapImage biImg = new BitmapImage();

            // -1 means there is no item selected.
            // So here we check or we have an item selected.
            if (ListBox_Whish_List.SelectedIndex != -1)
            {
                // If the book we picked has a Image.
                if (bookList[whichBookWePick].Image != null && bookList[whichBookWePick].Image.Length > 0)
                {
                    // Then we convert that image into a BitmapImage.
                    MemoryStream ms = new MemoryStream(bookList[whichBookWePick].Image);
                    biImg.BeginInit();
                    biImg.StreamSource = ms;
                    biImg.EndInit();
                }


                for (int i = 0; i < 1; i++)
                {
                    Label_Title_Placeholder.Content = bookList[whichBookWePick].Title;
                    Label_Author_Placeholder.Content = bookList[whichBookWePick].Author;
                    Label_ISBN_Placeholder.Content = bookList[whichBookWePick].Isbn;
                    Label_Genre_Placeholder.Content = bookList[whichBookWePick].Genre;
                    Label_Langauge_Placeholder.Content = bookList[whichBookWePick].Langauge;
                    Label_Release_Date_Placeholder.Content = bookList[whichBookWePick].Date;
                    Image_Books.Source = biImg;
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Label_Title_Placeholder.Content = "";
                    Label_Author_Placeholder.Content = "";
                    Label_ISBN_Placeholder.Content = "";
                    Label_Genre_Placeholder.Content = "";
                    Label_Langauge_Placeholder.Content = "";
                    Label_Release_Date_Placeholder.Content = "";
                    Image_Books.Source = biImg;
                }
            }
        }



        /// <summary>
        /// Deletes the selected book from the Database.
        /// </summary>
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            object bookTitle = Label_Title_Placeholder.Content;

            if (ListBox_Whish_List.SelectedIndex != -1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this book?", "Delete Book?", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    deleteFromDatabase.RecieveDatabaseInformation(bookTitle.ToString(), "WhishList", "connectionWhishList");


                    MessageBox.Show("DELETED");

                    ListBox_Whish_List.Items.Clear();
                    bookList.Clear();
                    GetTitleInformationFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Nothing has been selected.");
            }


            

        }
    }
}
