using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ApiBLL
    {
        public object getDataForGUI()
        {
           ApiDAL apiDal = new ApiDAL();
            object data = apiDal.getData();
            return data;
        }
        public object getJsonForGUI()
        {
            ApiDAL apiDal = new ApiDAL();
            List<User> data = apiDal.getJson<User>();
            return data;
        }
        private ApiBLL _apiBLL;

        //public ApiBLL()
        //{
        //    _apiBLL = new ApiBLL();
        //}

        public List<Dssp> ReadExcelFileForGUI(string filePath)
        {
            ApiDAL apiDal = new ApiDAL();
            //object data = apiDal.ReadExcelFile(filePath);
            return apiDal.ReadExcelFile(filePath);
        }
    }
}
