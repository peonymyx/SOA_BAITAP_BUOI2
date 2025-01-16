using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WORLDWS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService] Data Source=LAPTOP-GN0LH43T\PEONYSERVER;Initial Catalog=world;Integrated Security=True;Trust Server Certificate=True
    public class WebService1 : System.Web.Services.WebService
    {
        private readonly string connectionString = "Data Source=LAPTOP-GN0LH43T\\PEONYSERVER;Initial Catalog=world;Integrated Security=True";
        [WebMethod]
        public List<string> GetAllCountries()
        {
            var countries = new List<string>();
            string query = "SELECT Name FROM country";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    countries.Add(reader["Name"].ToString());
                }
            }

            return countries;
        }
        [WebMethod]
        public string GetCountryByCode(string code)
        {
            string query = "SELECT Name FROM country WHERE Code = @Code";
            string countryName = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", code);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    countryName = reader["Name"].ToString();
                }
            }

            return countryName ?? "Country not found.";
        }
        [WebMethod]
        public string GetCityByName(string cityName)
        {
            string query = "SELECT Name FROM city WHERE Name = @CityName";
            string result = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CityName", cityName);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    result = reader["Name"].ToString();
                }
            }

            return result ?? "City not found.";
        }

        [WebMethod]
        public List<string> GetCitiesByCountryCode(string countryCode)
        {
            var cities = new List<string>();
            string query = "SELECT Name FROM city WHERE CountryCode = @CountryCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CountryCode", countryCode);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cities.Add(reader["Name"].ToString());
                }
            }

            return cities;
        }

        [WebMethod]
        public int GetCountryPopulation(string code)
        {
            string query = "SELECT Population FROM country WHERE Code = @Code";
            int population = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", code);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    population = Convert.ToInt32(reader["Population"]);
                }
            }

            return population;
        }
    }
}
