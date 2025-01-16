using ServiceReference1;

namespace TemperatureConversionUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // L?y gi� tr? ng??i d�ng nh?p v�o
            string celsiusText = txtCelsius.Text.Trim();
            string fahrenheitText = txtFahrenheit.Text.Trim();

            // Ki?m tra c? 2 � tr?ng
            if (string.IsNullOrEmpty(celsiusText) && string.IsNullOrEmpty(fahrenheitText))
            {
                MessageBox.Show("Vui l�ng nh?p gi� tr? nhi?t ??.");
                return;
            }

            // Ki?m tra c? 2 � c� gi� tr?
            if (!string.IsNullOrEmpty(celsiusText) && !string.IsNullOrEmpty(fahrenheitText))
            {
                MessageBox.Show("Vui l�ng ch? nh?p gi� tr? v�o m?t �.");
                return;
            }

            try
            {
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
                // Ki?m tra n?u ng??i d�ng nh?p ?? Celsius
                if (!string.IsNullOrEmpty(celsiusText))
                {
                    if (double.TryParse(celsiusText, out double celsius))  // Ki?m tra n?u ng??i d�ng nh?p m?t s? h?p l?
                    {
                        var response = await client.CelsiusToFahrenheitAsync(celsius);
                        // Hi?n th? k?t qu? chuy?n ??i
                        txtFahrenheit.Text = response.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui l�ng nh?p gi� tr? h?p l? cho ?? Celsius.");
                    }
                }
                // Ki?m tra n?u ng??i d�ng nh?p ?? Fahrenheit
                else if (!string.IsNullOrEmpty(fahrenheitText))
                {
                    if (double.TryParse(fahrenheitText, out double fahrenheit))  // Ki?m tra n?u ng??i d�ng nh?p m?t s? h?p l?
                    {
                        var response = await client.FahrenheitToCelsiusAsync(fahrenheit);
                        // Hi?n th? k?t qu? chuy?n ??i
                        txtCelsius.Text = response.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui l�ng nh?p gi� tr? h?p l? cho ?? Fahrenheit.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i: {ex.Message}");
            }
        }
    }
}
