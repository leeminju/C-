using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*이벤트 핸들러 -함수인데 특정 이벤트가 발생할 떄
         * 이벤트에 의해 연동되어 호출된다.
         * 이벤트 프로그래밍 방식-GUI(Graphic User Interface) 방식
         * 키보드로 데이터를 입력하는 방식이 아니라 컴퓨터로 들어오는 모든 기계적 움직임을 이벤트라고 보고
         * 마우스클릭,키누름, 마우스더블클릭,마우스 드래그 버튼 클릭 등을 모두 상수로 저장해 놓고 이러한 이벤트가
         * 발생하면 이벤트와 연동된 함수들(이벤트 핸들러)를 호출해서 처리하는 방식이다.
         * 프로그램에서 처리하지 않는 이벤트는 기복적으로 시스템에 처리하도록 되어있다
         * 이벤트 핸들러는 C#에서는 대리자나를 개념을 통해 구현되어 있다.
         * 이미 만들오진 대리자를 이용해 호출하기 때문데 함수의 모습을 수정할 수 없다.
         * 매개변수도 이미 다 지정되어 있는데 이벤트마다 약간씩 다르다*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtValue1.Text);
                int n2 = int.Parse(txtValue2.Text);

                lblResult.Text = String.Format("{0}", n1 + n2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtValue1.Text);
                int n2 = int.Parse(txtValue2.Text);

                lblResult.Text = String.Format("{0}", n1 - n2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtValue1.Text);
                int n2 = int.Parse(txtValue2.Text);

                lblResult.Text = String.Format("{0}", n1 * n2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtValue1.Text);
                int n2 = int.Parse(txtValue2.Text);
                lblResult.Text = String.Format("{0}", n1 / n2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
