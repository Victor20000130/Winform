using System;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        // ��� ���� ��ư
        private Button testButton = null;
        // ��Ʈ�� Ŭ������ �ʱ� ���� �Լ�
        private T SetInitControl<T>(T control, string Name, int Point) where T : Control
        {
            // ��ġ ����
            control.Location = new System.Drawing.Point(27, Point);
            // ��Ʈ�� �̸� ����
            control.Name = Name;
            control.Size = new System.Drawing.Size(75, 23);
            // �� �ε��� ����
            control.TabIndex = 0;
            return control;
        }
        public Form1()
        {
            // �ʱ�ȭ
            InitializeComponent();

            // ��ư �ν��Ͻ� ���� �� �ʱ� ����
            testButton = SetInitControl(new Button(), "Button1", 40);
            // ��ư�� Text ����
            this.testButton.Text = "Test Button";
            // ���� Control �߰�
            this.Controls.Add(this.testButton);

            


            // �̺�Ʈ �߰�(���ٽ����� �߰�)
            this.testButton.Click += (sender, e) =>
            {
                ThreadPool.QueueUserWorkItem((sender) =>
                {
                    // 0���� 9999���� ����
                    for (int nCount = 0; nCount < 10000; nCount++)
                    {
                        // �ܼ� ���
                        Console.WriteLine(nCount);
                        // ������ ��� 1��
                        Thread.Sleep(1000);
                    }
                });
                ThreadPool.QueueUserWorkItem((sender) =>
                {
                    // 0���� 9999���� ����
                    for (int nCount = 0; nCount > -10000; nCount--)
                    {
                        // �ܼ� ���
                        Console.WriteLine(nCount);
                        // ������ ��� 1��
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
