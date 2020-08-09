namespace login_practice0809
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(293, 150);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(100, 25);
            this.id_text.TabIndex = 2;
            // 
            // pw_text
            // 
            this.pw_text.Location = new System.Drawing.Point(293, 215);
            this.pw_text.Name = "pw_text";
            this.pw_text.PasswordChar = '*';
            this.pw_text.Size = new System.Drawing.Size(100, 25);
            this.pw_text.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(460, 163);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(115, 70);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(271, 68);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(132, 15);
            this.welcome_label.TabIndex = 5;
            this.welcome_label.Text = "This is Log-in form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pw_text);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox pw_text;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label welcome_label;
    }
}

