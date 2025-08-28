using System;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        // 멤버 변수 버튼
        private Button testButton = null;
        // 컨트럴 클래스의 초기 설정 함수
        private T SetInitControl<T>(T control, string Name, int Point) where T : Control
        {
            // 위치 설정
            control.Location = new System.Drawing.Point(27, Point);
            // 컨트럴 이름 설정
            control.Name = Name;
            control.Size = new System.Drawing.Size(75, 23);
            // 탭 인덱스 설정
            control.TabIndex = 0;
            return control;
        }
        public Form1()
        {
            // 초기화
            InitializeComponent();

            // 버튼 인스턴스 생성 후 초기 설정
            testButton = SetInitControl(new Button(), "Button1", 40);
            // 버튼의 Text 설정
            this.testButton.Text = "Test Button";
            // 폼에 Control 추가
            this.Controls.Add(this.testButton);

            


            // 이벤트 추가(람다식으로 추가)
            this.testButton.Click += (sender, e) =>
            {
                ThreadPool.QueueUserWorkItem((sender) =>
                {
                    // 0부터 9999까지 루프
                    for (int nCount = 0; nCount < 10000; nCount++)
                    {
                        // 콘솔 출력
                        Console.WriteLine(nCount);
                        // 스레드 대기 1초
                        Thread.Sleep(1000);
                    }
                });
                ThreadPool.QueueUserWorkItem((sender) =>
                {
                    // 0부터 9999까지 루프
                    for (int nCount = 0; nCount > -10000; nCount--)
                    {
                        // 콘솔 출력
                        Console.WriteLine(nCount);
                        // 스레드 대기 1초
                        Thread.Sleep(1000);
                    }
                });
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
