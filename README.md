# World Database SOAP Web Service

## :globe_with_meridians: Giới Thiệu
Dự án này bao gồm một **SOAP Web Service** giúp:
- Chuyển đổi nhiệt độ giữa Fahrenheit và Celsius.
- Khám phá cơ sở dữ liệu thế giới (World Database) với các dịch vụ như:
  - Lấy danh sách tất cả các quốc gia.
  - Lấy thông tin quốc gia theo mã quốc gia.
  - Lấy danh sách thành phố của một quốc gia cụ thể.
  - Và nhiều dịch vụ khác liên quan đến cơ sở dữ liệu thế giới.

## :package: Các Chức Năng
### Chuyển đổi nhiệt độ:
- **Fahrenheit to Celsius**: Chuyển từ Fahrenheit sang Celsius.
- **Celsius to Fahrenheit**: Chuyển từ Celsius sang Fahrenheit.

### Khám phá cơ sở dữ liệu thế giới:
- **GetAllCountries**: Lấy danh sách tất cả các quốc gia.
- **GetCountryByCode**: Lấy thông tin quốc gia theo mã quốc gia.
- **GetCitiesByCountryCode**: Lấy danh sách thành phố của một quốc gia cụ thể.
- Và nhiều dịch vụ khác liên quan đến cơ sở dữ liệu thế giới.

## :computer: Công Nghệ
- **C#**: Sử dụng C# để phát triển Web Service.
- **ASP.NET Web Service (ASMX)**: Xây dựng dịch vụ SOAP.
- **SQL Server**: Lưu trữ và truy vấn dữ liệu từ cơ sở dữ liệu thế giới.

## :warning: Yêu Cầu
- **Visual Studio 2019** hoặc phiên bản mới hơn.
- **SQL Server**.
- **Dữ liệu mẫu (World Database)** được nhập vào cơ sở dữ liệu.

## :construction_worker: Cài Đặt

### Bước 1: Cài Đặt Cơ Sở Dữ Liệu
1. Tạo cơ sở dữ liệu `World` trong SQL Server hoặc MySQL.
2. Sử dụng tập tin SQL đính kèm để nhập dữ liệu vào các bảng `city`, `country`.

### Bước 2: Cài Đặt Web Service
1. Tải dự án từ GitHub về.
2. Mở dự án WORLDSW trong **Visual Studio**.
3. Cấu hình chuỗi kết nối trong file `web.config`:
   ```xml
   <connectionStrings>
       <add name="ConnectionString" connectionString="Server=your_server;Database=World;User Id=your_user;Password=your_password;" />
   </connectionStrings>
4. Xây dựng và chạy dịch vụ.
### Bước 3: Cài Đặt Windows Forms Client
1. Tải dự án từ GitHub về.
2. Mở dự án worldUI trong **Visual Studio**.
### Bước 4: Khởi chạy dự án.
