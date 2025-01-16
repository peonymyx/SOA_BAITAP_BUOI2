using System.Data;
using WorldREF;

namespace world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                // Tạo SOAP client
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                // Gọi dịch vụ và chờ kết quả
                var response = await client.GetAllCountriesAsync();

                // Lấy danh sách quốc gia từ kết quả trả về
                List<string> countries = response.Body.GetAllCountriesResult;

                if (countries != null && countries.Count > 0) // Kiểm tra nếu kết quả không rỗng
                {
                    // Chuyển đổi danh sách thành DataTable
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("CountryName", typeof(string));

                    foreach (var country in countries)
                    {
                        dataTable.Rows.Add(country);
                    }

                    // Gắn dữ liệu vào DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không có quốc gia nào được tìm thấy.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải danh sách quốc gia: {ex.Message}");
            }
        }

        private async void Button2_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                // Get the input country code from the text box
                string countryCode = txtInput.Text.Trim();

                // Check if the input is not empty
                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Vui lòng nhập mã quốc gia.");
                    return;
                }

                // Create SOAP client
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                // Call the service and wait for the result
                var response = await client.GetCountryByCodeAsync(countryCode);

                // Get the list of cities from the response
                string country = response.Body.GetCountryByCodeResult;

                if (!string.IsNullOrEmpty(country)) // Check if the city is found
                {
                    // Create a DataTable to display the city details
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("CityDetails", typeof(string));

                    // Add the city details to the DataTable
                    dataTable.Rows.Add(country);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quốc gia có tên trên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải danh sách quốc gia: {ex.Message}");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input country code from the text box
                string cityName = txtInput.Text.Trim();

                // Check if the input is not empty
                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Vui lòng nhập tên thành phố.");
                    return;
                }

                // Create SOAP client
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                // Call the service and wait for the result
                var response = await client.GetCityByNameAsync(cityName);

                // Get the list of cities from the response
                string cities = response.Body.GetCityByNameResult;

                if (!string.IsNullOrEmpty(cities)) // Check if the city is found
                {
                    // Create a DataTable to display the city details
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("CityDetails", typeof(string));

                    // Add the city details to the DataTable
                    dataTable.Rows.Add(cities);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thành phố có tên trên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input country code from the text box
                string countryCode = txtInput.Text.Trim();

                // Check if the input is not empty
                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Vui lòng nhập mã quốc gia.");
                    return;
                }

                // Create SOAP client
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                // Call the service and wait for the result
                var response = await client.GetCitiesByCountryCodeAsync(countryCode);

                // Get the list of cities from the response
                List<string> cities = response.Body.GetCitiesByCountryCodeResult;

                if (cities != null && cities.Count > 0) // Check if cities are found
                {
                    // Convert the list of cities into a DataTable
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("CityName", typeof(string));

                    foreach (var city in cities)
                    {
                        dataTable.Rows.Add(city);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thành phố nào cho mã quốc gia đã nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải danh sách thành phố: {ex.Message}");
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input country code from the text box
                string countryName = txtInput.Text.Trim();

                // Check if the input is not empty
                if (string.IsNullOrEmpty(countryName))
                {
                    MessageBox.Show("Vui lòng nhập tên quốc gia.");
                    return;
                }

                // Create SOAP client
                WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                // Call the service and wait for the result
                var response = await client.GetCountryPopulationAsync(countryName);

                // Get the list of cities from the response
                int population = response.Body.GetCountryPopulationResult;

                if (population > 0)
                {
                    // Create a DataTable to display the population information
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Population", typeof(int));  // Make sure the column type is integer

                    // Add the population value to the DataTable
                    dataTable.Rows.Add(population);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quốc gia có tên trên hoặc dân số không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}");
            }
        }
    }
}
