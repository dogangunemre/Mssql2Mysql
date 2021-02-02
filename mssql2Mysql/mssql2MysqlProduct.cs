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
   public  class mssql2MysqlProduct
    {
        public  void main(Product product)
        {

            string connStr = "server=localhost;user=morqet_int;database=product_pool_db;port=3306;password=morqet_int";
            MySqlConnection baglan = new MySqlConnection(connStr);

            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into products (ID,LanguageCode,BrandID,UnitID,Barcode,SKU,Name,Description,State,Code,CategoryID,Price,Source) values ('" + product.ID + "','" + product.LanguageCode.Replace("'", "\\'") + "','"+product.BrandID+"','"+product.UnitID + "','"+product.Barcode+ "','" + product.SKU + "','" + product.Name.Replace("'", "\\'") + "','" + product.Description.Replace("'", "\\'") + "','" + product.State + "','" + product.Code.Replace("'", "\\'") + "','" + product.CategoryID + "','" + product.Price.ToString().Replace(",",".") + "','" + product.Source + "')", baglan);
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
