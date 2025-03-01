namespace RollerCoasterRide
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
            label1 = new Label();
            txtHeight = new TextBox();
            txtBackTrouble = new TextBox();
            label2 = new Label();
            txtHeartTrouble = new TextBox();
            label3 = new Label();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Height (cm):";
            label1.Click += label1_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(37, 71);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 1;
            // 
            // txtBackTrouble
            // 
            txtBackTrouble.Location = new Point(37, 124);
            txtBackTrouble.Name = "txtBackTrouble";
            txtBackTrouble.Size = new Size(125, 27);
            txtBackTrouble.TabIndex = 3;
            txtBackTrouble.TextChanged += txtBackTrouble_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 101);
            label2.Name = "label2";
            label2.Size = new Size(228, 20);
            label2.TabIndex = 2;
            label2.Text = "Do you have back trouble? (Y/N):";
            // 
            // txtHeartTrouble
            // 
            txtHeartTrouble.Location = new Point(37, 177);
            txtHeartTrouble.Name = "txtHeartTrouble";
            txtHeartTrouble.Size = new Size(125, 27);
            txtHeartTrouble.TabIndex = 5;
            txtHeartTrouble.TextChanged += txtHeartTrouble_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 154);
            label3.Name = "label3";
            label3.Size = new Size(228, 20);
            label3.TabIndex = 4;
            label3.Text = "Do you have heart trouble? (Y/N)";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(37, 241);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(228, 115);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check Eligibility";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(638, 124);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtHeartTrouble);
            Controls.Add(label3);
            Controls.Add(txtBackTrouble);
            Controls.Add(label2);
            Controls.Add(txtHeight);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RollerCoasterRide";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHeight;
        private TextBox txtBackTrouble;
        private Label label2;
        private TextBox txtHeartTrouble;
        private Label label3;
        private Button btnCheck;
        private Label lblResult;
    }
}