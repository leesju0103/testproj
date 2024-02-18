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

        /// �̽���
        /// 2024/2/19
        /// ���� ��ư Ŭ������ �� ȭ�鿡 ǥ��
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

        /// �̽���
        /// 2024/2/19
        /// �Ҽ��� �Է�
        private void button_point_Click(object sender, EventArgs e)
        {
            if (label_input.Text.Contains("."))
                return;
            else
                label_input.Text += ".";
        }

        /// �̽���
        /// 2024/2/19
        /// �����ؾ� �� ���� ������ ����, �Էµ� ���� �����丮�� ���
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

        /// �̽���
        /// 2024/2/19
        /// ���� ���� �� ȭ�鿡 ǥ��
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
                    label_input.Text = "0���� ���� �� �����ϴ�";
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

        /// �̽���
        /// 2024/2/19
        /// ���� ��ư Ŭ�� �� ���� ��������
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "�ٸ� �̸����� ����";
            sfd.OverwritePrompt = true;
            sfd.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt; |��� ����(*.*)|*.*";

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
