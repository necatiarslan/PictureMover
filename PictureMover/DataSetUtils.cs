using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMover
{
    internal class DataSetUtils
    {

        public static DataSet CreateDataSet()
        {
            // Create a DataSet and a DataTable
            DataSet dataSet = new DataSet("FileData");
            DataTable dataTable = new DataTable("Files");

            // Define the columns for the DataTable
            dataTable.Columns.Add("FilePath", typeof(string));
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("Folder", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Destination", typeof(string));
            dataTable.Columns.Add("ExistsOnDestination", typeof(bool));
            dataTable.Columns.Add("DestinationFilePath", typeof(string));
            dataTable.Columns.Add("FileCopied", typeof(bool));
            dataTable.Columns.Add("SourceFile", typeof(SourceFile));

            // Add the DataTable to the DataSet
            dataSet.Tables.Add(dataTable);

            return dataSet;
        }
    }
}
