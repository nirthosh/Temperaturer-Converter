namespace Temperature
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
            txtTemperature = new TextBox();
            rbtCelcius = new RadioButton();
            rbtFahrenheit = new RadioButton();
            btnConvert = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Temperature :";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(156, 26);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(281, 31);
            txtTemperature.TabIndex = 1;
            // 
            // rbtCelcius
            // 
            rbtCelcius.AutoSize = true;
            rbtCelcius.Location = new Point(156, 76);
            rbtCelcius.Name = "rbtCelcius";
            rbtCelcius.Size = new Size(91, 29);
            rbtCelcius.TabIndex = 2;
            rbtCelcius.TabStop = true;
            rbtCelcius.Text = "Celcius";
            rbtCelcius.UseVisualStyleBackColor = true;
            // 
            // rbtFahrenheit
            // 
            rbtFahrenheit.AutoSize = true;
            rbtFahrenheit.Location = new Point(319, 76);
            rbtFahrenheit.Name = "rbtFahrenheit";
            rbtFahrenheit.Size = new Size(118, 29);
            rbtFahrenheit.TabIndex = 3;
            rbtFahrenheit.TabStop = true;
            rbtFahrenheit.Text = "Fahrenheit";
            rbtFahrenheit.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(156, 111);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(281, 35);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Red;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(156, 175);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(283, 98);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 401);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(rbtFahrenheit);
            Controls.Add(rbtCelcius);
            Controls.Add(txtTemperature);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Temperature Converter - NCB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTemperature;
        private RadioButton rbtCelcius;
        private RadioButton rbtFahrenheit;
        private Button btnConvert;
        private Label lblResult;
    }
}