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
            // L?y giá tr? ng??i dùng nh?p vào
            string celsiusText = txtCelsius.Text.Trim();
            string fahrenheitText = txtFahrenheit.Text.Trim();

            // Ki?m tra c? 2 ô tr?ng
            if (string.IsNullOrEmpty(celsiusText) && string.IsNullOrEmpty(fahrenheitText))
            {
                MessageBox.Show("Vui lòng nh?p giá tr? nhi?t ??.");
                return;
            }

            // Ki?m tra c? 2 ô có giá tr?
            if (!string.IsNullOrEmpty(celsiusText) && !string.IsNullOrEmpty(fahrenheitText))
            {
                MessageBox.Show("Vui lòng ch? nh?p giá tr? vào m?t ô.");
                return;
            }

            try
            {
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
                // Ki?m tra n?u ng??i dùng nh?p ?? Celsius
                if (!string.IsNullOrEmpty(celsiusText))
                {
                    if (double.TryParse(celsiusText, out double celsius))  // Ki?m tra n?u ng??i dùng nh?p m?t s? h?p l?
                    {
                        var response = await client.CelsiusToFahrenheitAsync(celsius);
                        // Hi?n th? k?t qu? chuy?n ??i
                        txtFahrenheit.Text = response.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nh?p giá tr? h?p l? cho ?? Celsius.");
                    }
                }
                // Ki?m tra n?u ng??i dùng nh?p ?? Fahrenheit
                else if (!string.IsNullOrEmpty(fahrenheitText))
                {
                    if (double.TryParse(fahrenheitText, out double fahrenheit))  // Ki?m tra n?u ng??i dùng nh?p m?t s? h?p l?
                    {
                        var response = await client.FahrenheitToCelsiusAsync(fahrenheit);
                        // Hi?n th? k?t qu? chuy?n ??i
                        txtCelsius.Text = response.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nh?p giá tr? h?p l? cho ?? Fahrenheit.");
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
