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

#region #1. Tab Control
/*
 * - 웹 브라우저 처럼 탭 버튼을 눌러 다른 내용의 화면 전환.
 * 
 * 1) TabControl
 * - 전체 탭 컨테이너
 * - 내부의 여러 개 TabItem을 가질 수 있음.
 * 
 * 2) TabItem
 * - 각각의 탭을 나타내는 항목
 * - Header : 탭 제목
 * - Content : 보여줄 컨텐츠(UI) 배치.
 */
#endregion

#region #2. StackPanel
/*
 * 자식 요소들을 수직(Vertical) 또는 수평(Horizontal) 방향으로 자동으로 정렬해서 배치하는 레이아웃 패널.
 * - 요소들을 순서대로 쌓음.
 * - 마우스 조작으로 요소 이동 불가.
 * 
 * [속성]
 * Orientation : 쌓는 방향 지정   - Vertical(기본 값), Horizontal
 */
#endregion

#region #3. Grid
/*
 * - 행과 열을 나누어서 엑셀 표처럼 UI 요소를 격자(Grid) 구조로 배치할 수 있는 레이아웃 패널.
 * 
 * [속성]
 * - RowDefinition: 행(가로줄) 만들기
 * - CloumnDefinition: 열(세로줄) 만들기
 * 
 * [Height / Width]
 * - Auto: 내부 요소의 크기에 맞게
 * - * : 나머지 공간을 비율로 자동 분배
 * - 숫자(px): 고정 크기
 * 
 * When?
 * - 1) 요소들이 표 형태로 정리되어야 할 때
 * - 2) 요소들이 정확한 위치에 있어야 할 때
 * - 3) 반응형 비율 기반 배치가 필요 할 때
 */
#endregion

#region #4. TextBlock
/*
 * - 텍스트를 화면에 출력해주는 WPF 가장 기본적인 텍스트 표시용 컨트롤.
 * - 화면 읽기 전용 텍스트를 표시할 때 사용
 * - 사용자가 직접 입력 X
 *   -> 입력은 TextBox에서 가능.
 */
#endregion

namespace WpfApp_02_Basic
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
    }
}