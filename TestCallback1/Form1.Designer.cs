namespace TestCallback1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.send = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.messagebox = new System.Windows.Forms.TextBox();
            this.hisId = new System.Windows.Forms.TextBox();
            this.yourId = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(197, 178);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 0;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(12, 178);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(179, 20);
            this.sendMessage.TabIndex = 1;
            this.sendMessage.Text = "Message";
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(12, 50);
            this.messagebox.Multiline = true;
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(266, 96);
            this.messagebox.TabIndex = 2;
            // 
            // hisId
            // 
            this.hisId.Location = new System.Drawing.Point(12, 152);
            this.hisId.Name = "hisId";
            this.hisId.Size = new System.Drawing.Size(52, 20);
            this.hisId.TabIndex = 3;
            this.hisId.Text = "id";
            // 
            // yourId
            // 
            this.yourId.Location = new System.Drawing.Point(12, 12);
            this.yourId.Name = "yourId";
            this.yourId.Size = new System.Drawing.Size(52, 20);
            this.yourId.TabIndex = 4;
            this.yourId.Text = "your id";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(197, 10);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 5;
            this.register.Text = "register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.register);
            this.Controls.Add(this.yourId);
            this.Controls.Add(this.hisId);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox sendMessage;
        private System.Windows.Forms.TextBox messagebox;
        private System.Windows.Forms.TextBox hisId;
        private System.Windows.Forms.TextBox yourId;
        private System.Windows.Forms.Button register;
    }
}

