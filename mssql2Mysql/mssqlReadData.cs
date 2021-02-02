using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using mssql2Mysql.Models;
using mssql2Mysql.ProductContext;
using System.Net;

namespace mssql2Mysql
{
    public class mssqlReadData
    {
        mssql2MysqlUnit mssql2MysqlUnit = new mssql2MysqlUnit();
        mssql2MysqlUnitDetail mssql2MysqlUnitDetail = new mssql2MysqlUnitDetail();
        mssql2MysqlFile mssql2MysqlFile = new mssql2MysqlFile();
        mssql2MysqlBrand mssql2MysqlBrand = new mssql2MysqlBrand();
        mssql2MysqlCategory mssql2MysqlCategory = new mssql2MysqlCategory();
        mssql2MysqlProduct Mssql2MysqlProduct = new mssql2MysqlProduct();
        public void read()
        {
            using (var contex = new Context())
            {
                List<File> GetAll = contex.Files.Where(s => s.State == true).ToList();
                foreach (var item in GetAll)
                {
                    try
                    {

                        mssql2MysqlFile.main(item);
                        item.State = false;
                        contex.SaveChanges();
                        
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }
                }
            }

        }
    }
}