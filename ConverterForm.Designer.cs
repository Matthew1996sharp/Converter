namespace Converter
{
    partial class ConverterForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceUSDLabel = new System.Windows.Forms.Label();
            this.ExchangeLabel = new System.Windows.Forms.Label();
            this.PriceUSDTextBox = new System.Windows.Forms.TextBox();
            this.ExchangeTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ConverterHelpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(10, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(230, 40);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Введите курс и цену в долларах и щёлкните на кнопку \"Пересчёт\"";
            // 
            // PriceUSDLabel
            // 
            this.PriceUSDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceUSDLabel.Location = new System.Drawing.Point(10, 65);
            this.PriceUSDLabel.Name = "PriceUSDLabel";
            this.PriceUSDLabel.Size = new System.Drawing.Size(80, 20);
            this.PriceUSDLabel.TabIndex = 1;
            this.PriceUSDLabel.Text = "Цена (USD)";
            // 
            // ExchangeLabel
            // 
            this.ExchangeLabel.AutoSize = true;
            this.ExchangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeLabel.Location = new System.Drawing.Point(10, 110);
            this.ExchangeLabel.Name = "ExchangeLabel";
            this.ExchangeLabel.Size = new System.Drawing.Size(111, 16);
            this.ExchangeLabel.TabIndex = 2;
            this.ExchangeLabel.Text = "Курс (RUB/USD)";
            // 
            // PriceUSDTextBox
            // 
            this.PriceUSDTextBox.Location = new System.Drawing.Point(140, 65);
            this.PriceUSDTextBox.Name = "PriceUSDTextBox";
            this.PriceUSDTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceUSDTextBox.TabIndex = 3;
            this.PriceUSDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceUSDTextBox_KeyPress);
            // 
            // ExchangeTextBox
            // 
            this.ExchangeTextBox.Location = new System.Drawing.Point(140, 110);
            this.ExchangeTextBox.Name = "ExchangeTextBox";
            this.ExchangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExchangeTextBox.TabIndex = 4;
            this.ExchangeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExchangeTextBox_KeyPress);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(10, 160);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(230, 40);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(30, 230);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(80, 30);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.Text = "Пересчет";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(150, 230);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(80, 30);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 292);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ExchangeTextBox);
            this.Controls.Add(this.PriceUSDTextBox);
            this.Controls.Add(this.ExchangeLabel);
            this.Controls.Add(this.PriceUSDLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "ConverterForm";
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceUSDLabel;
        private System.Windows.Forms.Label ExchangeLabel;
        private System.Windows.Forms.TextBox PriceUSDTextBox;
        private System.Windows.Forms.TextBox ExchangeTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.HelpProvider ConverterHelpProvider;
    }
}

