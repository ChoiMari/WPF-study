using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_04_GridPractice_LoginForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text;
            string pw = txtPw.Password;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(pw))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요", "경고", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                MessageBox.Show($"로그인 시도: {id} / {pw}", "로그인 정보");
            }
        }
    }
}