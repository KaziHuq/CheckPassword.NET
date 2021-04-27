
namespace PasswordCheckingApp
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRst = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(135, 128);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(175, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter your password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(135, 198);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(175, 25);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Enter your password";
            this.lbl2.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(248, 310);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 34);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(630, 195);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 34);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnRst
            // 
            this.btnRst.Location = new System.Drawing.Point(449, 310);
            this.btnRst.Name = "btnRst";
            this.btnRst.Size = new System.Drawing.Size(112, 34);
            this.btnRst.TabIndex = 6;
            this.btnRst.Text = "Reset";
            this.btnRst.UseVisualStyleBackColor = true;
            this.btnRst.Visible = false;
            this.btnRst.Click += new System.EventHandler(this.btnRst_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(170, 435);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(251, 25);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Please re-enter your password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(962, 526);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRst);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRst;
        private System.Windows.Forms.Label lblMessage;
    }
}

