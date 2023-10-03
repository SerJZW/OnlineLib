using System;
using System.Collections.Generic;
using System.Windows;

namespace OnlineLib
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private static List<Users> users = new List<Users>()
        {
                new Users(1,"Sergey","Zemtsov", books),
                new Users(2,"Timur","Salahutdinov", books),
                new Users(3,"LEvan","Levcenko", books),
                new Users(4,"Egor","Ivanov", books),
                new Users(5,"Ivanova","Nadezhda", books),
        };
        private static List<Books> books = new List<Books>()
        {
               new Books("Pushkin A.S.", 1 , new DateOnly(1817, 1, 24), 40),
               new Books("Esenin A.S.", 2 , new DateOnly(1860, 5, 19), 15),
               new Books("Gogol N.V.", 3 , new DateOnly(1840, 12, 10), 10),
               new Books("Tolstoy L.N.", 4 , new DateOnly(1880, 4, 4), 60),
               new Books("Chehov A.P.", 5 , new DateOnly(1890, 1, 15), 70),
        };

        public MainWindow()
        {


            InitializeComponent();

            BooksList.ItemsSource = books;
            UsersList.ItemsSource = users;

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Контакты для связи \n88005553535, 8923343439");
        }

        private void About_Apl_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добро пожаловать в нашу онлайн библиотеку!\r\n\r\nНаша библиотека - это ценный ресурс для всех, кто ищет знаний и информации в различных областях. Мы уделяем особое внимание сбору и предоставлению разнообразных материалов, чтобы удовлетворить потребности как новичков, так и профессионалов.\r\n\r\nЧто вы найдете в нашей библиотеке:\r\n\r\nУчебные ресурсы: Мы предлагаем богатый выбор учебных материалов по различным темам, от базовых концепций до продвинутых областей. Здесь вы найдете учебники, статьи и видеоуроки, которые помогут вам расширить свои знания.\r\n\r\nЛитература и произведения: Наша библиотека содержит широкий спектр книг и литературы в разных жанрах и направлениях. Вы можете прочитать классические произведения, научные работы или популярную литературу.\r\n\r\nФорум и сообщество: У нас есть активное сообщество пользователей, где вы можете обсудить интересующие вас вопросы, делиться мнениями и получать ответы на запросы. Присоединяйтесь к общению с единомышленниками.\r\n\r\nНовости и обновления: Мы следим за актуальными событиями и информируем вас о последних новостях в различных областях. Будьте в курсе самых важных событий и тенденций.\r\n\r\nРесурсы для исследований: Если вы занимаетесь исследованиями, у нас есть коллекция научных статей и публикаций, которые могут быть полезными для ваших исследовательских работ.\r\n\r\nМы стремимся сделать доступ к знаниям максимально удобным и разнообразным. Независимо от вашего интереса или цели, наша библиотека предоставит вам необходимые ресурсы для саморазвития и обучения.\r\n\r\nСпасибо, что выбрали нашу онлайн библиотеку!");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BooksList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Books? books = BooksList.SelectedItem as Books;
            if (books != null)
            {
                AutorText.Text = Convert.ToString(books.Autor);
                AcrText.Text = Convert.ToString(books.Acr);
                AgeText.Text = Convert.ToString(books.Age);
                CountText.Text = Convert.ToString(books.Count);
            }
        }



        private void UsersList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Users? selectedUser = UsersList.SelectedItem as Users;
            if (selectedUser != null)
            {
                IdText.Text = Convert.ToString(selectedUser.Id);
                NameText.Text = Convert.ToString(selectedUser.Name);
                FamilyText.Text = Convert.ToString(selectedUser.Family);
                BooksList.ItemsSource = selectedUser.Books;
            }
        }

        private void Add_ClickUser(object sender, RoutedEventArgs e)
        {
            if (users != null)
            {
                int newUserId;
                if (int.TryParse(IdText.Text, out newUserId))
                {
                    string newName = NameText.Text;
                    string newFamily = FamilyText.Text;
                    Users newUser = new Users(newUserId, newName, newFamily, new List<Books>());
                    users.Add(newUser);
                    IdText.Text = "";
                    NameText.Text = "";
                    FamilyText.Text = "";
                    UsersList.ItemsSource = users;
                    UsersList.Items.Refresh();
                    MessageBox.Show("Пользователь успешно добавлен.");
                }
                else
                {
                    MessageBox.Show("ID пользователя должен быть числом.");
                }
            }
        }

        private void Delete_ClickUser(object sender, RoutedEventArgs e)
        {
            if (users != null && UsersList.SelectedItem != null)
            {
                Users? selectedUser = UsersList.SelectedItem as Users;
                MessageBoxResult result = MessageBox.Show($"Вы уверены, что хотите удалить пользователя {selectedUser.Name} {selectedUser.Family}?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    users.Remove(selectedUser);
                    UsersList.ItemsSource = users;
                    UsersList.Items.Refresh();
                    MessageBox.Show("Пользователь успешно удален.");
                }
            }
        }
        private void Add_ClickBooks(object sender, RoutedEventArgs e)
        {
            if (books != null)
            {
                string newAutor = AutorText.Text;
                short newAcr;
                if (short.TryParse(AcrText.Text, out newAcr))
                {
                    DateOnly newAge;
                    if (DateOnly.TryParse(AgeText.Text, out newAge))
                    {
                        int newCount;
                        if (int.TryParse(CountText.Text, out newCount))
                        {
                            Books newBook = new Books(newAutor, newAcr, newAge, newCount);
                            books.Add(newBook);
                            AutorText.Text = "";
                            AcrText.Text = "";
                            AgeText.Text = "";
                            CountText.Text = "";
                            BooksList.ItemsSource = books;
                            BooksList.Items.Refresh();
                            MessageBox.Show("Книга успешно добавлена.");
                        }
                        else
                        {
                            MessageBox.Show("Количество должно быть числом.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат даты.");
                    }
                }
                else
                {
                    MessageBox.Show("Артикул должен быть числом (short).");
                }
            }
        }

        private void Delete_ClickBooks(object sender, RoutedEventArgs e)
        {
            if (books != null && BooksList.SelectedItem != null)
            {
                Books? selectedBook = BooksList.SelectedItem as Books;
                MessageBoxResult result = MessageBox.Show($"Вы уверены, что хотите удалить книгу с артикулом {selectedBook.Acr}?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    books.Remove(selectedBook);
                    BooksList.ItemsSource = books;
                    BooksList.Items.Refresh();
                    MessageBox.Show("Книга успешно удалена.");
                }
            }
        }

        private void Reride_ClickBooks(object sender, RoutedEventArgs e)
        {
            if (BooksList.SelectedItem != null)
            {
                Books? selectedBook = BooksList.SelectedItem as Books;
                if (selectedBook != null)
                {
                    selectedBook.Autor = AutorText.Text;
                    selectedBook.Acr = Convert.ToInt16(AcrText.Text);
                    selectedBook.Age = DateOnly.Parse(AgeText.Text);
                    selectedBook.Count = Convert.ToInt32(CountText.Text);
                    BooksList.Items.Refresh();
                    MessageBox.Show("Данные книги успешно обновлены.");

                }
            }
        }

        private void Reride_ClickUsers(object sender, RoutedEventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                Users? selectedUser = UsersList.SelectedItem as Users;
                if (selectedUser != null)
                {
                    selectedUser.Name = NameText.Text;
                    selectedUser.Family = FamilyText.Text;
                    UsersList.Items.Refresh();
                    MessageBox.Show("Данные пользователя успешно обновлены.");
                }
            }
        }

        private void AddBook_ClickUsers(object sender, RoutedEventArgs e)
        {
            if(books.Count != null)
            {
                
            }
        }
    }
}

