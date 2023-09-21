using DTO;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApiDAL
    {
        public object getData()
        {
            string link = "http://data.gonsa.com.vn/api/depot/getKhoHang";
            HttpWebRequest req = HttpWebRequest.CreateHttp(link);
            WebResponse res = req.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<KhoHang>));
            object data = js.ReadObject(res.GetResponseStream());
            return data;
        }
        public List<User> getJson<User>()
        {
            string fileName = @"D:\WinForm\Validation-form-master\UserList.json";
            if (File.Exists(fileName))
            {
                string UserList = File.ReadAllText(fileName);
                List<User> data = JsonConvert.DeserializeObject<List<User>>(UserList);
                return data;
            }
            return null;
        }
        public List<Dssp> ReadExcelFile(string filePath)
        {
            List<Dssp> dsspList = new List<Dssp>();
            string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = string.Format(con, filePath, "yes");
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                string query = "SELECT * FROM [Sheet1$]";
                //DataTable dtexcel = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
                //"Select * from [" + excelsheet + "]"
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsspList.Add(new Dssp
                            {
                                MaSp = reader.GetValue(0).ToString(),
                                TenSp = reader.GetValue(1).ToString(),
                                SoLuong = int.Parse(reader.GetValue(2).ToString()),
                                MoTa = reader.GetValue(3).ToString(),
                                TinhTrang = reader.GetValue(4).ToString()
                            });
                        }
                    }
                }
            }
            return dsspList;
        }
    }
}
