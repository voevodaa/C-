namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.operandLeft = new System.Windows.Forms.Label();
            this.operandRight = new System.Windows.Forms.Label();
            this.operand = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operandLeft
            // 
            this.operandLeft.AutoSize = true;
            this.operandLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.operandLeft.Location = new System.Drawing.Point(51, 129);
            this.operandLeft.Name = "operandLeft";
            this.operandLeft.Size = new System.Drawing.Size(106, 73);
            this.operandLeft.TabIndex = 0;
            this.operandLeft.Text = "10";
            // 
            // operandRight
            // 
            this.operandRight.AutoSize = true;
            this.operandRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.operandRight.Location = new System.Drawing.Point(291, 129);
            this.operandRight.Name = "operandRight";
            this.operandRight.Size = new System.Drawing.Size(106, 73);
            this.operandRight.TabIndex = 1;
            this.operandRight.Text = "10";
            // 
            // operand
            // 
            this.operand.AutoSize = true;
            this.operand.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.operand.Location = new System.Drawing.Point(189, 129);
            this.operand.Name = "operand";
            this.operand.Size = new System.Drawing.Size(70, 73);
            this.operand.TabIndex = 2;
            this.operand.Text = "+";
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.solution.Location = new System.Drawing.Point(422, 129);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(70, 73);
            this.solution.TabIndex = 3;
            this.solution.Text = "=";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(508, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 93);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(768, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 93);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ответить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 412);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(960, 86);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerShow
            // 
            this.timerShow.AutoSize = true;
            this.timerShow.Font = new System.Drawing.Font("Segoe UI Black", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.timerShow.ForeColor = System.Drawing.Color.LawnGreen;
            this.timerShow.Location = new System.Drawing.Point(140, 252);
            this.timerShow.Name = "timerShow";
            this.timerShow.Size = new System.Drawing.Size(152, 128);
            this.timerShow.TabIndex = 7;
            this.timerShow.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Секунды";
            // 
            // progressBarText
            // 
            this.progressBarText.AutoSize = true;
            this.progressBarText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBarText.Font = new System.Drawing.Font("Segoe UI Black", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.progressBarText.Location = new System.Drawing.Point(422, 433);
            this.progressBarText.Name = "progressBarText";
            this.progressBarText.Size = new System.Drawing.Size(141, 54);
            this.progressBarText.TabIndex = 9;
            this.progressBarText.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(983, 496);
            this.Controls.Add(this.progressBarText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerShow);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.operand);
            this.Controls.Add(this.operandRight);
            this.Controls.Add(this.operandLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Посчитайка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label operandLeft;
        private Label operandRight;
        private Label operand;
        private Label solution;
        private TextBox textBox1;
        private Button button1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label timerShow;
        private Label label1;
        private Label progressBarText;
    }
}