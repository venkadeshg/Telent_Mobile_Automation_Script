using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using Path = System.IO.Path;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;

namespace TestAutomation.Common
{
    class GeneralLibraries : Base
    {
        Random ran = new Random();
        public string addDaysTo(string dtN, int days)
        {
            DateTime dt = DateTime.ParseExact(dtN, "ddMMyyyy", null).AddDays(days);
            Console.WriteLine(dtN + ">> has been added with '" + days + "' days, new date is >> " + dt);
            return dtN = dt.ToString("ddMMyyyy");
        }
        public string Generatestrings(int length)
        {
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[ran.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public string GenerateNum(int length)
        {
            string characters = "0123456789";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[ran.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public bool OneWordMatches(string thestring, string otherstring)
        {
            return thestring.Split().Intersect(otherstring.Split()).Any();
        }

        public string getOrdinal(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }
            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }

        }

        public static int stringToInt(string value)
        {
            decimal valDouble;

            var comma = (NumberFormatInfo)CultureInfo.InstalledUICulture.NumberFormat.Clone();
            comma.NumberDecimalSeparator = ",";
            comma.NumberGroupSeparator = ".";

            var dot = (NumberFormatInfo)CultureInfo.InstalledUICulture.NumberFormat.Clone();
            dot.NumberDecimalSeparator = ".";
            dot.NumberGroupSeparator = ".";

            if (decimal.TryParse(value, NumberStyles.Currency, comma, out valDouble))
            {
                return Convert.ToInt32(valDouble);
            }
            else if (decimal.TryParse(value, NumberStyles.Currency, dot, out valDouble))
            {
                return Convert.ToInt32(valDouble);
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }            


        public void writeFeatureSteps(string flNm, string txt, string app)
        {
            string pth = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
            string FileName = pth +app+ "\\Features\\" + flNm + ".txt";
            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine(txt);
            }
        }

        public void writePDFtoText(string filePth, string filenm)
        {
            string[] words;
            string line;
            Directory.CreateDirectory(Path.GetDirectoryName(filePth + "\\PDFtexts\\"));
            using (PdfReader reader = new PdfReader(filePth + "\\" + filenm))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    words = PdfTextExtractor.GetTextFromPage(reader, i, new LocationTextExtractionStrategy()).Split('\n');
                    for (int j = 0, len = words.Length; j < len; j++)
                    {
                        line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));
                        File.AppendAllText(filePth + "\\PDFtexts\\" + Regex.Replace(filenm, ".pdf", ".txt"), line);
                    }

                }
            }
        }

        public string FindTextBetween(string text, string left, string right)
        {
            string val = "Couldn't split string between <"+left +"> and <"+ right +">";
            try
            {
                val = Regex.Split(text, left)[1];
                val = Regex.Split(val, right)[0];
            }
            catch (Exception e) { Base.LogWrite("exc:"+e); } 
            return val;
        }


        public void ExportToExcel(DataTable tbl, string excelFilePath)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    LogIt("ExportToExcel: Null or empty input table!\n", logTyp.Logs);

                // load excel, and create a new workbook
                //var excelApp = new Excel.Application();
                //excelApp.Workbooks.Add();

                //// single worksheet
                //Excel._Worksheet workSheet = excelApp.ActiveSheet;

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks workBooks = excelApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workBook = workBooks.Open(@excelFilePath);
                Microsoft.Office.Interop.Excel.Worksheet workSheet = workBook.Worksheets.get_Item("Book1");


                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[2, i + 2] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 3, j + 2] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workBook.Save();
                        workBook.Close();
                    }
                    catch (Exception ex)
                    {
                        LogIt("ExportToExcel: Excel file could not be saved! Check filepath.\n" + ex.Message, logTyp.Warn);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LogIt("ExportToExcel: Error\n" + ex.Message, logTyp.Warn);
            }
        }

    }
}
