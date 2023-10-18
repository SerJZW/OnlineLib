using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace OnlineLib
{
    public class Applications : Notice
    {
        private Users? selectedUser;
        private Books? selectedBook;
        private Users? searchUser;
        private RelayCommand? addUserCommand;
        private RelayCommand? removeUserCommand;
        private RelayCommand? addBookCommand;
        private RelayCommand? removeBookCommand;

        public ObservableCollection<Users> User { get; set; }
        public ObservableCollection<Books> Book { get; set; }


        public Users? SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; OnPropertyChanged("SelectedUser"); }
        }
        public Users? SearchUser
        {
            get { return searchUser; }
            set { searchUser = value; OnPropertyChanged("SearchUser"); }
        }
        public Books? SelectedBooks
        {
            get { return selectedBook; }
            set { selectedBook = value; OnPropertyChanged("SelectedBooks"); }
        }

        public Applications()
        {
            User = new ObservableCollection<Users>()
            {
                new Users{ID = 1,Name = "Sergey",Family = "Zemtsov", UserBooks = new List<Books>() },
                new Users{ID = 2, Name = "Timur", Family = "Salahutdinov", UserBooks = new List<Books>() },
                new Users{ID = 3, Name = "LEvan", Family ="Levcenko", UserBooks = new List<Books>() },
                new Users{ID = 4,Name = "Egor", Family = "Ivanov", UserBooks = new List<Books>() },
                new Users{ID = 5,Name = "Ivanova",Family = "Nadezhda", UserBooks = new List<Books>() }
            };
            Book = new ObservableCollection<Books>()
            {
               new Books{Autor = "Pushkin A.S.",Acr = 1,Age =  new DateOnly(1817, 1, 24), Count =  40 },
               new Books{Autor ="Esenin A.S.", Acr = 2 , Age = new DateOnly(1860, 5, 19), Count = 15 },
               new Books{Autor = "Gogol N.V.", Acr = 3, Age = new DateOnly(1840, 12, 10), Count = 10 },
               new Books{Autor = "Tolstoy L.N.", Acr = 4, Age = new DateOnly(1880, 4, 4), Count = 60 },
               new Books{Autor = "Chehov A.P.", Acr = 5, Age = new DateOnly(1890, 1, 15), Count = 70 },
            };

        }

        public RelayCommand AddUserCommand
        {
            get
            {
                return addUserCommand ??
                    (addUserCommand = new RelayCommand(obj =>
                    {
                        Users user = new Users();
                        User.Add(user);
                        SelectedUser = user;
                    }));
            }
        }
        public RelayCommand RemoveUserCommand
        {
            get
            {
                return removeUserCommand ??
                    (removeUserCommand = new RelayCommand(obj =>
                    {
                        Users? user = obj as Users;
                        if (user != null)
                        {
                            User.Remove(user);

                        }
                    },
                    (obj) => User.Count > 0));
            }
        }
        public RelayCommand AddBooksCommand
        {
            get
            {
                return addBookCommand ??
                    (addBookCommand = new RelayCommand(obj =>
                    {
                        Books books = new Books();
                        Book.Add(books);
                        SelectedBooks = books;
                    }));

            }
        }
        public RelayCommand RemoveBooksCommand
        {
            get
            {
                return removeBookCommand ??
                    (removeBookCommand = new RelayCommand(obj =>
                    {
                        Books? book = obj as Books;
                        if (book != null)
                        {
                            Book.Remove(book);
                            Console.WriteLine("Книга удалена: " + book.Autor); // Отладочный вывод
                        }
                    },
                    (obj) => Book.Count > 0));
            }
        }
        public RelayCommand ExitCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    System.Windows.Application.Current.Shutdown();
                });
            }
        }
        public RelayCommand ContactCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MessageBox.Show("Контакты для связи \n88005553535, 8923343439");
                });
            }
        }
        public RelayCommand ShowAboutCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    string message = "Добро пожаловать в нашу онлайн библиотеку!\r\n\r\nНаша библиотека - это ценный ресурс для всех, кто ищет знаний и информации в различных областях. Мы уделяем особое внимание сбору и предоставлению разнообразных материалов, чтобы удовлетворить потребности как новичков, так и профессионалов.\r\n\r\nЧто вы найдете в нашей библиотеке:\r\n\r\nУчебные ресурсы: Мы предлагаем богатый выбор учебных материалов по различным темам, от базовых концепций до продвинутых областей. Здесь вы найдете учебники, статьи и видеоуроки, которые помогут вам расширить свои знания.\r\n\r\nЛитература и произведения: Наша библиотека содержит широкий спектр книг и литературы в разных жанрах и направлениях. Вы можете прочитать классические произведения, научные работы или популярную литературу.\r\n\r\nФорум и сообщество: У нас есть активное сообщество пользователей, где вы можете обсудить интересующие вас вопросы, делиться мнениями и получать ответы на запросы. Присоединяйтесь к общению с единомышленниками.\r\n\r\nНовости и обновления: Мы следим за актуальными событиями и информируем вас о последних новостях в различных областях. Будьте в курсе самых важных событий и тенденций.\r\n\r\nРесурсы для исследований: Если вы занимаетесь исследованиями, у нас есть коллекция научных статей и публикаций, которые могут быть полезными для ваших исследовательских работ.\r\n\r\nМы стремимся сделать доступ к знаниям максимально удобным и разнообразным. Независимо от вашего интереса или цели, наша библиотека предоставит вам необходимые ресурсы для саморазвития и обучения.\r\n\r\nСпасибо, что выбрали нашу онлайн библиотеку!";
                    MessageBox.Show(message);
                });
            }
        }
        public RelayCommand AddBookToUserCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedUser != null && SelectedBooks != null)
                    {
                        if (SelectedBooks.Count > 0)
                        {
                            SelectedBooks.Count--;

                            Books addedBook = new Books
                            {
                                Autor = SelectedBooks.Autor,
                                Acr = SelectedBooks.Acr,
                                Age = SelectedBooks.Age,
                                Count = 1
                            };

                            SelectedUser.UserBooks.Add(addedBook);
                            MessageBox.Show("Книга выдана пользователю");
                            if (SelectedBooks.Count == 0)
                            {
                                MessageBox.Show("Книги закончились");
                                Book.Remove(SelectedBooks);
                            }
                        }

                    }
                });

            }
        }
    }
}






