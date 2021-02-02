using System;
using System.Collections.Generic;
using System.Text;

namespace mssql2Mysql
{
    public class ImageBase64
    {
        public void aa()
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(@"C:/" + "Logo.png");
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            Console.WriteLine(base64ImageRepresentation);


        }
    }//okey base64olmuşzaten
}
