using mssql2Mysql.ProductContext;
using mssql2Mysql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace mssql2Mysql
{
   public  class mssql2MysqlUnitDetail
    {
        public  void main(UnitDetail unitDetail)
        {

            string connStr = "server=localhost;user=morqet_int;database=product_pool_db;port=3306;password=morqet_int";
            MySqlConnection baglan = new MySqlConnection(connStr);

            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into unitdetails (ID,LanguageCode,Name,UnitID,State) values ('" + unitDetail.ID + "','" + unitDetail.LanguageCode.Replace("'", "\\'") + "','" + unitDetail.Name.Replace("'","\\'") + "','"+unitDetail.UnitID + "',0)", baglan);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.

                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                Console.WriteLine(HataYakala);
            }
        }
    }
}
