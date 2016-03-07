using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCopyBackupService
{
    public class ImageClass
    {
        private DateTime    CreationDate;
        private string      path;
        private string      DateFolderConvention;
        private string      filename;

        public ImageClass(string _path)
        {
            path = _path;
            CreationDate = File.GetLastWriteTime(@path);

            int month = CreationDate.Month;
            int year = CreationDate.Year;
            string monthString;

            filename = Path.GetFileName(path);

            // TODO - SWITCH WITH ENUM
            Dictionary<int, string> monthName = new Dictionary<int,string>();
            monthName.Add(1, "Jaunary");
            monthName.Add(2, "February");
            monthName.Add(3, "March");
            monthName.Add(4, "April");
            monthName.Add(5, "May");
            monthName.Add(6, "June");
            monthName.Add(7, "July");
            monthName.Add(8, "August");
            monthName.Add(9, "September");
            monthName.Add(10, "October");
            monthName.Add(11, "November");
            monthName.Add(12, "December");

            monthString = monthName[month];
            if (month < 10)
            {
                DateFolderConvention = "0" + month.ToString() + "-" + year.ToString() + " " + monthName[month].ToString();
            }
            else
            {
                DateFolderConvention = month.ToString() + "-" + year.ToString() + " " + monthName[month].ToString();
            }
        }

        public string GetPath()
        {
            return path;
        }

        public string GetDateFolderConvention()
        {
            return DateFolderConvention;
        }

        public string GetFilename()
        {
            return filename;
        }
    }
}
