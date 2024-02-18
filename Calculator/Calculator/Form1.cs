using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Boolean op_change_flag = false, end_flag = false;
        double first_value, second_value, tmp;
        char op;

        /// 이승주
        /// 2024/2/19
        /// 숫자 버튼 클릭했을 때 화면에 표시
        private void button_num_Click(object sender, EventArgs e)
        {
            Button btnNum = (Button)sender;
            if (op_change_flag || label_input.Text == "0" || end_flag)
            {
                label_input.Text = "";
                op_change_flag = false;
                end_flag = false;
            }
            label_input.Text += btnNum.Text;
        }

        /// 이승주
        /// 2024/2/19
        /// 소수점 입력
        private void button_point_Click(object sender, EventArgs e)
        {
            if (label_input.Text.Contains("."))
                return;
            else
                label_input.Text += ".";
        }

        /// 이승주
        /// 2024/2/19
        /// 연산해야 할 숫자 변수에 저장, 입력된 숫자 히스토리에 기록
        private void button_op_Click(object sender, EventArgs e)
        {
            Button btnOp = (Button)sender;
            if (op_change_flag)
                return;
            first_value = Double.Parse(label_input.Text);
            textbox_history.Text += first_value + " " + btnOp.Text + " ";
            op = btnOp.Text[0];
            op_change_flag = true;
        }

        /// 이승주
        /// 2024/2/19
        /// 숫자 연산 후 화면에 표시
        private void button_result_Click(object sender, EventArgs e)
        {
            second_value = Double.Parse(label_input.Text);
            textbox_history.Text += second_value;
            if (op == '+')
            {
                label_input.Text = (first_value + second_value).ToString();
            }
            else if (op == '-')
            {
                label_input.Text = (first_value - second_value).ToString();
            }
            else if (op == '*')
            {
                label_input.Text = (first_value * second_value).ToString();
            }
            else if (op == '/')
            {
                if (second_value == 0)
                    label_input.Text = "0으로 나눌 수 없습니다";
                else
                    label_input.Text = (first_value / second_value).ToString();
            }
            textbox_history.Text += "\n";
            end_flag = true;
        }

        private void button_rac_Click(object sender, EventArgs e)
        {
            tmp = Double.Parse(label_input.Text);
            tmp = 1 / tmp;
            label_input.Text = tmp.ToString();
        }

        /// 이승주
        /// 2024/2/19
        /// 저장 버튼 클릭 시 파일 내보내기
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "다른 이름으로 저장";
            sfd.OverwritePrompt = true;
            sfd.Filter = "텍스트 문서(*.txt)|*.txt; |모든 파일(*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if(sfd.FileName != "")
                {
                    Console.WriteLine(sfd.FileName);
                    System.IO.File.WriteAllText(sfd.FileName, textbox_history.Text);
                }
            }

            return;
        }
    }
}
