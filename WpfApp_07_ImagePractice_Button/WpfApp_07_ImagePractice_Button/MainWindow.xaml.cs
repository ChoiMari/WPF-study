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
using Microsoft.Win32;

namespace WpfApp_07_ImagePractice_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "이미지 열기";
            if (openFileDialog.ShowDialog() == true)
            {
                string imgFilePath = openFileDialog.FileName; // 선택한 이미지 파일 경로를 imgFilePath에 저장
               
                if (imgFilePath != null) // 이미지 파일 경로가 null이 아닐 때
                {
                    // 버튼 클릭 시 이미지 파일을 BitmapImage로 변환하여 버튼에 추가
                    // BitmapImage는 WPF에서 이미지를 표현하는 클래스
                    // 이미지 파일을 BitmapImage로 변환
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit(); // 비트맵 초기화
                    bitmap.UriSource = new Uri(imgFilePath); // 이미지 파일 경로 설정
                    bitmap.EndInit(); // 비트맵 초기화 완료
                    Image img = new Image(); // 이미지 객체 생성
                    img.Source = bitmap; // 비트맵 소스 설정

                    // 이미지 버튼에 추가
                    btn.Content = img; // 이미지 버튼에 추가

                    //버튼 크기 조절
                    btn.Width = double.NaN; // 버튼 너비 자동 조정
                    btn.Height = double.NaN; // 버튼 높이 자동 조정
                    // WPF에서 크기 설정 값 Auto는 XAML 전용 표현(.xaml에서만 Auto로 사용 가능)
                    // C# 코드에서는 Double.NaN을 써야 "자동 크기"처럼 동작
                    // C# 코드 기준 Width와 Height는 double 타입이라서 숫자만 받을 수 있음

                }
                else
                {
                    MessageBox.Show("이미지를 불러오는데 실패했습니다.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("이미지 파일을 선택하세요.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}