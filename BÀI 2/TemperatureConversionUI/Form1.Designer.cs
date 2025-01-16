namespace TemperatureConversionUI
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
            label2 = new Label();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 111);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Celsius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 212);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Fahrenheit";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(271, 109);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(283, 27);
            txtCelsius.TabIndex = 2;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(271, 209);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(283, 27);
            txtFahrenheit.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(298, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private Button button1;
    }
}
