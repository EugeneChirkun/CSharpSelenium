using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.ToWorkOnIt
{
    public class TableUtils
    {
        static List<TableDataCollection> _tableDataCollections = new List<TableDataCollection>();

        public static void ReadTable(IWebElement table)
        {
            //Get columns
            var columns = table.FindElements(By.XPath("//*[@role= 'columnheader']"));
            //Get rows
            var rows = table.FindElements(By.XPath("//*[@role= 'row']"));
            //Create row index
            int rowIndex = 0;

            foreach (var row in rows)
            {
                int colIndex = 0;

                var colDatas = row.FindElements(By.XPath("//*[@role= 'gridcell']"));

                foreach (var colValue in colDatas)
                {
                    _tableDataCollections.Add(new TableDataCollection
                    {
                        RowNumber = rowIndex,
                        ColumnName = columns[colIndex].Text != "" ?
                                      columns[colIndex].Text : colIndex.ToString(),
                        ColumnValue = colValue.Text
                    });

                    //Move to next column
                    colIndex++;
                }
                rowIndex++;
            }
        }

        public static string ReadCell(string columnName, int rowNumber)
        {
            var data = (from e in _tableDataCollections
                        where e.ColumnName == columnName && e.RowNumber == rowNumber
                        select e.ColumnValue).SingleOrDefault();

            return data;
        }
    }

    public class TableDataCollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
    }
}
