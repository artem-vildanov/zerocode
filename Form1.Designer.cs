namespace zerocode
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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.price_but = new System.Windows.Forms.Button();
            this.kpp_but = new System.Windows.Forms.Button();
            this.wheel_but = new System.Windows.Forms.Button();
            this.privod_but = new System.Windows.Forms.Button();
            this.capacity_but = new System.Windows.Forms.Button();
            this.kuzov_but = new System.Windows.Forms.Button();
            this.output_res_but = new System.Windows.Forms.Button();
            this.price_panel = new System.Windows.Forms.Panel();
            this.choose_price = new System.Windows.Forms.Label();
            this.min_text_box = new System.Windows.Forms.TextBox();
            this.min_price = new System.Windows.Forms.Label();
            this.max_text_box = new System.Windows.Forms.TextBox();
            this.max_price = new System.Windows.Forms.Label();
            this.menu_panel.SuspendLayout();
            this.price_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.output_res_but);
            this.menu_panel.Controls.Add(this.kuzov_but);
            this.menu_panel.Controls.Add(this.capacity_but);
            this.menu_panel.Controls.Add(this.privod_but);
            this.menu_panel.Controls.Add(this.wheel_but);
            this.menu_panel.Controls.Add(this.kpp_but);
            this.menu_panel.Controls.Add(this.price_but);
            this.menu_panel.Location = new System.Drawing.Point(-5, -30);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(192, 524);
            this.menu_panel.TabIndex = 0;
            this.menu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // price_but
            // 
            this.price_but.Location = new System.Drawing.Point(17, 66);
            this.price_but.Name = "price_but";
            this.price_but.Size = new System.Drawing.Size(156, 47);
            this.price_but.TabIndex = 1;
            this.price_but.Text = "Цена";
            this.price_but.UseVisualStyleBackColor = true;
            // 
            // kpp_but
            // 
            this.kpp_but.Location = new System.Drawing.Point(17, 119);
            this.kpp_but.Name = "kpp_but";
            this.kpp_but.Size = new System.Drawing.Size(156, 47);
            this.kpp_but.TabIndex = 2;
            this.kpp_but.Text = "Коробка передач";
            this.kpp_but.UseVisualStyleBackColor = true;
            // 
            // wheel_but
            // 
            this.wheel_but.Location = new System.Drawing.Point(17, 172);
            this.wheel_but.Name = "wheel_but";
            this.wheel_but.Size = new System.Drawing.Size(156, 47);
            this.wheel_but.TabIndex = 3;
            this.wheel_but.Text = "Левый/правый руль";
            this.wheel_but.UseVisualStyleBackColor = true;
            // 
            // privod_but
            // 
            this.privod_but.Location = new System.Drawing.Point(17, 225);
            this.privod_but.Name = "privod_but";
            this.privod_but.Size = new System.Drawing.Size(156, 47);
            this.privod_but.TabIndex = 4;
            this.privod_but.Text = "Привод";
            this.privod_but.UseVisualStyleBackColor = true;
            // 
            // capacity_but
            // 
            this.capacity_but.Location = new System.Drawing.Point(17, 278);
            this.capacity_but.Name = "capacity_but";
            this.capacity_but.Size = new System.Drawing.Size(156, 47);
            this.capacity_but.TabIndex = 5;
            this.capacity_but.Text = "Объем двигателя";
            this.capacity_but.UseVisualStyleBackColor = true;
            // 
            // kuzov_but
            // 
            this.kuzov_but.Location = new System.Drawing.Point(17, 331);
            this.kuzov_but.Name = "kuzov_but";
            this.kuzov_but.Size = new System.Drawing.Size(156, 47);
            this.kuzov_but.TabIndex = 6;
            this.kuzov_but.Text = "Тип кузова";
            this.kuzov_but.UseVisualStyleBackColor = true;
            // 
            // output_res_but
            // 
            this.output_res_but.Location = new System.Drawing.Point(17, 384);
            this.output_res_but.Name = "output_res_but";
            this.output_res_but.Size = new System.Drawing.Size(156, 94);
            this.output_res_but.TabIndex = 7;
            this.output_res_but.Text = "Вывести результаты";
            this.output_res_but.UseVisualStyleBackColor = true;
            // 
            // price_panel
            // 
            this.price_panel.Controls.Add(this.max_price);
            this.price_panel.Controls.Add(this.max_text_box);
            this.price_panel.Controls.Add(this.min_price);
            this.price_panel.Controls.Add(this.min_text_box);
            this.price_panel.Controls.Add(this.choose_price);
            this.price_panel.Location = new System.Drawing.Point(186, -30);
            this.price_panel.Name = "price_panel";
            this.price_panel.Size = new System.Drawing.Size(744, 524);
            this.price_panel.TabIndex = 1;
            // 
            // choose_price
            // 
            this.choose_price.AutoSize = true;
            this.choose_price.Location = new System.Drawing.Point(292, 225);
            this.choose_price.Name = "choose_price";
            this.choose_price.Size = new System.Drawing.Size(83, 13);
            this.choose_price.TabIndex = 0;
            this.choose_price.Text = "Выберите цену";
            // 
            // min_text_box
            // 
            this.min_text_box.Location = new System.Drawing.Point(54, 331);
            this.min_text_box.Name = "min_text_box";
            this.min_text_box.Size = new System.Drawing.Size(155, 20);
            this.min_text_box.TabIndex = 1;
            // 
            // min_price
            // 
            this.min_price.AutoSize = true;
            this.min_price.Location = new System.Drawing.Point(76, 312);
            this.min_price.Name = "min_price";
            this.min_price.Size = new System.Drawing.Size(105, 13);
            this.min_price.TabIndex = 2;
            this.min_price.Text = "Минимальная цена";
            // 
            // max_text_box
            // 
            this.max_text_box.Location = new System.Drawing.Point(470, 331);
            this.max_text_box.Name = "max_text_box";
            this.max_text_box.Size = new System.Drawing.Size(155, 20);
            this.max_text_box.TabIndex = 3;
            // 
            // max_price
            // 
            this.max_price.AutoSize = true;
            this.max_price.Location = new System.Drawing.Point(498, 312);
            this.max_price.Name = "max_price";
            this.max_price.Size = new System.Drawing.Size(111, 13);
            this.max_price.TabIndex = 4;
            this.max_price.Text = "Максимальная цена";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 488);
            this.Controls.Add(this.price_panel);
            this.Controls.Add(this.menu_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_panel.ResumeLayout(false);
            this.price_panel.ResumeLayout(false);
            this.price_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button output_res_but;
        private System.Windows.Forms.Button kuzov_but;
        private System.Windows.Forms.Button capacity_but;
        private System.Windows.Forms.Button privod_but;
        private System.Windows.Forms.Button wheel_but;
        private System.Windows.Forms.Button kpp_but;
        private System.Windows.Forms.Button price_but;
        private System.Windows.Forms.Panel price_panel;
        private System.Windows.Forms.Label choose_price;
        private System.Windows.Forms.Label max_price;
        private System.Windows.Forms.TextBox max_text_box;
        private System.Windows.Forms.Label min_price;
        private System.Windows.Forms.TextBox min_text_box;
    }
}

