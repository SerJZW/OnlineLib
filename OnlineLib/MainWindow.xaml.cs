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

namespace OnlineLib
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Books> books = new List<Books>() {
                new Books("Puskin","SS", DateTime.Now, 2)
            };

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
    }
}
