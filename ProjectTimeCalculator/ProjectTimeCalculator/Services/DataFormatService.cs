using System.IO;
using System.Reflection;

namespace ProjectTimeCalculator
{
    public class DataFormatService
    {
        public string SelectedDateFormat = "dd.MM.yyyy";
        public DataFormatService() 
        {
            string[] dateFormats = GetDateFormats();
            if (dateFormats.Length > 0)
            {
                SelectedDateFormat = dateFormats[0];
            }
        }
        public string[] GetDateFormats()
        {
            return File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\dateformats.ini");
        }
    }
}
