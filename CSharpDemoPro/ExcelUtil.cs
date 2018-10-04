using System.Data;
using ExcelDataReader;
using System.IO;

namespace CSharpDemoPro
{
    class ExcelUtil
    {
       
        public DataTable ExcelToDataTable(string fileName) {
            //open file and returns as stream
            FileStream stream = File.Open(@"C:\Users\binsahoo\Desktop\specFlow", FileMode.Open,FileAccess.Read);
            //Createopenxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
          
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTableCollection table = result.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;


        }
    }
}
