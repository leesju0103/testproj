namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            보기ToolStripMenuItem = new ToolStripMenuItem();
            저장ToolStripMenuItem = new ToolStripMenuItem();
            복사ToolStripMenuItem = new ToolStripMenuItem();
            붙여넣기ToolStripMenuItem = new ToolStripMenuItem();
            기록지우기ToolStripMenuItem = new ToolStripMenuItem();
            label_input = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button_seven = new Button();
            button_eight = new Button();
            button_nine = new Button();
            button_div = new Button();
            button_percent = new Button();
            button_four = new Button();
            button_five = new Button();
            button_six = new Button();
            button_mul = new Button();
            button_one = new Button();
            button_two = new Button();
            button_three = new Button();
            button_sub = new Button();
            button_zero = new Button();
            button_point = new Button();
            this.button_add = new Button();
            button_rac = new Button();
            this.button_equal = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 보기ToolStripMenuItem, 저장ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(318, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 보기ToolStripMenuItem
            // 
            보기ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 복사ToolStripMenuItem, 붙여넣기ToolStripMenuItem, 기록지우기ToolStripMenuItem });
            보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            보기ToolStripMenuItem.Size = new Size(64, 29);
            보기ToolStripMenuItem.Text = "보기";
            // 
            // 저장ToolStripMenuItem
            // 
            저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            저장ToolStripMenuItem.Size = new Size(64, 29);
            저장ToolStripMenuItem.Text = "저장";
            // 
            // 복사ToolStripMenuItem
            // 
            복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            복사ToolStripMenuItem.Size = new Size(270, 34);
            복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            붙여넣기ToolStripMenuItem.Size = new Size(270, 34);
            붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // 기록지우기ToolStripMenuItem
            // 
            기록지우기ToolStripMenuItem.Name = "기록지우기ToolStripMenuItem";
            기록지우기ToolStripMenuItem.Size = new Size(270, 34);
            기록지우기ToolStripMenuItem.Text = "기록 지우기";
            // 
            // label_input
            // 
            label_input.BackColor = SystemColors.InactiveBorder;
            label_input.BorderStyle = BorderStyle.FixedSingle;
            label_input.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label_input.Location = new Point(24, 48);
            label_input.Name = "label_input";
            label_input.Padding = new Padding(0, 0, 0, 10);
            label_input.Size = new Size(265, 200);
            label_input.TabIndex = 1;
            label_input.Text = "0";
            label_input.TextAlign = ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(this.button_equal, 4, 2);
            tableLayoutPanel1.Controls.Add(button_rac, 4, 1);
            tableLayoutPanel1.Controls.Add(this.button_add, 3, 3);
            tableLayoutPanel1.Controls.Add(button_point, 2, 3);
            tableLayoutPanel1.Controls.Add(button_zero, 0, 3);
            tableLayoutPanel1.Controls.Add(button_sub, 3, 2);
            tableLayoutPanel1.Controls.Add(button_three, 2, 2);
            tableLayoutPanel1.Controls.Add(button_two, 1, 2);
            tableLayoutPanel1.Controls.Add(button_one, 0, 2);
            tableLayoutPanel1.Controls.Add(button_mul, 3, 1);
            tableLayoutPanel1.Controls.Add(button_six, 2, 1);
            tableLayoutPanel1.Controls.Add(button_five, 1, 1);
            tableLayoutPanel1.Controls.Add(button_four, 0, 1);
            tableLayoutPanel1.Controls.Add(button_percent, 4, 0);
            tableLayoutPanel1.Controls.Add(button_div, 3, 0);
            tableLayoutPanel1.Controls.Add(button_nine, 2, 0);
            tableLayoutPanel1.Controls.Add(button_eight, 1, 0);
            tableLayoutPanel1.Controls.Add(button_seven, 0, 0);
            tableLayoutPanel1.Location = new Point(24, 265);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(265, 186);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button_seven
            // 
            button_seven.Dock = DockStyle.Fill;
            button_seven.Location = new Point(0, 3);
            button_seven.Margin = new Padding(0, 3, 3, 3);
            button_seven.Name = "button_seven";
            button_seven.Size = new Size(50, 40);
            button_seven.TabIndex = 0;
            button_seven.Text = "7";
            button_seven.UseVisualStyleBackColor = true;
            // 
            // button_eight
            // 
            button_eight.Dock = DockStyle.Fill;
            button_eight.Location = new Point(53, 3);
            button_eight.Margin = new Padding(0, 3, 3, 3);
            button_eight.Name = "button_eight";
            button_eight.Size = new Size(50, 40);
            button_eight.TabIndex = 1;
            button_eight.Text = "8";
            button_eight.UseVisualStyleBackColor = true;
            // 
            // button_nine
            // 
            button_nine.Dock = DockStyle.Fill;
            button_nine.Location = new Point(106, 3);
            button_nine.Margin = new Padding(0, 3, 3, 3);
            button_nine.Name = "button_nine";
            button_nine.Size = new Size(50, 40);
            button_nine.TabIndex = 2;
            button_nine.Text = "9";
            button_nine.UseVisualStyleBackColor = true;
            // 
            // button_div
            // 
            button_div.Dock = DockStyle.Fill;
            button_div.Location = new Point(159, 3);
            button_div.Margin = new Padding(0, 3, 3, 3);
            button_div.Name = "button_div";
            button_div.Size = new Size(50, 40);
            button_div.TabIndex = 3;
            button_div.Text = "/";
            button_div.UseVisualStyleBackColor = true;
            // 
            // button_percent
            // 
            button_percent.Dock = DockStyle.Fill;
            button_percent.Location = new Point(215, 3);
            button_percent.Margin = new Padding(3, 3, 0, 3);
            button_percent.Name = "button_percent";
            button_percent.Size = new Size(50, 40);
            button_percent.TabIndex = 4;
            button_percent.Text = "%";
            button_percent.UseVisualStyleBackColor = true;
            // 
            // button_four
            // 
            button_four.Dock = DockStyle.Fill;
            button_four.Location = new Point(0, 49);
            button_four.Margin = new Padding(0, 3, 3, 3);
            button_four.Name = "button_four";
            button_four.Size = new Size(50, 40);
            button_four.TabIndex = 5;
            button_four.Text = "4";
            button_four.UseVisualStyleBackColor = true;
            // 
            // button_five
            // 
            button_five.Dock = DockStyle.Fill;
            button_five.Location = new Point(53, 49);
            button_five.Margin = new Padding(0, 3, 3, 3);
            button_five.Name = "button_five";
            button_five.Size = new Size(50, 40);
            button_five.TabIndex = 6;
            button_five.Text = "5";
            button_five.UseVisualStyleBackColor = true;
            // 
            // button_six
            // 
            button_six.Dock = DockStyle.Fill;
            button_six.Location = new Point(106, 49);
            button_six.Margin = new Padding(0, 3, 3, 3);
            button_six.Name = "button_six";
            button_six.Size = new Size(50, 40);
            button_six.TabIndex = 7;
            button_six.Text = "6";
            button_six.UseVisualStyleBackColor = true;
            // 
            // button_mul
            // 
            button_mul.Dock = DockStyle.Fill;
            button_mul.Location = new Point(159, 49);
            button_mul.Margin = new Padding(0, 3, 3, 3);
            button_mul.Name = "button_mul";
            button_mul.Size = new Size(50, 40);
            button_mul.TabIndex = 8;
            button_mul.Text = "*";
            button_mul.UseVisualStyleBackColor = true;
            // 
            // button_one
            // 
            button_one.Dock = DockStyle.Fill;
            button_one.Location = new Point(0, 95);
            button_one.Margin = new Padding(0, 3, 3, 3);
            button_one.Name = "button_one";
            button_one.Size = new Size(50, 40);
            button_one.TabIndex = 10;
            button_one.Text = "1";
            button_one.UseVisualStyleBackColor = true;
            // 
            // button_two
            // 
            button_two.Dock = DockStyle.Fill;
            button_two.Location = new Point(53, 95);
            button_two.Margin = new Padding(0, 3, 3, 3);
            button_two.Name = "button_two";
            button_two.Size = new Size(50, 40);
            button_two.TabIndex = 11;
            button_two.Text = "2";
            button_two.UseVisualStyleBackColor = true;
            // 
            // button_three
            // 
            button_three.Dock = DockStyle.Fill;
            button_three.Location = new Point(106, 95);
            button_three.Margin = new Padding(0, 3, 3, 3);
            button_three.Name = "button_three";
            button_three.Size = new Size(50, 40);
            button_three.TabIndex = 12;
            button_three.Text = "3";
            button_three.UseVisualStyleBackColor = true;
            // 
            // button_sub
            // 
            button_sub.Dock = DockStyle.Fill;
            button_sub.Location = new Point(159, 95);
            button_sub.Margin = new Padding(0, 3, 3, 3);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(50, 40);
            button_sub.TabIndex = 13;
            button_sub.Text = "-";
            button_sub.UseVisualStyleBackColor = true;
            // 
            // button_zero
            // 
            tableLayoutPanel1.SetColumnSpan(button_zero, 2);
            button_zero.Dock = DockStyle.Fill;
            button_zero.Location = new Point(0, 141);
            button_zero.Margin = new Padding(0, 3, 3, 3);
            button_zero.Name = "button_zero";
            button_zero.Size = new Size(103, 42);
            button_zero.TabIndex = 15;
            button_zero.Text = "0";
            button_zero.UseVisualStyleBackColor = true;
            // 
            // button_point
            // 
            button_point.Dock = DockStyle.Fill;
            button_point.Location = new Point(106, 141);
            button_point.Margin = new Padding(0, 3, 3, 3);
            button_point.Name = "button_point";
            button_point.Size = new Size(50, 42);
            button_point.TabIndex = 17;
            button_point.Text = ".";
            button_point.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Dock = DockStyle.Fill;
            this.button_add.Location = new Point(159, 141);
            this.button_add.Margin = new Padding(0, 3, 3, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new Size(50, 42);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_rac
            // 
            button_rac.Dock = DockStyle.Fill;
            button_rac.Location = new Point(215, 49);
            button_rac.Margin = new Padding(3, 3, 0, 3);
            button_rac.Name = "button_rac";
            button_rac.Size = new Size(50, 40);
            button_rac.TabIndex = 19;
            button_rac.Text = "1/x";
            button_rac.UseVisualStyleBackColor = true;
            // 
            // button_equal
            // 
            this.button_equal.Dock = DockStyle.Fill;
            this.button_equal.Location = new Point(215, 95);
            this.button_equal.Margin = new Padding(3, 3, 0, 3);
            this.button_equal.Name = "button_equal";
            tableLayoutPanel1.SetRowSpan(this.button_equal, 2);
            this.button_equal.Size = new Size(50, 88);
            this.button_equal.TabIndex = 20;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 480);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label_input);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 보기ToolStripMenuItem;
        private ToolStripMenuItem 복사ToolStripMenuItem;
        private ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private ToolStripMenuItem 기록지우기ToolStripMenuItem;
        private ToolStripMenuItem 저장ToolStripMenuItem;
        private Label label_input;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_seven;
        private Button button20;
        private Button button15;
        private Button button_rac;
        private Button button19;
        private Button button_point;
        private Button button17;
        private Button button_zero;
        private Button button_sub;
        private Button button_three;
        private Button button_two;
        private Button button_one;
        private Button button_mul;
        private Button button_six;
        private Button button_five;
        private Button button_four;
        private Button button_percent;
        private Button button_div;
        private Button button_nine;
        private Button button_eight;
    }
}
