
namespace DruidPizza
{
    partial class Orders
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
            this.Price = new System.Windows.Forms.Label();
            this.CreatedDate = new System.Windows.Forms.Label();
            this.ModifiedDate = new System.Windows.Forms.Label();
            this.DailyBonus = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtModifiedDate = new System.Windows.Forms.TextBox();
            this.txtDailyBonus = new System.Windows.Forms.TextBox();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(65, 62);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSize = true;
            this.CreatedDate.Location = new System.Drawing.Point(65, 99);
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Size = new System.Drawing.Size(88, 17);
            this.CreatedDate.TabIndex = 2;
            this.CreatedDate.Text = "CreatedDate";
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.AutoSize = true;
            this.ModifiedDate.Location = new System.Drawing.Point(65, 133);
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Size = new System.Drawing.Size(91, 17);
            this.ModifiedDate.TabIndex = 3;
            this.ModifiedDate.Text = "ModifiedDate";
            // 
            // DailyBonus
            // 
            this.DailyBonus.AutoSize = true;
            this.DailyBonus.Location = new System.Drawing.Point(65, 170);
            this.DailyBonus.Name = "DailyBonus";
            this.DailyBonus.Size = new System.Drawing.Size(79, 17);
            this.DailyBonus.TabIndex = 4;
            this.DailyBonus.Text = "DailyBonus";
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Location = new System.Drawing.Point(65, 216);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(45, 17);
            this.Users.TabIndex = 5;
            this.Users.Text = "Users";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(249, 57);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(195, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(249, 94);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(195, 22);
            this.txtCreatedDate.TabIndex = 9;
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(249, 130);
            this.txtModifiedDate.Name = "txtModifiedDate";
            this.txtModifiedDate.Size = new System.Drawing.Size(195, 22);
            this.txtModifiedDate.TabIndex = 10;
            // 
            // txtDailyBonus
            // 
            this.txtDailyBonus.Location = new System.Drawing.Point(249, 170);
            this.txtDailyBonus.Name = "txtDailyBonus";
            this.txtDailyBonus.Size = new System.Drawing.Size(195, 22);
            this.txtDailyBonus.TabIndex = 11;
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(249, 213);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(195, 22);
            this.txtUsers.TabIndex = 12;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.txtDailyBonus);
            this.Controls.Add(this.txtModifiedDate);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.DailyBonus);
            this.Controls.Add(this.ModifiedDate);
            this.Controls.Add(this.CreatedDate);
            this.Controls.Add(this.Price);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label CreatedDate;
        private System.Windows.Forms.Label ModifiedDate;
        private System.Windows.Forms.Label DailyBonus;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtModifiedDate;
        private System.Windows.Forms.TextBox txtDailyBonus;
        private System.Windows.Forms.TextBox txtUsers;
    }
}

